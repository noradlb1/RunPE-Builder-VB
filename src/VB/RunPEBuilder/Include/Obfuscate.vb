Imports dnlib.DotNet
Imports dnlib.DotNet.Emit
Imports System
Imports System.Linq

Namespace RunPEBuilder.Include
    Public Module RandomUtils
        Private random As Random = New Random()

        Public Function RandomString(length As Integer) As String
            Const chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"
            Return New String(Enumerable.Repeat(chars, length).[Select](Function(s) s(random.Next(s.Length))).ToArray())
        End Function
    End Module

    Public Class RenameProtector
        Public Shared count_xxx As Integer = 0

        Public Shared Sub Execute([module] As ModuleDef, outPath As String)
            Try
                [module].Name = RandomString(7)

                For Each type In [module].Types
                    If type.IsGlobalModuleType OrElse type.IsRuntimeSpecialName OrElse type.IsSpecialName OrElse type.IsWindowsRuntime OrElse type.IsInterface Then Continue For

                    count_xxx += 1
                    type.Name = RandomString(40)
                    type.Namespace = ""

                    For Each [property] In type.Properties
                        count_xxx += 1
                        [property].Name = RandomString(40)
                    Next

                    For Each field In type.Fields
                        count_xxx += 1
                        field.Name = RandomString(40)
                    Next

                    For Each eventDef In type.Events
                        count_xxx += 1
                        eventDef.Name = RandomString(40)
                    Next

                    For Each method In type.Methods
                        If method.IsConstructor Then Continue For
                        count_xxx += 1
                        method.Name = RandomString(40)
                    Next
                Next

                ' Write the modified module to the specified output path
                [module].Write(outPath)
            Catch ex As Exception
                Console.WriteLine($"An error occurred during renaming: {ex.Message}")
            End Try
        End Sub
    End Class

    Public Class JunkMethods
        Public Shared Sub Execute([module] As ModuleDef, OutPath As String)
            Try
                For Each type In [module].Types
                    For i = 0 To 99 ' Create 100 junk methods for each type
                        Dim junkMethod = New MethodDefUser(RandomString(10), MethodSig.CreateStatic([module].CorLibTypes.Void), MethodAttributes.Public Or MethodAttributes.Static) With {
    .Body = New CilBody()
}
                        junkMethod.Body.Instructions.Add(OpCodes.Ret.ToInstruction())

                        type.Methods.Add(junkMethod)
                    Next
                Next

                For i = 0 To 49 ' Create 50 junk classes
                    Dim junkType = New TypeDefUser(RandomString(10), [module].CorLibTypes.Object.TypeDefOrRef)
                    [module].Types.Add(junkType)

                    For j = 0 To 9 ' For each junk class, create 10 junk methods
                        Dim junkMethod = New MethodDefUser(RandomString(10), MethodSig.CreateStatic([module].CorLibTypes.Void), MethodAttributes.Public Or MethodAttributes.Static) With {
    .Body = New CilBody()
}
                        junkMethod.Body.Instructions.Add(OpCodes.Ret.ToInstruction())

                        junkType.Methods.Add(junkMethod)
                    Next
                Next
                [module].Write(OutPath)
            Catch ex As Exception
                Console.WriteLine($"An error occurred during junk method insertion: {ex.Message}")
            End Try
        End Sub
    End Class
End Namespace

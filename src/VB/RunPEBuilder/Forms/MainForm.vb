Imports System
Imports System.Drawing.Drawing2D
Imports System.Drawing
Imports System.Windows.Forms

Namespace RunPEBuilder
    Public Partial Class MainForm
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub CloseBtn_Click(sender As Object, e As EventArgs)
            Call Application.Exit()
        End Sub

        Private Sub MinimazeBtn_Click(sender As Object, e As EventArgs)
            WindowState = FormWindowState.Minimized
        End Sub
        Private Sub MainForm_MouseDown(sender As Object, e As MouseEventArgs)
            Capture = False
            Dim msg = Message.Create(Handle, &Ha1, New IntPtr(2), IntPtr.Zero)
            WndProc(msg)
        End Sub

        Private Sub SelectFileBtn_Click(sender As Object, e As EventArgs)
            Using openFileDialog As OpenFileDialog = New OpenFileDialog()
                openFileDialog.Title = "Select exe-file."
                openFileDialog.Filter = "EXE (*.exe)|*.exe"

                If openFileDialog.ShowDialog() = DialogResult.OK Then
                    File_Box.Text = openFileDialog.FileName
                    Return
                End If
            End Using
        End Sub

        Private Sub BuidBtn_Click(sender As Object, e As EventArgs)
            Dim FileName = File_Box.Text, InjectProcess = SelectedProcess.Text

            Dim obfuscate = ObfuscateChk.Checked

            If String.IsNullOrEmpty(FileName) OrElse String.IsNullOrEmpty(InjectProcess) Then
                MessageBox.Show("Forms cannot be empty!", "~Build Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            Using saveFileDialog As SaveFileDialog = New SaveFileDialog()
                saveFileDialog.Title = "Save File"
                saveFileDialog.Filter = "EXE (*.exe)|*.exe"

                If saveFileDialog.ShowDialog() = DialogResult.OK Then
                    Dim result = Include.Runtime.RuntimeMain(FileName, saveFileDialog.FileName, InjectProcess, obfuscate)

                    MessageBox.Show(result, "~Build Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            End Using

        End Sub
        Private Sub MainForm_Load(sender As Object, e As EventArgs)
            Dim CornerRadius = 40
            Dim path = CreateRoundedRectanglePath(Width, Height, CornerRadius)
            Region = New Region(path)
        End Sub

        Private Function CreateRoundedRectanglePath(width As Integer, height As Integer, radius As Integer) As GraphicsPath
            Dim path As GraphicsPath = New GraphicsPath()

            ' Add rounded corners to the path
            path.AddArc(0, 0, radius, radius, 180, 90)
            path.AddArc(width - radius, 0, radius, radius, 270, 90)
            path.AddArc(width - radius, height - radius, radius, radius, 0, 90)
            path.AddArc(0, height - radius, radius, radius, 90, 90)

            path.CloseFigure()

            Return path
        End Function
    End Class
End Namespace

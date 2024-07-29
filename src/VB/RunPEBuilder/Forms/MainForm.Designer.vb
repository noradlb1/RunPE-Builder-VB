Imports System

Namespace RunPEBuilder
    Partial Class MainForm
        ''' <summary>
        ''' Обязательная переменная конструктора.
        ''' </summary>
        Private components As ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Освободить все используемые ресурсы.
        ''' </summary>
        ''' <paramname="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        Protected Overrides Sub Dispose(disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Код, автоматически созданный конструктором форм Windows"

        ''' <summary>
        ''' Требуемый метод для поддержки конструктора — не изменяйте 
        ''' содержимое этого метода с помощью редактора кода.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            Me.label5 = New System.Windows.Forms.Label()
            Me.label2 = New System.Windows.Forms.Label()
            Me.label3 = New System.Windows.Forms.Label()
            Me.ObfuscateChk = New System.Windows.Forms.CheckBox()
            Me.BuidBtn = New System.Windows.Forms.Button()
            Me.label1 = New System.Windows.Forms.Label()
            Me.label4 = New System.Windows.Forms.Label()
            Me.SelectFileBtn = New System.Windows.Forms.Button()
            Me.SelectedProcess = New System.Windows.Forms.ComboBox()
            Me.File_Box = New System.Windows.Forms.TextBox()
            Me.CloseBtn = New System.Windows.Forms.Button()
            Me.MinimazeBtn = New System.Windows.Forms.Button()
            Me.pictureBox1 = New System.Windows.Forms.PictureBox()
            Me.groupBox1.SuspendLayout()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'groupBox1
            '
            Me.groupBox1.BackColor = System.Drawing.Color.Transparent
            Me.groupBox1.Controls.Add(Me.label5)
            Me.groupBox1.Controls.Add(Me.label2)
            Me.groupBox1.Controls.Add(Me.label3)
            Me.groupBox1.Controls.Add(Me.ObfuscateChk)
            Me.groupBox1.Controls.Add(Me.BuidBtn)
            Me.groupBox1.Controls.Add(Me.label1)
            Me.groupBox1.Controls.Add(Me.label4)
            Me.groupBox1.Controls.Add(Me.SelectFileBtn)
            Me.groupBox1.Controls.Add(Me.SelectedProcess)
            Me.groupBox1.Controls.Add(Me.File_Box)
            Me.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.groupBox1.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
            Me.groupBox1.ForeColor = System.Drawing.Color.White
            Me.groupBox1.Location = New System.Drawing.Point(44, 48)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(336, 310)
            Me.groupBox1.TabIndex = 0
            Me.groupBox1.TabStop = False
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.BackColor = System.Drawing.Color.Transparent
            Me.label5.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
            Me.label5.ForeColor = System.Drawing.Color.White
            Me.label5.Location = New System.Drawing.Point(8, 67)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(140, 15)
            Me.label5.TabIndex = 12
            Me.label5.Text = "Telegram: @K666Plus"
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.BackColor = System.Drawing.Color.Transparent
            Me.label2.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
            Me.label2.ForeColor = System.Drawing.Color.White
            Me.label2.Location = New System.Drawing.Point(6, 49)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(266, 15)
            Me.label2.TabIndex = 11
            Me.label2.Text = "Github: https://github.com/k3rnel-dev"
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
            Me.label3.ForeColor = System.Drawing.Color.White
            Me.label3.Location = New System.Drawing.Point(6, 148)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(91, 13)
            Me.label3.TabIndex = 10
            Me.label3.Text = "Inject Process"
            '
            'ObfuscateChk
            '
            Me.ObfuscateChk.AutoSize = True
            Me.ObfuscateChk.Location = New System.Drawing.Point(9, 189)
            Me.ObfuscateChk.Name = "ObfuscateChk"
            Me.ObfuscateChk.Size = New System.Drawing.Size(99, 22)
            Me.ObfuscateChk.TabIndex = 9
            Me.ObfuscateChk.Text = "Obfuscate"
            Me.ObfuscateChk.UseVisualStyleBackColor = True
            '
            'BuidBtn
            '
            Me.BuidBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(80, Byte), Integer))
            Me.BuidBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BuidBtn.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
            Me.BuidBtn.ForeColor = System.Drawing.Color.White
            Me.BuidBtn.Location = New System.Drawing.Point(11, 228)
            Me.BuidBtn.Name = "BuidBtn"
            Me.BuidBtn.Size = New System.Drawing.Size(313, 57)
            Me.BuidBtn.TabIndex = 8
            Me.BuidBtn.Text = "Build"
            Me.BuidBtn.UseVisualStyleBackColor = False
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.BackColor = System.Drawing.Color.Transparent
            Me.label1.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
            Me.label1.ForeColor = System.Drawing.Color.White
            Me.label1.Location = New System.Drawing.Point(111, 14)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(112, 30)
            Me.label1.TabIndex = 2
            Me.label1.Text = "RunPE - Builder" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "By K3rnel-Dev" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
            Me.label4.ForeColor = System.Drawing.Color.White
            Me.label4.Location = New System.Drawing.Point(6, 93)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(91, 13)
            Me.label4.TabIndex = 7
            Me.label4.Text = "File to Inject"
            '
            'SelectFileBtn
            '
            Me.SelectFileBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(80, Byte), Integer))
            Me.SelectFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.SelectFileBtn.Font = New System.Drawing.Font("Consolas", 7.25!)
            Me.SelectFileBtn.ForeColor = System.Drawing.Color.White
            Me.SelectFileBtn.Location = New System.Drawing.Point(295, 109)
            Me.SelectFileBtn.Name = "SelectFileBtn"
            Me.SelectFileBtn.Size = New System.Drawing.Size(31, 27)
            Me.SelectFileBtn.TabIndex = 6
            Me.SelectFileBtn.Text = "..."
            Me.SelectFileBtn.UseVisualStyleBackColor = False
            '
            'SelectedProcess
            '
            Me.SelectedProcess.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(80, Byte), Integer))
            Me.SelectedProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.SelectedProcess.Font = New System.Drawing.Font("Consolas", 7.25!)
            Me.SelectedProcess.ForeColor = System.Drawing.Color.Cyan
            Me.SelectedProcess.FormattingEnabled = True
            Me.SelectedProcess.Items.AddRange(New Object() {"C:\\Windows\\Microsoft.NET\\Framework\\v4.0.30319\\RegSvcs.exe", "C:\\Windows\\Microsoft.NET\\Framework\\v4.0.30319\\AspnetCompiler.exe", "C:\\Windows\\Microsoft.NET\\Framework\\v4.0.30319\\csc.exe", "C:\\Windows\\Microsoft.NET\\Framework\\v4.0.30319\\RegAsm.exe"})
            Me.SelectedProcess.Location = New System.Drawing.Point(6, 164)
            Me.SelectedProcess.Name = "SelectedProcess"
            Me.SelectedProcess.Size = New System.Drawing.Size(319, 20)
            Me.SelectedProcess.TabIndex = 1
            '
            'File_Box
            '
            Me.File_Box.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(80, Byte), Integer))
            Me.File_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.File_Box.ForeColor = System.Drawing.Color.Cyan
            Me.File_Box.Location = New System.Drawing.Point(6, 111)
            Me.File_Box.Name = "File_Box"
            Me.File_Box.Size = New System.Drawing.Size(282, 25)
            Me.File_Box.TabIndex = 0
            Me.File_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'CloseBtn
            '
            Me.CloseBtn.BackColor = System.Drawing.Color.Transparent
            Me.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.CloseBtn.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
            Me.CloseBtn.ForeColor = System.Drawing.Color.White
            Me.CloseBtn.Location = New System.Drawing.Point(367, 2)
            Me.CloseBtn.Name = "CloseBtn"
            Me.CloseBtn.Size = New System.Drawing.Size(32, 27)
            Me.CloseBtn.TabIndex = 3
            Me.CloseBtn.Text = "X"
            Me.CloseBtn.UseVisualStyleBackColor = False
            '
            'MinimazeBtn
            '
            Me.MinimazeBtn.BackColor = System.Drawing.Color.Transparent
            Me.MinimazeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.MinimazeBtn.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
            Me.MinimazeBtn.ForeColor = System.Drawing.Color.White
            Me.MinimazeBtn.Location = New System.Drawing.Point(329, 2)
            Me.MinimazeBtn.Name = "MinimazeBtn"
            Me.MinimazeBtn.Size = New System.Drawing.Size(32, 27)
            Me.MinimazeBtn.TabIndex = 4
            Me.MinimazeBtn.Text = "-"
            Me.MinimazeBtn.UseVisualStyleBackColor = False
            '
            'pictureBox1
            '
            Me.pictureBox1.BackColor = System.Drawing.Color.Transparent
            Me.pictureBox1.Location = New System.Drawing.Point(-81, -47)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(326, 420)
            Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.pictureBox1.TabIndex = 1
            Me.pictureBox1.TabStop = False
            '
            'MainForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(80, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(427, 370)
            Me.Controls.Add(Me.MinimazeBtn)
            Me.Controls.Add(Me.CloseBtn)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.pictureBox1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "MainForm"
            Me.Opacity = 0.95R
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "RunPEBuilder - [ by k3rnel-dev ] "
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private groupBox1 As Windows.Forms.GroupBox
        Private label1 As Windows.Forms.Label
        Private CloseBtn As Windows.Forms.Button
        Private MinimazeBtn As Windows.Forms.Button
        Private SelectFileBtn As Windows.Forms.Button
        Private SelectedProcess As Windows.Forms.ComboBox
        Private File_Box As Windows.Forms.TextBox
        Private ObfuscateChk As Windows.Forms.CheckBox
        Private BuidBtn As Windows.Forms.Button
        Private label4 As Windows.Forms.Label
        Private label3 As Windows.Forms.Label
        Private pictureBox1 As Windows.Forms.PictureBox
        Private label5 As Windows.Forms.Label
        Private label2 As Windows.Forms.Label
    End Class
End Namespace

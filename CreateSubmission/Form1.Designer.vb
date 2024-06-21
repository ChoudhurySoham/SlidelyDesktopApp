<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        lblName1 = New Label()
        lblEmail1 = New Label()
        lblPhoneNum1 = New Label()
        lblGitHub1 = New Label()
        lblMain1 = New Label()
        tbName1 = New TextBox()
        tbEmail1 = New TextBox()
        tbPhoneNum1 = New TextBox()
        tbGitHub1 = New TextBox()
        btnStopWatch = New Button()
        btnSubmit = New Button()
        Timer1 = New Timer(components)
        timerBox = New TextBox()
        SuspendLayout()
        ' 
        ' lblName1
        ' 
        lblName1.AutoSize = True
        lblName1.Location = New Point(168, 92)
        lblName1.Name = "lblName1"
        lblName1.Size = New Size(49, 20)
        lblName1.TabIndex = 0
        lblName1.Text = "Name"
        ' 
        ' lblEmail1
        ' 
        lblEmail1.AutoSize = True
        lblEmail1.Location = New Point(168, 136)
        lblEmail1.Name = "lblEmail1"
        lblEmail1.Size = New Size(46, 20)
        lblEmail1.TabIndex = 1
        lblEmail1.Text = "Email"
        ' 
        ' lblPhoneNum1
        ' 
        lblPhoneNum1.AutoSize = True
        lblPhoneNum1.Location = New Point(168, 186)
        lblPhoneNum1.Name = "lblPhoneNum1"
        lblPhoneNum1.Size = New Size(86, 20)
        lblPhoneNum1.TabIndex = 2
        lblPhoneNum1.Text = "Phone Num"
        ' 
        ' lblGitHub1
        ' 
        lblGitHub1.AutoSize = True
        lblGitHub1.Location = New Point(168, 233)
        lblGitHub1.Name = "lblGitHub1"
        lblGitHub1.Size = New Size(152, 20)
        lblGitHub1.TabIndex = 3
        lblGitHub1.Text = "GitHub Link for Task 2"
        ' 
        ' lblMain1
        ' 
        lblMain1.AutoSize = True
        lblMain1.Location = New Point(168, 25)
        lblMain1.Name = "lblMain1"
        lblMain1.Size = New Size(370, 20)
        lblMain1.TabIndex = 4
        lblMain1.Text = "Soham Choudhury, Slidely Task - 2 - Create Submission"
        ' 
        ' tbName1
        ' 
        tbName1.Location = New Point(405, 89)
        tbName1.Name = "tbName1"
        tbName1.Size = New Size(133, 27)
        tbName1.TabIndex = 5
        ' 
        ' tbEmail1
        ' 
        tbEmail1.Location = New Point(405, 136)
        tbEmail1.Name = "tbEmail1"
        tbEmail1.Size = New Size(133, 27)
        tbEmail1.TabIndex = 6
        ' 
        ' tbPhoneNum1
        ' 
        tbPhoneNum1.Location = New Point(405, 183)
        tbPhoneNum1.Name = "tbPhoneNum1"
        tbPhoneNum1.Size = New Size(133, 27)
        tbPhoneNum1.TabIndex = 7
        ' 
        ' tbGitHub1
        ' 
        tbGitHub1.Location = New Point(405, 230)
        tbGitHub1.Name = "tbGitHub1"
        tbGitHub1.Size = New Size(133, 27)
        tbGitHub1.TabIndex = 8
        ' 
        ' btnStopWatch
        ' 
        btnStopWatch.BackColor = Color.FromArgb(CByte(255), CByte(236), CByte(153))
        btnStopWatch.Location = New Point(168, 292)
        btnStopWatch.Name = "btnStopWatch"
        btnStopWatch.Size = New Size(254, 29)
        btnStopWatch.TabIndex = 9
        btnStopWatch.Text = "TOGGLE STOPWATCH (CTRL + T)"
        btnStopWatch.UseVisualStyleBackColor = False
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.FromArgb(CByte(165), CByte(216), CByte(255))
        btnSubmit.Location = New Point(168, 369)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(362, 29)
        btnSubmit.TabIndex = 10
        btnSubmit.Text = "SUBMIT (CTRL +S)"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' timerBox
        ' 
        timerBox.Location = New Point(442, 294)
        timerBox.Name = "timerBox"
        timerBox.Size = New Size(96, 27)
        timerBox.TabIndex = 11
        timerBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(734, 445)
        Controls.Add(timerBox)
        Controls.Add(btnSubmit)
        Controls.Add(btnStopWatch)
        Controls.Add(tbGitHub1)
        Controls.Add(tbPhoneNum1)
        Controls.Add(tbEmail1)
        Controls.Add(tbName1)
        Controls.Add(lblMain1)
        Controls.Add(lblGitHub1)
        Controls.Add(lblPhoneNum1)
        Controls.Add(lblEmail1)
        Controls.Add(lblName1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblName1 As Label
    Friend WithEvents lblEmail1 As Label
    Friend WithEvents lblPhoneNum1 As Label
    Friend WithEvents lblGitHub1 As Label
    Friend WithEvents lblMain1 As Label
    Friend WithEvents tbName1 As TextBox
    Friend WithEvents tbEmail1 As TextBox
    Friend WithEvents tbPhoneNum1 As TextBox
    Friend WithEvents tbGitHub1 As TextBox
    Friend WithEvents btnStopWatch As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents timerBox As TextBox

End Class

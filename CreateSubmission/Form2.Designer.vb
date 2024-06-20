<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblMain2 = New Label()
        btnNext2 = New Button()
        btnPrevious2 = New Button()
        lblStopWatch2 = New Label()
        lblGitHub2 = New Label()
        lblPhoneNum2 = New Label()
        lblEmail2 = New Label()
        lblName2 = New Label()
        tbStopWatch2 = New TextBox()
        tbGitHub2 = New TextBox()
        tbPhoneNum2 = New TextBox()
        tbEmail2 = New TextBox()
        tbName2 = New TextBox()
        SuspendLayout()
        ' 
        ' lblMain2
        ' 
        lblMain2.AutoSize = True
        lblMain2.Location = New Point(171, 20)
        lblMain2.Name = "lblMain2"
        lblMain2.Size = New Size(355, 20)
        lblMain2.TabIndex = 25
        lblMain2.Text = "Soham Choudhury, Slidely Task 2 - View Submissions"
        ' 
        ' btnNext2
        ' 
        btnNext2.BackColor = Color.FromArgb(CByte(165), CByte(216), CByte(255))
        btnNext2.Location = New Point(376, 366)
        btnNext2.Name = "btnNext2"
        btnNext2.Size = New Size(242, 29)
        btnNext2.TabIndex = 24
        btnNext2.Text = "NEXT (CTRL + N)"
        btnNext2.UseVisualStyleBackColor = False
        ' 
        ' btnPrevious2
        ' 
        btnPrevious2.BackColor = Color.FromArgb(CByte(255), CByte(236), CByte(153))
        btnPrevious2.Location = New Point(62, 366)
        btnPrevious2.Name = "btnPrevious2"
        btnPrevious2.Size = New Size(242, 29)
        btnPrevious2.TabIndex = 23
        btnPrevious2.Text = "PREVIOUS (CTRL + P)"
        btnPrevious2.UseVisualStyleBackColor = False
        ' 
        ' lblStopWatch2
        ' 
        lblStopWatch2.AutoSize = True
        lblStopWatch2.Location = New Point(101, 294)
        lblStopWatch2.Name = "lblStopWatch2"
        lblStopWatch2.Size = New Size(116, 20)
        lblStopWatch2.TabIndex = 22
        lblStopWatch2.Text = "Stopwatch Time"
        ' 
        ' lblGitHub2
        ' 
        lblGitHub2.AutoSize = True
        lblGitHub2.Location = New Point(101, 236)
        lblGitHub2.Name = "lblGitHub2"
        lblGitHub2.Size = New Size(149, 20)
        lblGitHub2.TabIndex = 21
        lblGitHub2.Text = "GitHub link for Task 2"
        ' 
        ' lblPhoneNum2
        ' 
        lblPhoneNum2.AutoSize = True
        lblPhoneNum2.Location = New Point(101, 183)
        lblPhoneNum2.Name = "lblPhoneNum2"
        lblPhoneNum2.Size = New Size(86, 20)
        lblPhoneNum2.TabIndex = 20
        lblPhoneNum2.Text = "Phone Num"
        ' 
        ' lblEmail2
        ' 
        lblEmail2.AutoSize = True
        lblEmail2.Location = New Point(101, 129)
        lblEmail2.Name = "lblEmail2"
        lblEmail2.Size = New Size(46, 20)
        lblEmail2.TabIndex = 19
        lblEmail2.Text = "Email"
        ' 
        ' lblName2
        ' 
        lblName2.AutoSize = True
        lblName2.Location = New Point(101, 78)
        lblName2.Name = "lblName2"
        lblName2.Size = New Size(49, 20)
        lblName2.TabIndex = 18
        lblName2.Text = "Name"
        ' 
        ' tbStopWatch2
        ' 
        tbStopWatch2.Location = New Point(314, 294)
        tbStopWatch2.Name = "tbStopWatch2"
        tbStopWatch2.Size = New Size(304, 27)
        tbStopWatch2.TabIndex = 17
        ' 
        ' tbGitHub2
        ' 
        tbGitHub2.Location = New Point(314, 236)
        tbGitHub2.Name = "tbGitHub2"
        tbGitHub2.Size = New Size(304, 27)
        tbGitHub2.TabIndex = 16
        ' 
        ' tbPhoneNum2
        ' 
        tbPhoneNum2.Location = New Point(314, 183)
        tbPhoneNum2.Name = "tbPhoneNum2"
        tbPhoneNum2.Size = New Size(304, 27)
        tbPhoneNum2.TabIndex = 15
        ' 
        ' tbEmail2
        ' 
        tbEmail2.Location = New Point(314, 129)
        tbEmail2.Name = "tbEmail2"
        tbEmail2.Size = New Size(304, 27)
        tbEmail2.TabIndex = 14
        ' 
        ' tbName2
        ' 
        tbName2.Location = New Point(314, 78)
        tbName2.Name = "tbName2"
        tbName2.Size = New Size(304, 27)
        tbName2.TabIndex = 13
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(706, 448)
        Controls.Add(lblMain2)
        Controls.Add(btnNext2)
        Controls.Add(btnPrevious2)
        Controls.Add(lblStopWatch2)
        Controls.Add(lblGitHub2)
        Controls.Add(lblPhoneNum2)
        Controls.Add(lblEmail2)
        Controls.Add(lblName2)
        Controls.Add(tbStopWatch2)
        Controls.Add(tbGitHub2)
        Controls.Add(tbPhoneNum2)
        Controls.Add(tbEmail2)
        Controls.Add(tbName2)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblMain2 As Label
    Friend WithEvents btnNext2 As Button
    Friend WithEvents btnPrevious2 As Button
    Friend WithEvents lblStopWatch2 As Label
    Friend WithEvents lblGitHub2 As Label
    Friend WithEvents lblPhoneNum2 As Label
    Friend WithEvents lblEmail2 As Label
    Friend WithEvents lblName2 As Label
    Friend WithEvents tbStopWatch2 As TextBox
    Friend WithEvents tbGitHub2 As TextBox
    Friend WithEvents tbPhoneNum2 As TextBox
    Friend WithEvents tbEmail2 As TextBox
    Friend WithEvents tbName2 As TextBox
End Class

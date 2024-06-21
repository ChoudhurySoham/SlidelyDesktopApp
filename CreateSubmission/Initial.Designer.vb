<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Initial
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
        lblMain = New Label()
        btnView = New Button()
        btnNew = New Button()
        SuspendLayout()
        ' 
        ' lblMain
        ' 
        lblMain.AutoSize = True
        lblMain.Font = New Font("Segoe UI", 12F)
        lblMain.Location = New Point(66, 41)
        lblMain.Name = "lblMain"
        lblMain.Size = New Size(468, 28)
        lblMain.TabIndex = 0
        lblMain.Text = "Soham Choudhury, Slidely Task 2 - Slidely Form App"
        ' 
        ' btnView
        ' 
        btnView.BackColor = Color.FromArgb(CByte(255), CByte(236), CByte(153))
        btnView.Location = New Point(115, 105)
        btnView.Name = "btnView"
        btnView.Size = New Size(352, 53)
        btnView.TabIndex = 1
        btnView.Text = "VIEW SUBMISSIONS (CTRL+V)"
        btnView.UseVisualStyleBackColor = False
        ' 
        ' btnNew
        ' 
        btnNew.BackColor = Color.FromArgb(CByte(165), CByte(216), CByte(255))
        btnNew.Location = New Point(115, 177)
        btnNew.Name = "btnNew"
        btnNew.Size = New Size(352, 53)
        btnNew.TabIndex = 2
        btnNew.Text = "CREATE NEW SUBMISSION (CTRL + N)"
        btnNew.UseVisualStyleBackColor = False
        ' 
        ' Initial
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(608, 279)
        Controls.Add(btnNew)
        Controls.Add(btnView)
        Controls.Add(lblMain)
        Name = "Initial"
        Text = "FormA"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblMain As Label
    Friend WithEvents btnView As Button
    Friend WithEvents btnNew As Button
End Class

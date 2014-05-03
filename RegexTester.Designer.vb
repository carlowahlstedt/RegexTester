<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegexTester
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
        Me.BtnRegex = New System.Windows.Forms.Button()
        Me.txtRegex = New System.Windows.Forms.TextBox()
        Me.txtGroups = New System.Windows.Forms.TextBox()
        Me.txtExpression = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnRegex
        '
        Me.BtnRegex.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRegex.Location = New System.Drawing.Point(365, 268)
        Me.BtnRegex.Name = "BtnRegex"
        Me.BtnRegex.Size = New System.Drawing.Size(75, 23)
        Me.BtnRegex.TabIndex = 9
        Me.BtnRegex.Text = "Regex"
        Me.BtnRegex.UseVisualStyleBackColor = True
        '
        'txtRegex
        '
        Me.txtRegex.AllowDrop = True
        Me.txtRegex.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRegex.Location = New System.Drawing.Point(55, 65)
        Me.txtRegex.Name = "txtRegex"
        Me.txtRegex.Size = New System.Drawing.Size(385, 20)
        Me.txtRegex.TabIndex = 3
        '
        'txtGroups
        '
        Me.txtGroups.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGroups.Location = New System.Drawing.Point(13, 155)
        Me.txtGroups.Multiline = True
        Me.txtGroups.Name = "txtGroups"
        Me.txtGroups.ReadOnly = True
        Me.txtGroups.Size = New System.Drawing.Size(427, 107)
        Me.txtGroups.TabIndex = 7
        '
        'txtExpression
        '
        Me.txtExpression.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtExpression.Location = New System.Drawing.Point(55, 23)
        Me.txtExpression.Name = "txtExpression"
        Me.txtExpression.Size = New System.Drawing.Size(385, 20)
        Me.txtExpression.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Regex"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "File"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Output"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Log"
        '
        'txtLog
        '
        Me.txtLog.AllowDrop = True
        Me.txtLog.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLog.Location = New System.Drawing.Point(55, 105)
        Me.txtLog.Name = "txtLog"
        Me.txtLog.Size = New System.Drawing.Size(385, 20)
        Me.txtLog.TabIndex = 5
        '
        'RegexTester
        '
        Me.AcceptButton = Me.BtnRegex
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 303)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtLog)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtExpression)
        Me.Controls.Add(Me.txtGroups)
        Me.Controls.Add(Me.txtRegex)
        Me.Controls.Add(Me.BtnRegex)
        Me.Name = "RegexTester"
        Me.ShowIcon = False
        Me.Text = "Regex Tester"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnRegex As System.Windows.Forms.Button
    Friend WithEvents txtRegex As System.Windows.Forms.TextBox
    Friend WithEvents txtGroups As System.Windows.Forms.TextBox
    Friend WithEvents txtExpression As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtLog As System.Windows.Forms.TextBox

End Class

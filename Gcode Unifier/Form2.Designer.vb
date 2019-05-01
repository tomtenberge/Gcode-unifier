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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.X_Offset = New System.Windows.Forms.TextBox()
        Me.Y_offset = New System.Windows.Forms.TextBox()
        Me.Z_offset = New System.Windows.Forms.TextBox()
        Me.ok_Btn = New System.Windows.Forms.Button()
        Me.Cancel_Btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "X offset"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Y offset"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Z offset"
        '
        'X_Offset
        '
        Me.X_Offset.Location = New System.Drawing.Point(61, 23)
        Me.X_Offset.Name = "X_Offset"
        Me.X_Offset.Size = New System.Drawing.Size(100, 20)
        Me.X_Offset.TabIndex = 3
        '
        'Y_offset
        '
        Me.Y_offset.Location = New System.Drawing.Point(61, 50)
        Me.Y_offset.Name = "Y_offset"
        Me.Y_offset.Size = New System.Drawing.Size(100, 20)
        Me.Y_offset.TabIndex = 4
        '
        'Z_offset
        '
        Me.Z_offset.Location = New System.Drawing.Point(61, 76)
        Me.Z_offset.Name = "Z_offset"
        Me.Z_offset.Size = New System.Drawing.Size(100, 20)
        Me.Z_offset.TabIndex = 5
        '
        'ok_Btn
        '
        Me.ok_Btn.Location = New System.Drawing.Point(12, 102)
        Me.ok_Btn.Name = "ok_Btn"
        Me.ok_Btn.Size = New System.Drawing.Size(75, 23)
        Me.ok_Btn.TabIndex = 6
        Me.ok_Btn.Text = "Ok"
        Me.ok_Btn.UseVisualStyleBackColor = True
        '
        'Cancel_Btn
        '
        Me.Cancel_Btn.Location = New System.Drawing.Point(94, 103)
        Me.Cancel_Btn.Name = "Cancel_Btn"
        Me.Cancel_Btn.Size = New System.Drawing.Size(75, 23)
        Me.Cancel_Btn.TabIndex = 7
        Me.Cancel_Btn.Text = "Cancel"
        Me.Cancel_Btn.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(189, 138)
        Me.Controls.Add(Me.Cancel_Btn)
        Me.Controls.Add(Me.ok_Btn)
        Me.Controls.Add(Me.Z_offset)
        Me.Controls.Add(Me.Y_offset)
        Me.Controls.Add(Me.X_Offset)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents X_Offset As TextBox
    Friend WithEvents Y_offset As TextBox
    Friend WithEvents Z_offset As TextBox
    Friend WithEvents ok_Btn As Button
    Friend WithEvents Cancel_Btn As Button
End Class

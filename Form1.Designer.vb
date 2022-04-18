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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.Result = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(28, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Height (cm)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(28, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Weight (kg)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(28, 197)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "BMI ="
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(215, 67)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(125, 27)
        Me.txt1.TabIndex = 3
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(215, 135)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(125, 27)
        Me.txt2.TabIndex = 4
        '
        'Result
        '
        Me.Result.BackColor = System.Drawing.Color.Yellow
        Me.Result.Location = New System.Drawing.Point(215, 199)
        Me.Result.Name = "Result"
        Me.Result.Size = New System.Drawing.Size(125, 27)
        Me.Result.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(146, 260)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(194, 36)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "CALCULATE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Result)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Height (cm)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt1 As TextBox
    Friend WithEvents txt2 As TextBox
    Friend WithEvents Result As TextBox
    Friend WithEvents Button1 As Button
End Class

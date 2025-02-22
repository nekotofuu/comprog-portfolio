<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rb16 = New System.Windows.Forms.RadioButton()
        Me.rb32 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbQuantity = New System.Windows.Forms.TextBox()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbCost = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rb32)
        Me.GroupBox1.Controls.Add(Me.rb16)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(121, 66)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "USB Flash Drives"
        '
        'rb16
        '
        Me.rb16.AutoSize = True
        Me.rb16.CausesValidation = False
        Me.rb16.Checked = True
        Me.rb16.Location = New System.Drawing.Point(15, 20)
        Me.rb16.Name = "rb16"
        Me.rb16.Size = New System.Drawing.Size(55, 17)
        Me.rb16.TabIndex = 0
        Me.rb16.TabStop = True
        Me.rb16.Text = "16 GB"
        Me.rb16.UseVisualStyleBackColor = True
        '
        'rb32
        '
        Me.rb32.AutoSize = True
        Me.rb32.Location = New System.Drawing.Point(15, 43)
        Me.rb32.Name = "rb32"
        Me.rb32.Size = New System.Drawing.Size(55, 17)
        Me.rb32.TabIndex = 1
        Me.rb32.Text = "32 GB"
        Me.rb32.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(189, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Quantity:"
        '
        'tbQuantity
        '
        Me.tbQuantity.Location = New System.Drawing.Point(179, 39)
        Me.tbQuantity.Name = "tbQuantity"
        Me.tbQuantity.Size = New System.Drawing.Size(69, 20)
        Me.tbQuantity.TabIndex = 2
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(90, 84)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(106, 34)
        Me.btnCompute.TabIndex = 3
        Me.btnCompute.Text = "Calculate Cost"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(76, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Cost:"
        '
        'tbCost
        '
        Me.tbCost.Location = New System.Drawing.Point(112, 130)
        Me.tbCost.Name = "tbCost"
        Me.tbCost.Size = New System.Drawing.Size(100, 20)
        Me.tbCost.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 167)
        Me.Controls.Add(Me.tbCost)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.tbQuantity)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rb32 As System.Windows.Forms.RadioButton
    Friend WithEvents rb16 As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbQuantity As System.Windows.Forms.TextBox
    Friend WithEvents btnCompute As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbCost As System.Windows.Forms.TextBox

End Class

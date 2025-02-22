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
        Me.rbSenior = New System.Windows.Forms.RadioButton()
        Me.rbAdult = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cb3 = New System.Windows.Forms.CheckBox()
        Me.cb2 = New System.Windows.Forms.CheckBox()
        Me.cb1 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbFee = New System.Windows.Forms.TextBox()
        Me.btnFee = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbSenior)
        Me.GroupBox1.Controls.Add(Me.rbAdult)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(126, 87)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Membership"
        '
        'rbSenior
        '
        Me.rbSenior.AutoSize = True
        Me.rbSenior.Location = New System.Drawing.Point(20, 53)
        Me.rbSenior.Name = "rbSenior"
        Me.rbSenior.Size = New System.Drawing.Size(82, 17)
        Me.rbSenior.TabIndex = 1
        Me.rbSenior.Text = "Senior (65+)"
        Me.rbSenior.UseVisualStyleBackColor = True
        '
        'rbAdult
        '
        Me.rbAdult.AutoSize = True
        Me.rbAdult.Checked = True
        Me.rbAdult.Location = New System.Drawing.Point(20, 30)
        Me.rbAdult.Name = "rbAdult"
        Me.rbAdult.Size = New System.Drawing.Size(88, 17)
        Me.rbAdult.TabIndex = 0
        Me.rbAdult.TabStop = True
        Me.rbAdult.Text = "Adult (18 -65)"
        Me.rbAdult.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cb3)
        Me.GroupBox2.Controls.Add(Me.cb2)
        Me.GroupBox2.Controls.Add(Me.cb1)
        Me.GroupBox2.Location = New System.Drawing.Point(167, 21)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(129, 118)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Extras"
        '
        'cb3
        '
        Me.cb3.AutoSize = True
        Me.cb3.Location = New System.Drawing.Point(12, 77)
        Me.cb3.Name = "cb3"
        Me.cb3.Size = New System.Drawing.Size(101, 17)
        Me.cb3.TabIndex = 2
        Me.cb3.Text = "Laundry service"
        Me.cb3.UseVisualStyleBackColor = True
        '
        'cb2
        '
        Me.cb2.AutoSize = True
        Me.cb2.Location = New System.Drawing.Point(12, 53)
        Me.cb2.Name = "cb2"
        Me.cb2.Size = New System.Drawing.Size(91, 17)
        Me.cb2.TabIndex = 1
        Me.cb2.Text = "Private locker"
        Me.cb2.UseVisualStyleBackColor = True
        '
        'cb1
        '
        Me.cb1.AutoSize = True
        Me.cb1.Location = New System.Drawing.Point(12, 28)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(105, 17)
        Me.cb1.TabIndex = 0
        Me.cb1.Text = "Tennis privileges"
        Me.cb1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(164, 162)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Monthly Fee:"
        '
        'tbFee
        '
        Me.tbFee.Location = New System.Drawing.Point(238, 159)
        Me.tbFee.Name = "tbFee"
        Me.tbFee.Size = New System.Drawing.Size(58, 20)
        Me.tbFee.TabIndex = 3
        '
        'btnFee
        '
        Me.btnFee.Location = New System.Drawing.Point(35, 130)
        Me.btnFee.Name = "btnFee"
        Me.btnFee.Size = New System.Drawing.Size(96, 55)
        Me.btnFee.TabIndex = 4
        Me.btnFee.Text = "Calculate Monthly Fee"
        Me.btnFee.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 211)
        Me.Controls.Add(Me.btnFee)
        Me.Controls.Add(Me.tbFee)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Sports Club"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbSenior As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cb3 As System.Windows.Forms.CheckBox
    Friend WithEvents cb2 As System.Windows.Forms.CheckBox
    Friend WithEvents cb1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbFee As System.Windows.Forms.TextBox
    Friend WithEvents btnFee As System.Windows.Forms.Button
    Private WithEvents rbAdult As System.Windows.Forms.RadioButton

End Class

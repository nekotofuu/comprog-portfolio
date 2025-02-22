<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.grpBurgers = New System.Windows.Forms.GroupBox()
        Me.radBurger4 = New System.Windows.Forms.RadioButton()
        Me.radBurger3 = New System.Windows.Forms.RadioButton()
        Me.radBurger2 = New System.Windows.Forms.RadioButton()
        Me.radBurger1 = New System.Windows.Forms.RadioButton()
        Me.grpFries = New System.Windows.Forms.GroupBox()
        Me.radFries3 = New System.Windows.Forms.RadioButton()
        Me.radFries2 = New System.Windows.Forms.RadioButton()
        Me.radFries1 = New System.Windows.Forms.RadioButton()
        Me.grpDrinks = New System.Windows.Forms.GroupBox()
        Me.radDrinks2 = New System.Windows.Forms.RadioButton()
        Me.radDrinks1 = New System.Windows.Forms.RadioButton()
        Me.chkBurgers = New System.Windows.Forms.CheckBox()
        Me.chkFries = New System.Windows.Forms.CheckBox()
        Me.chkDrinks = New System.Windows.Forms.CheckBox()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.grpBurgers.SuspendLayout()
        Me.grpFries.SuspendLayout()
        Me.grpDrinks.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpBurgers
        '
        Me.grpBurgers.Controls.Add(Me.radBurger4)
        Me.grpBurgers.Controls.Add(Me.radBurger3)
        Me.grpBurgers.Controls.Add(Me.radBurger2)
        Me.grpBurgers.Controls.Add(Me.radBurger1)
        Me.grpBurgers.Enabled = False
        Me.grpBurgers.Location = New System.Drawing.Point(91, 20)
        Me.grpBurgers.Name = "grpBurgers"
        Me.grpBurgers.Size = New System.Drawing.Size(214, 116)
        Me.grpBurgers.TabIndex = 0
        Me.grpBurgers.TabStop = False
        Me.grpBurgers.Text = "Choices for Burgers"
        '
        'radBurger4
        '
        Me.radBurger4.AutoSize = True
        Me.radBurger4.Location = New System.Drawing.Point(17, 91)
        Me.radBurger4.Name = "radBurger4"
        Me.radBurger4.Size = New System.Drawing.Size(160, 17)
        Me.radBurger4.TabIndex = 3
        Me.radBurger4.Text = "w/ bacon and cheese (5.39)"
        Me.radBurger4.UseVisualStyleBackColor = True
        '
        'radBurger3
        '
        Me.radBurger3.AutoSize = True
        Me.radBurger3.Location = New System.Drawing.Point(17, 68)
        Me.radBurger3.Name = "radBurger3"
        Me.radBurger3.Size = New System.Drawing.Size(101, 17)
        Me.radBurger3.TabIndex = 2
        Me.radBurger3.Text = "w/ bacon (4.79)"
        Me.radBurger3.UseVisualStyleBackColor = True
        '
        'radBurger2
        '
        Me.radBurger2.AutoSize = True
        Me.radBurger2.Location = New System.Drawing.Point(17, 45)
        Me.radBurger2.Name = "radBurger2"
        Me.radBurger2.Size = New System.Drawing.Size(106, 17)
        Me.radBurger2.TabIndex = 1
        Me.radBurger2.Text = "w/ cheese (4.79)"
        Me.radBurger2.UseVisualStyleBackColor = True
        '
        'radBurger1
        '
        Me.radBurger1.AutoSize = True
        Me.radBurger1.Checked = True
        Me.radBurger1.Location = New System.Drawing.Point(17, 22)
        Me.radBurger1.Name = "radBurger1"
        Me.radBurger1.Size = New System.Drawing.Size(92, 17)
        Me.radBurger1.TabIndex = 0
        Me.radBurger1.TabStop = True
        Me.radBurger1.Text = "Regular (4.19)"
        Me.radBurger1.UseVisualStyleBackColor = True
        '
        'grpFries
        '
        Me.grpFries.Controls.Add(Me.radFries3)
        Me.grpFries.Controls.Add(Me.radFries2)
        Me.grpFries.Controls.Add(Me.radFries1)
        Me.grpFries.Enabled = False
        Me.grpFries.Location = New System.Drawing.Point(91, 145)
        Me.grpFries.Name = "grpFries"
        Me.grpFries.Size = New System.Drawing.Size(213, 95)
        Me.grpFries.TabIndex = 1
        Me.grpFries.TabStop = False
        Me.grpFries.Text = "Choices for Fries"
        '
        'radFries3
        '
        Me.radFries3.AutoSize = True
        Me.radFries3.Location = New System.Drawing.Point(17, 69)
        Me.radFries3.Name = "radFries3"
        Me.radFries3.Size = New System.Drawing.Size(82, 17)
        Me.radFries3.TabIndex = 2
        Me.radFries3.Text = "Large (4.99)"
        Me.radFries3.UseVisualStyleBackColor = True
        '
        'radFries2
        '
        Me.radFries2.AutoSize = True
        Me.radFries2.Location = New System.Drawing.Point(16, 46)
        Me.radFries2.Name = "radFries2"
        Me.radFries2.Size = New System.Drawing.Size(92, 17)
        Me.radFries2.TabIndex = 1
        Me.radFries2.Text = "Medium (3.09)"
        Me.radFries2.UseVisualStyleBackColor = True
        '
        'radFries1
        '
        Me.radFries1.AutoSize = True
        Me.radFries1.Checked = True
        Me.radFries1.Location = New System.Drawing.Point(16, 23)
        Me.radFries1.Name = "radFries1"
        Me.radFries1.Size = New System.Drawing.Size(80, 17)
        Me.radFries1.TabIndex = 0
        Me.radFries1.TabStop = True
        Me.radFries1.Text = "Small (2.39)"
        Me.radFries1.UseVisualStyleBackColor = True
        '
        'grpDrinks
        '
        Me.grpDrinks.Controls.Add(Me.radDrinks2)
        Me.grpDrinks.Controls.Add(Me.radDrinks1)
        Me.grpDrinks.Enabled = False
        Me.grpDrinks.Location = New System.Drawing.Point(91, 250)
        Me.grpDrinks.Name = "grpDrinks"
        Me.grpDrinks.Size = New System.Drawing.Size(213, 70)
        Me.grpDrinks.TabIndex = 2
        Me.grpDrinks.TabStop = False
        Me.grpDrinks.Text = "Choices for Drinks"
        '
        'radDrinks2
        '
        Me.radDrinks2.AutoSize = True
        Me.radDrinks2.Location = New System.Drawing.Point(16, 42)
        Me.radDrinks2.Name = "radDrinks2"
        Me.radDrinks2.Size = New System.Drawing.Size(117, 17)
        Me.radDrinks2.TabIndex = 1
        Me.radDrinks2.Text = "Bottled water (1.49)"
        Me.radDrinks2.UseVisualStyleBackColor = True
        '
        'radDrinks1
        '
        Me.radDrinks1.AutoSize = True
        Me.radDrinks1.Checked = True
        Me.radDrinks1.Location = New System.Drawing.Point(16, 19)
        Me.radDrinks1.Name = "radDrinks1"
        Me.radDrinks1.Size = New System.Drawing.Size(80, 17)
        Me.radDrinks1.TabIndex = 0
        Me.radDrinks1.TabStop = True
        Me.radDrinks1.Text = "Soda (1.69)"
        Me.radDrinks1.UseVisualStyleBackColor = True
        '
        'chkBurgers
        '
        Me.chkBurgers.AutoSize = True
        Me.chkBurgers.Location = New System.Drawing.Point(12, 77)
        Me.chkBurgers.Name = "chkBurgers"
        Me.chkBurgers.Size = New System.Drawing.Size(62, 17)
        Me.chkBurgers.TabIndex = 3
        Me.chkBurgers.Text = "Burgers"
        Me.chkBurgers.UseVisualStyleBackColor = True
        '
        'chkFries
        '
        Me.chkFries.AutoSize = True
        Me.chkFries.Location = New System.Drawing.Point(12, 196)
        Me.chkFries.Name = "chkFries"
        Me.chkFries.Size = New System.Drawing.Size(48, 17)
        Me.chkFries.TabIndex = 4
        Me.chkFries.Text = "Fries"
        Me.chkFries.UseVisualStyleBackColor = True
        '
        'chkDrinks
        '
        Me.chkDrinks.AutoSize = True
        Me.chkDrinks.Location = New System.Drawing.Point(12, 282)
        Me.chkDrinks.Name = "chkDrinks"
        Me.chkDrinks.Size = New System.Drawing.Size(56, 17)
        Me.chkDrinks.TabIndex = 5
        Me.chkDrinks.Text = "Drinks"
        Me.chkDrinks.UseVisualStyleBackColor = True
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(362, 227)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(99, 47)
        Me.btnCompute.TabIndex = 6
        Me.btnCompute.Text = "Compute " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cost of Meal"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(331, 286)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Cost of meal:"
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(405, 283)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(84, 20)
        Me.txtCost.TabIndex = 8
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 332)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.chkDrinks)
        Me.Controls.Add(Me.chkFries)
        Me.Controls.Add(Me.chkBurgers)
        Me.Controls.Add(Me.grpDrinks)
        Me.Controls.Add(Me.grpFries)
        Me.Controls.Add(Me.grpBurgers)
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.grpBurgers.ResumeLayout(False)
        Me.grpBurgers.PerformLayout()
        Me.grpFries.ResumeLayout(False)
        Me.grpFries.PerformLayout()
        Me.grpDrinks.ResumeLayout(False)
        Me.grpDrinks.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpBurgers As System.Windows.Forms.GroupBox
    Friend WithEvents radBurger4 As System.Windows.Forms.RadioButton
    Friend WithEvents radBurger3 As System.Windows.Forms.RadioButton
    Friend WithEvents radBurger2 As System.Windows.Forms.RadioButton
    Friend WithEvents radBurger1 As System.Windows.Forms.RadioButton
    Friend WithEvents grpFries As System.Windows.Forms.GroupBox
    Friend WithEvents radFries3 As System.Windows.Forms.RadioButton
    Friend WithEvents radFries2 As System.Windows.Forms.RadioButton
    Friend WithEvents radFries1 As System.Windows.Forms.RadioButton
    Friend WithEvents grpDrinks As System.Windows.Forms.GroupBox
    Friend WithEvents chkBurgers As System.Windows.Forms.CheckBox
    Friend WithEvents chkFries As System.Windows.Forms.CheckBox
    Friend WithEvents chkDrinks As System.Windows.Forms.CheckBox
    Friend WithEvents radDrinks2 As System.Windows.Forms.RadioButton
    Friend WithEvents radDrinks1 As System.Windows.Forms.RadioButton
    Friend WithEvents btnCompute As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCost As System.Windows.Forms.TextBox

End Class

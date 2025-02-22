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
        Me.rbNeptune = New System.Windows.Forms.RadioButton()
        Me.rbUranus = New System.Windows.Forms.RadioButton()
        Me.rbSaturn = New System.Windows.Forms.RadioButton()
        Me.rbJupiter = New System.Windows.Forms.RadioButton()
        Me.rbMars = New System.Windows.Forms.RadioButton()
        Me.rbEarth = New System.Windows.Forms.RadioButton()
        Me.rbVenus = New System.Windows.Forms.RadioButton()
        Me.rbMercury = New System.Windows.Forms.RadioButton()
        Me.lblBirth = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpBirth = New System.Windows.Forms.DateTimePicker()
        Me.dtpNow = New System.Windows.Forms.DateTimePicker()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbNeptune)
        Me.GroupBox1.Controls.Add(Me.rbUranus)
        Me.GroupBox1.Controls.Add(Me.rbSaturn)
        Me.GroupBox1.Controls.Add(Me.rbJupiter)
        Me.GroupBox1.Controls.Add(Me.rbMars)
        Me.GroupBox1.Controls.Add(Me.rbEarth)
        Me.GroupBox1.Controls.Add(Me.rbVenus)
        Me.GroupBox1.Controls.Add(Me.rbMercury)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(110, 216)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Planet"
        '
        'rbNeptune
        '
        Me.rbNeptune.AutoSize = True
        Me.rbNeptune.Location = New System.Drawing.Point(10, 187)
        Me.rbNeptune.Name = "rbNeptune"
        Me.rbNeptune.Size = New System.Drawing.Size(66, 17)
        Me.rbNeptune.TabIndex = 1
        Me.rbNeptune.TabStop = True
        Me.rbNeptune.Text = "Neptune"
        Me.rbNeptune.UseVisualStyleBackColor = True
        '
        'rbUranus
        '
        Me.rbUranus.AutoSize = True
        Me.rbUranus.Location = New System.Drawing.Point(10, 164)
        Me.rbUranus.Name = "rbUranus"
        Me.rbUranus.Size = New System.Drawing.Size(59, 17)
        Me.rbUranus.TabIndex = 6
        Me.rbUranus.TabStop = True
        Me.rbUranus.Text = "Uranus"
        Me.rbUranus.UseVisualStyleBackColor = True
        '
        'rbSaturn
        '
        Me.rbSaturn.AutoSize = True
        Me.rbSaturn.Location = New System.Drawing.Point(10, 141)
        Me.rbSaturn.Name = "rbSaturn"
        Me.rbSaturn.Size = New System.Drawing.Size(56, 17)
        Me.rbSaturn.TabIndex = 5
        Me.rbSaturn.TabStop = True
        Me.rbSaturn.Text = "Saturn"
        Me.rbSaturn.UseVisualStyleBackColor = True
        '
        'rbJupiter
        '
        Me.rbJupiter.AutoSize = True
        Me.rbJupiter.Location = New System.Drawing.Point(10, 118)
        Me.rbJupiter.Name = "rbJupiter"
        Me.rbJupiter.Size = New System.Drawing.Size(56, 17)
        Me.rbJupiter.TabIndex = 4
        Me.rbJupiter.TabStop = True
        Me.rbJupiter.Text = "Jupiter"
        Me.rbJupiter.UseVisualStyleBackColor = True
        '
        'rbMars
        '
        Me.rbMars.AutoSize = True
        Me.rbMars.Location = New System.Drawing.Point(10, 95)
        Me.rbMars.Name = "rbMars"
        Me.rbMars.Size = New System.Drawing.Size(48, 17)
        Me.rbMars.TabIndex = 3
        Me.rbMars.TabStop = True
        Me.rbMars.Text = "Mars"
        Me.rbMars.UseVisualStyleBackColor = True
        '
        'rbEarth
        '
        Me.rbEarth.AutoSize = True
        Me.rbEarth.Location = New System.Drawing.Point(10, 72)
        Me.rbEarth.Name = "rbEarth"
        Me.rbEarth.Size = New System.Drawing.Size(50, 17)
        Me.rbEarth.TabIndex = 2
        Me.rbEarth.TabStop = True
        Me.rbEarth.Text = "Earth"
        Me.rbEarth.UseVisualStyleBackColor = True
        '
        'rbVenus
        '
        Me.rbVenus.AutoSize = True
        Me.rbVenus.Location = New System.Drawing.Point(10, 49)
        Me.rbVenus.Name = "rbVenus"
        Me.rbVenus.Size = New System.Drawing.Size(55, 17)
        Me.rbVenus.TabIndex = 1
        Me.rbVenus.TabStop = True
        Me.rbVenus.Text = "Venus"
        Me.rbVenus.UseVisualStyleBackColor = True
        '
        'rbMercury
        '
        Me.rbMercury.AutoSize = True
        Me.rbMercury.Checked = True
        Me.rbMercury.Location = New System.Drawing.Point(10, 26)
        Me.rbMercury.Name = "rbMercury"
        Me.rbMercury.Size = New System.Drawing.Size(63, 17)
        Me.rbMercury.TabIndex = 0
        Me.rbMercury.TabStop = True
        Me.rbMercury.Text = "Mercury"
        Me.rbMercury.UseVisualStyleBackColor = True
        '
        'lblBirth
        '
        Me.lblBirth.AutoSize = True
        Me.lblBirth.Location = New System.Drawing.Point(136, 39)
        Me.lblBirth.Name = "lblBirth"
        Me.lblBirth.Size = New System.Drawing.Size(69, 13)
        Me.lblBirth.TabIndex = 1
        Me.lblBirth.Text = "Date of Birth:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(206, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Date Today:"
        '
        'dtpBirth
        '
        Me.dtpBirth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBirth.Location = New System.Drawing.Point(209, 34)
        Me.dtpBirth.Name = "dtpBirth"
        Me.dtpBirth.Size = New System.Drawing.Size(119, 20)
        Me.dtpBirth.TabIndex = 3
        '
        'dtpNow
        '
        Me.dtpNow.Enabled = False
        Me.dtpNow.Location = New System.Drawing.Point(149, 95)
        Me.dtpNow.Name = "dtpNow"
        Me.dtpNow.Size = New System.Drawing.Size(179, 20)
        Me.dtpNow.TabIndex = 4
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(183, 134)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(112, 58)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate Age on Selected Planet"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(136, 217)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Age:"
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(177, 213)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(151, 20)
        Me.txtAge.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 262)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.dtpNow)
        Me.Controls.Add(Me.dtpBirth)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblBirth)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Age on Planets"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbNeptune As System.Windows.Forms.RadioButton
    Friend WithEvents rbUranus As System.Windows.Forms.RadioButton
    Friend WithEvents rbSaturn As System.Windows.Forms.RadioButton
    Friend WithEvents rbJupiter As System.Windows.Forms.RadioButton
    Friend WithEvents rbMars As System.Windows.Forms.RadioButton
    Friend WithEvents rbEarth As System.Windows.Forms.RadioButton
    Friend WithEvents rbVenus As System.Windows.Forms.RadioButton
    Friend WithEvents rbMercury As System.Windows.Forms.RadioButton
    Friend WithEvents lblBirth As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpBirth As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpNow As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAge As System.Windows.Forms.TextBox

End Class

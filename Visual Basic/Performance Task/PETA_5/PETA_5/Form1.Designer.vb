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
        Me.rbCalifornia = New System.Windows.Forms.RadioButton()
        Me.rbIndiana = New System.Windows.Forms.RadioButton()
        Me.rbMississipi = New System.Windows.Forms.RadioButton()
        Me.rbNewYork = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbFlower = New System.Windows.Forms.RadioButton()
        Me.rbNickname = New System.Windows.Forms.RadioButton()
        Me.rbMotto = New System.Windows.Forms.RadioButton()
        Me.btnShowInfo = New System.Windows.Forms.Button()
        Me.txtInfo = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbNewYork)
        Me.GroupBox1.Controls.Add(Me.rbMississipi)
        Me.GroupBox1.Controls.Add(Me.rbIndiana)
        Me.GroupBox1.Controls.Add(Me.rbCalifornia)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(123, 130)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "State"
        '
        'rbCalifornia
        '
        Me.rbCalifornia.AutoSize = True
        Me.rbCalifornia.Location = New System.Drawing.Point(16, 28)
        Me.rbCalifornia.Name = "rbCalifornia"
        Me.rbCalifornia.Size = New System.Drawing.Size(68, 17)
        Me.rbCalifornia.TabIndex = 0
        Me.rbCalifornia.TabStop = True
        Me.rbCalifornia.Text = "California"
        Me.rbCalifornia.UseVisualStyleBackColor = True
        '
        'rbIndiana
        '
        Me.rbIndiana.AutoSize = True
        Me.rbIndiana.Location = New System.Drawing.Point(16, 51)
        Me.rbIndiana.Name = "rbIndiana"
        Me.rbIndiana.Size = New System.Drawing.Size(60, 17)
        Me.rbIndiana.TabIndex = 1
        Me.rbIndiana.TabStop = True
        Me.rbIndiana.Text = "Indiana"
        Me.rbIndiana.UseVisualStyleBackColor = True
        '
        'rbMississipi
        '
        Me.rbMississipi.AutoSize = True
        Me.rbMississipi.Location = New System.Drawing.Point(16, 74)
        Me.rbMississipi.Name = "rbMississipi"
        Me.rbMississipi.Size = New System.Drawing.Size(74, 17)
        Me.rbMississipi.TabIndex = 2
        Me.rbMississipi.TabStop = True
        Me.rbMississipi.Text = "Mississippi"
        Me.rbMississipi.UseVisualStyleBackColor = True
        '
        'rbNewYork
        '
        Me.rbNewYork.AutoSize = True
        Me.rbNewYork.Location = New System.Drawing.Point(16, 97)
        Me.rbNewYork.Name = "rbNewYork"
        Me.rbNewYork.Size = New System.Drawing.Size(72, 17)
        Me.rbNewYork.TabIndex = 3
        Me.rbNewYork.TabStop = True
        Me.rbNewYork.Text = "New York"
        Me.rbNewYork.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbMotto)
        Me.GroupBox2.Controls.Add(Me.rbNickname)
        Me.GroupBox2.Controls.Add(Me.rbFlower)
        Me.GroupBox2.Location = New System.Drawing.Point(150, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(122, 130)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Category"
        '
        'rbFlower
        '
        Me.rbFlower.AutoSize = True
        Me.rbFlower.Location = New System.Drawing.Point(10, 26)
        Me.rbFlower.Name = "rbFlower"
        Me.rbFlower.Size = New System.Drawing.Size(56, 17)
        Me.rbFlower.TabIndex = 0
        Me.rbFlower.TabStop = True
        Me.rbFlower.Text = "Flower"
        Me.rbFlower.UseVisualStyleBackColor = True
        '
        'rbNickname
        '
        Me.rbNickname.AutoSize = True
        Me.rbNickname.Location = New System.Drawing.Point(10, 61)
        Me.rbNickname.Name = "rbNickname"
        Me.rbNickname.Size = New System.Drawing.Size(73, 17)
        Me.rbNickname.TabIndex = 1
        Me.rbNickname.TabStop = True
        Me.rbNickname.Text = "Nickname"
        Me.rbNickname.UseVisualStyleBackColor = True
        '
        'rbMotto
        '
        Me.rbMotto.AutoSize = True
        Me.rbMotto.Location = New System.Drawing.Point(10, 97)
        Me.rbMotto.Name = "rbMotto"
        Me.rbMotto.Size = New System.Drawing.Size(52, 17)
        Me.rbMotto.TabIndex = 2
        Me.rbMotto.TabStop = True
        Me.rbMotto.Text = "Motto"
        Me.rbMotto.UseVisualStyleBackColor = True
        '
        'btnShowInfo
        '
        Me.btnShowInfo.Location = New System.Drawing.Point(8, 149)
        Me.btnShowInfo.Name = "btnShowInfo"
        Me.btnShowInfo.Size = New System.Drawing.Size(263, 35)
        Me.btnShowInfo.TabIndex = 2
        Me.btnShowInfo.Text = "Show State Information"
        Me.btnShowInfo.UseVisualStyleBackColor = True
        '
        'txtInfo
        '
        Me.txtInfo.Location = New System.Drawing.Point(76, 190)
        Me.txtInfo.Name = "txtInfo"
        Me.txtInfo.Size = New System.Drawing.Size(136, 20)
        Me.txtInfo.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 218)
        Me.Controls.Add(Me.txtInfo)
        Me.Controls.Add(Me.btnShowInfo)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "States"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbNewYork As System.Windows.Forms.RadioButton
    Friend WithEvents rbMississipi As System.Windows.Forms.RadioButton
    Friend WithEvents rbIndiana As System.Windows.Forms.RadioButton
    Friend WithEvents rbCalifornia As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbMotto As System.Windows.Forms.RadioButton
    Friend WithEvents rbNickname As System.Windows.Forms.RadioButton
    Friend WithEvents rbFlower As System.Windows.Forms.RadioButton
    Friend WithEvents btnShowInfo As System.Windows.Forms.Button
    Friend WithEvents txtInfo As System.Windows.Forms.TextBox

End Class

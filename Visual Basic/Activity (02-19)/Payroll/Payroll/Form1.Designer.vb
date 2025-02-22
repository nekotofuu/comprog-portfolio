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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEName = New System.Windows.Forms.TextBox()
        Me.txtECode = New System.Windows.Forms.TextBox()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.cbxDept = New System.Windows.Forms.ComboBox()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtBPay = New System.Windows.Forms.TextBox()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.txtSSS = New System.Windows.Forms.TextBox()
        Me.txtPhilhealth = New System.Windows.Forms.TextBox()
        Me.txtPAGIBIG = New System.Windows.Forms.TextBox()
        Me.txtDeduct = New System.Windows.Forms.TextBox()
        Me.txtNetPay = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter the Employee Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter the Employee Code:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Select the Department:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Enter the Payrate: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(177, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Enter the Number of Hours Worked:"
        '
        'txtEName
        '
        Me.txtEName.Location = New System.Drawing.Point(210, 27)
        Me.txtEName.Name = "txtEName"
        Me.txtEName.Size = New System.Drawing.Size(103, 20)
        Me.txtEName.TabIndex = 5
        '
        'txtECode
        '
        Me.txtECode.Location = New System.Drawing.Point(210, 54)
        Me.txtECode.Name = "txtECode"
        Me.txtECode.Size = New System.Drawing.Size(103, 20)
        Me.txtECode.TabIndex = 6
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(210, 113)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(103, 20)
        Me.txtRate.TabIndex = 8
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(210, 142)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(103, 20)
        Me.txtHours.TabIndex = 9
        '
        'cbxDept
        '
        Me.cbxDept.FormattingEnabled = True
        Me.cbxDept.Items.AddRange(New Object() {"Accounting", "Marketing", "Human Resources", "ICT"})
        Me.cbxDept.Location = New System.Drawing.Point(210, 85)
        Me.cbxDept.Name = "cbxDept"
        Me.cbxDept.Size = New System.Drawing.Size(103, 21)
        Me.cbxDept.TabIndex = 10
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(12, 178)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(124, 31)
        Me.btnCompute.TabIndex = 11
        Me.btnCompute.Text = "Compute"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(142, 178)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(84, 31)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(232, 178)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(84, 31)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(139, 215)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(305, 36)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "Generate Payroll"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(353, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Basic Pay: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(353, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "12% Tax:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(353, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "SSS:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(353, 108)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "PhilHealth:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(353, 137)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "PagIBIG:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(353, 166)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Total Deductions:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(353, 192)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Net Pay:"
        '
        'txtBPay
        '
        Me.txtBPay.Location = New System.Drawing.Point(465, 22)
        Me.txtBPay.Name = "txtBPay"
        Me.txtBPay.Size = New System.Drawing.Size(100, 20)
        Me.txtBPay.TabIndex = 22
        '
        'txtTax
        '
        Me.txtTax.Location = New System.Drawing.Point(465, 49)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Size = New System.Drawing.Size(101, 20)
        Me.txtTax.TabIndex = 23
        '
        'txtSSS
        '
        Me.txtSSS.Location = New System.Drawing.Point(465, 76)
        Me.txtSSS.Name = "txtSSS"
        Me.txtSSS.Size = New System.Drawing.Size(100, 20)
        Me.txtSSS.TabIndex = 24
        '
        'txtPhilhealth
        '
        Me.txtPhilhealth.Location = New System.Drawing.Point(465, 105)
        Me.txtPhilhealth.Name = "txtPhilhealth"
        Me.txtPhilhealth.Size = New System.Drawing.Size(100, 20)
        Me.txtPhilhealth.TabIndex = 25
        '
        'txtPAGIBIG
        '
        Me.txtPAGIBIG.Location = New System.Drawing.Point(465, 134)
        Me.txtPAGIBIG.Name = "txtPAGIBIG"
        Me.txtPAGIBIG.Size = New System.Drawing.Size(100, 20)
        Me.txtPAGIBIG.TabIndex = 26
        '
        'txtDeduct
        '
        Me.txtDeduct.Location = New System.Drawing.Point(465, 163)
        Me.txtDeduct.Name = "txtDeduct"
        Me.txtDeduct.Size = New System.Drawing.Size(100, 20)
        Me.txtDeduct.TabIndex = 27
        '
        'txtNetPay
        '
        Me.txtNetPay.Location = New System.Drawing.Point(465, 189)
        Me.txtNetPay.Name = "txtNetPay"
        Me.txtNetPay.Size = New System.Drawing.Size(100, 20)
        Me.txtNetPay.TabIndex = 28
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 261)
        Me.Controls.Add(Me.txtNetPay)
        Me.Controls.Add(Me.txtDeduct)
        Me.Controls.Add(Me.txtPAGIBIG)
        Me.Controls.Add(Me.txtPhilhealth)
        Me.Controls.Add(Me.txtSSS)
        Me.Controls.Add(Me.txtTax)
        Me.Controls.Add(Me.txtBPay)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.cbxDept)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.txtECode)
        Me.Controls.Add(Me.txtEName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Payroll"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtEName As System.Windows.Forms.TextBox
    Friend WithEvents txtECode As System.Windows.Forms.TextBox
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents txtHours As System.Windows.Forms.TextBox
    Friend WithEvents cbxDept As System.Windows.Forms.ComboBox
    Friend WithEvents btnCompute As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtBPay As System.Windows.Forms.TextBox
    Friend WithEvents txtTax As System.Windows.Forms.TextBox
    Friend WithEvents txtSSS As System.Windows.Forms.TextBox
    Friend WithEvents txtPhilhealth As System.Windows.Forms.TextBox
    Friend WithEvents txtPAGIBIG As System.Windows.Forms.TextBox
    Friend WithEvents txtDeduct As System.Windows.Forms.TextBox
    Friend WithEvents txtNetPay As System.Windows.Forms.TextBox

End Class

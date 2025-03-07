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
        Me.btnDisplayRate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mtbItemNum = New System.Windows.Forms.MaskedTextBox()
        Me.mtbDuration = New System.Windows.Forms.MaskedTextBox()
        Me.btnDisplayBill = New System.Windows.Forms.Button()
        Me.lstRates = New System.Windows.Forms.ListBox()
        Me.lstReceipt = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnDisplayRate
        '
        Me.btnDisplayRate.Location = New System.Drawing.Point(25, 30)
        Me.btnDisplayRate.Name = "btnDisplayRate"
        Me.btnDisplayRate.Size = New System.Drawing.Size(238, 40)
        Me.btnDisplayRate.TabIndex = 0
        Me.btnDisplayRate.Text = "Display Rental Rates"
        Me.btnDisplayRate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select an item (1, 2, or 3)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Select a duration (H or F)"
        '
        'mtbItemNum
        '
        Me.mtbItemNum.Location = New System.Drawing.Point(163, 114)
        Me.mtbItemNum.Mask = "0"
        Me.mtbItemNum.Name = "mtbItemNum"
        Me.mtbItemNum.Size = New System.Drawing.Size(100, 20)
        Me.mtbItemNum.TabIndex = 3
        '
        'mtbDuration
        '
        Me.mtbDuration.Location = New System.Drawing.Point(163, 144)
        Me.mtbDuration.Mask = "L"
        Me.mtbDuration.Name = "mtbDuration"
        Me.mtbDuration.Size = New System.Drawing.Size(100, 20)
        Me.mtbDuration.TabIndex = 4
        '
        'btnDisplayBill
        '
        Me.btnDisplayBill.Location = New System.Drawing.Point(28, 173)
        Me.btnDisplayBill.Name = "btnDisplayBill"
        Me.btnDisplayBill.Size = New System.Drawing.Size(235, 31)
        Me.btnDisplayBill.TabIndex = 5
        Me.btnDisplayBill.Text = "Display Customer Bill"
        Me.btnDisplayBill.UseVisualStyleBackColor = True
        '
        'lstRates
        '
        Me.lstRates.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstRates.FormattingEnabled = True
        Me.lstRates.ItemHeight = 14
        Me.lstRates.Location = New System.Drawing.Point(306, 19)
        Me.lstRates.Name = "lstRates"
        Me.lstRates.Size = New System.Drawing.Size(446, 60)
        Me.lstRates.TabIndex = 6
        '
        'lstReceipt
        '
        Me.lstReceipt.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstReceipt.FormattingEnabled = True
        Me.lstReceipt.ItemHeight = 14
        Me.lstReceipt.Location = New System.Drawing.Point(305, 113)
        Me.lstReceipt.Name = "lstReceipt"
        Me.lstReceipt.Size = New System.Drawing.Size(446, 74)
        Me.lstReceipt.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 227)
        Me.Controls.Add(Me.lstReceipt)
        Me.Controls.Add(Me.lstRates)
        Me.Controls.Add(Me.btnDisplayBill)
        Me.Controls.Add(Me.mtbDuration)
        Me.Controls.Add(Me.mtbItemNum)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDisplayRate)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDisplayRate As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents mtbItemNum As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtbDuration As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnDisplayBill As System.Windows.Forms.Button
    Friend WithEvents lstRates As System.Windows.Forms.ListBox
    Friend WithEvents lstReceipt As System.Windows.Forms.ListBox

End Class

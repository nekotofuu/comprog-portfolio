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
        Me.txtPizza = New System.Windows.Forms.TextBox()
        Me.txtFries = New System.Windows.Forms.TextBox()
        Me.txtDrinks = New System.Windows.Forms.TextBox()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.lstReceipt = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "How many pizza slices?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "How many fries?"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "How many softdrinks?"
        '
        'txtPizza
        '
        Me.txtPizza.Location = New System.Drawing.Point(165, 25)
        Me.txtPizza.Name = "txtPizza"
        Me.txtPizza.Size = New System.Drawing.Size(100, 20)
        Me.txtPizza.TabIndex = 3
        '
        'txtFries
        '
        Me.txtFries.Location = New System.Drawing.Point(165, 50)
        Me.txtFries.Name = "txtFries"
        Me.txtFries.Size = New System.Drawing.Size(100, 20)
        Me.txtFries.TabIndex = 5
        '
        'txtDrinks
        '
        Me.txtDrinks.Location = New System.Drawing.Point(165, 75)
        Me.txtDrinks.Name = "txtDrinks"
        Me.txtDrinks.Size = New System.Drawing.Size(100, 20)
        Me.txtDrinks.TabIndex = 6
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(290, 39)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(80, 41)
        Me.btnCompute.TabIndex = 7
        Me.btnCompute.Text = "Compute Total Cost"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'lstReceipt
        '
        Me.lstReceipt.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstReceipt.FormattingEnabled = True
        Me.lstReceipt.ItemHeight = 14
        Me.lstReceipt.Location = New System.Drawing.Point(12, 108)
        Me.lstReceipt.Name = "lstReceipt"
        Me.lstReceipt.Size = New System.Drawing.Size(357, 130)
        Me.lstReceipt.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 261)
        Me.Controls.Add(Me.lstReceipt)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.txtDrinks)
        Me.Controls.Add(Me.txtFries)
        Me.Controls.Add(Me.txtPizza)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Restaurant Bill"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPizza As System.Windows.Forms.TextBox
    Friend WithEvents txtFries As System.Windows.Forms.TextBox
    Friend WithEvents txtDrinks As System.Windows.Forms.TextBox
    Friend WithEvents btnCompute As System.Windows.Forms.Button
    Friend WithEvents lstReceipt As System.Windows.Forms.ListBox

End Class

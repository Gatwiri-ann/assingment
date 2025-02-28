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
        Me.btnLoadPicture = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.rbGreen = New System.Windows.Forms.RadioButton()
        Me.rbBlue = New System.Windows.Forms.RadioButton()
        Me.rbRed = New System.Windows.Forms.RadioButton()
        Me.chkItalic = New System.Windows.Forms.CheckBox()
        Me.chkBold = New System.Windows.Forms.CheckBox()
        Me.chkBoldItalic = New System.Windows.Forms.CheckBox()
        Me.cmbFont = New System.Windows.Forms.ComboBox()
        Me.picBox = New System.Windows.Forms.PictureBox()
        Me.lblSampleText = New System.Windows.Forms.Label()
        CType(Me.picBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLoadPicture
        '
        Me.btnLoadPicture.Location = New System.Drawing.Point(12, 400)
        Me.btnLoadPicture.Name = "btnLoadPicture"
        Me.btnLoadPicture.Size = New System.Drawing.Size(125, 38)
        Me.btnLoadPicture.TabIndex = 0
        Me.btnLoadPicture.Text = "load picture"
        Me.btnLoadPicture.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(627, 394)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(85, 44)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'rbGreen
        '
        Me.rbGreen.AutoSize = True
        Me.rbGreen.Location = New System.Drawing.Point(625, 107)
        Me.rbGreen.Name = "rbGreen"
        Me.rbGreen.Size = New System.Drawing.Size(54, 17)
        Me.rbGreen.TabIndex = 22
        Me.rbGreen.TabStop = True
        Me.rbGreen.Text = "Green"
        Me.rbGreen.UseVisualStyleBackColor = True
        '
        'rbBlue
        '
        Me.rbBlue.AutoSize = True
        Me.rbBlue.Location = New System.Drawing.Point(624, 201)
        Me.rbBlue.Name = "rbBlue"
        Me.rbBlue.Size = New System.Drawing.Size(46, 17)
        Me.rbBlue.TabIndex = 23
        Me.rbBlue.TabStop = True
        Me.rbBlue.Text = "Blue"
        Me.rbBlue.UseVisualStyleBackColor = True
        '
        'rbRed
        '
        Me.rbRed.AutoSize = True
        Me.rbRed.Location = New System.Drawing.Point(625, 281)
        Me.rbRed.Name = "rbRed"
        Me.rbRed.Size = New System.Drawing.Size(45, 17)
        Me.rbRed.TabIndex = 24
        Me.rbRed.TabStop = True
        Me.rbRed.Text = "Red"
        Me.rbRed.UseVisualStyleBackColor = True
        '
        'chkItalic
        '
        Me.chkItalic.AutoSize = True
        Me.chkItalic.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkItalic.Location = New System.Drawing.Point(284, 117)
        Me.chkItalic.Name = "chkItalic"
        Me.chkItalic.Size = New System.Drawing.Size(48, 17)
        Me.chkItalic.TabIndex = 27
        Me.chkItalic.Text = "Italic"
        Me.chkItalic.UseVisualStyleBackColor = True
        '
        'chkBold
        '
        Me.chkBold.AutoSize = True
        Me.chkBold.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBold.Location = New System.Drawing.Point(281, 201)
        Me.chkBold.Name = "chkBold"
        Me.chkBold.Size = New System.Drawing.Size(51, 17)
        Me.chkBold.TabIndex = 28
        Me.chkBold.Text = "Bold"
        Me.chkBold.UseVisualStyleBackColor = True
        '
        'chkBoldItalic
        '
        Me.chkBoldItalic.AutoSize = True
        Me.chkBoldItalic.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBoldItalic.Location = New System.Drawing.Point(281, 282)
        Me.chkBoldItalic.Name = "chkBoldItalic"
        Me.chkBoldItalic.Size = New System.Drawing.Size(83, 17)
        Me.chkBoldItalic.TabIndex = 31
        Me.chkBoldItalic.Text = "Bold Italic"
        Me.chkBoldItalic.UseVisualStyleBackColor = True
        '
        'cmbFont
        '
        Me.cmbFont.FormattingEnabled = True
        Me.cmbFont.Items.AddRange(New Object() {"Tahoma", "Garamond", "Magneto"})
        Me.cmbFont.Location = New System.Drawing.Point(281, 5)
        Me.cmbFont.Name = "cmbFont"
        Me.cmbFont.Size = New System.Drawing.Size(367, 21)
        Me.cmbFont.TabIndex = 34
        '
        'picBox
        '
        Me.picBox.Location = New System.Drawing.Point(13, 107)
        Me.picBox.Name = "picBox"
        Me.picBox.Size = New System.Drawing.Size(170, 192)
        Me.picBox.TabIndex = 35
        Me.picBox.TabStop = False
        '
        'lblSampleText
        '
        Me.lblSampleText.AutoSize = True
        Me.lblSampleText.Location = New System.Drawing.Point(51, 42)
        Me.lblSampleText.Name = "lblSampleText"
        Me.lblSampleText.Size = New System.Drawing.Size(66, 13)
        Me.lblSampleText.TabIndex = 36
        Me.lblSampleText.Text = "Sample Text"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblSampleText)
        Me.Controls.Add(Me.picBox)
        Me.Controls.Add(Me.cmbFont)
        Me.Controls.Add(Me.chkBoldItalic)
        Me.Controls.Add(Me.chkBold)
        Me.Controls.Add(Me.chkItalic)
        Me.Controls.Add(Me.rbRed)
        Me.Controls.Add(Me.rbBlue)
        Me.Controls.Add(Me.rbGreen)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLoadPicture)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLoadPicture As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents rbGreen As RadioButton
    Friend WithEvents rbBlue As RadioButton
    Friend WithEvents rbRed As RadioButton
    Friend WithEvents chkItalic As CheckBox
    Friend WithEvents chkBold As CheckBox
    Friend WithEvents chkBoldItalic As CheckBox
    Friend WithEvents cmbFont As ComboBox
    Friend WithEvents picBox As PictureBox
    Friend WithEvents lblSampleText As Label
End Class

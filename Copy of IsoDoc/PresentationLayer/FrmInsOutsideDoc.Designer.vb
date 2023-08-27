<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInsOutsideDoc
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInsOutsideDoc))
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
        Me.JGridNavigator1 = New JFrameWork.JGridNavigator
        Me.UiButton5 = New Janus.Windows.EditControls.UIButton
        Me.UiButton4 = New Janus.Windows.EditControls.UIButton
        Me.UiButton3 = New Janus.Windows.EditControls.UIButton
        Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox
        Me.txtRevisionNum = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtDocCode = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.MskReviewDate = New System.Windows.Forms.MaskedTextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.UiButton2 = New Janus.Windows.EditControls.UIButton
        Me.UiButton1 = New Janus.Windows.EditControls.UIButton
        Me.txtFilePath = New System.Windows.Forms.TextBox
        Me.lblFilePath = New System.Windows.Forms.Label
        Me.txtDocName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.dg = New Janus.Windows.GridEX.GridEX
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtsherkat = New System.Windows.Forms.TextBox
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox2.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.ExplorerBarBackground
        Me.UiGroupBox1.Controls.Add(Me.JGridNavigator1)
        Me.UiGroupBox1.Controls.Add(Me.UiButton5)
        Me.UiGroupBox1.Controls.Add(Me.UiButton4)
        Me.UiGroupBox1.Controls.Add(Me.UiButton3)
        Me.UiGroupBox1.Controls.Add(Me.UiGroupBox2)
        Me.UiGroupBox1.Controls.Add(Me.dg)
        Me.UiGroupBox1.Location = New System.Drawing.Point(-1, -13)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Size = New System.Drawing.Size(805, 544)
        Me.UiGroupBox1.TabIndex = 0
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
        '
        'JGridNavigator1
        '
        Me.JGridNavigator1.JDataTable = Nothing
        Me.JGridNavigator1.Location = New System.Drawing.Point(14, 143)
        Me.JGridNavigator1.Name = "JGridNavigator1"
        Me.JGridNavigator1.Size = New System.Drawing.Size(224, 20)
        Me.JGridNavigator1.TabIndex = 79
        '
        'UiButton5
        '
        Me.UiButton5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UiButton5.Image = CType(resources.GetObject("UiButton5.Image"), System.Drawing.Image)
        Me.UiButton5.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far
        Me.UiButton5.Location = New System.Drawing.Point(310, 135)
        Me.UiButton5.Name = "UiButton5"
        Me.UiButton5.Size = New System.Drawing.Size(62, 22)
        Me.UiButton5.TabIndex = 78
        Me.UiButton5.Text = "Õ–›"
        Me.UiButton5.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'UiButton4
        '
        Me.UiButton4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UiButton4.Image = CType(resources.GetObject("UiButton4.Image"), System.Drawing.Image)
        Me.UiButton4.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far
        Me.UiButton4.Location = New System.Drawing.Point(378, 135)
        Me.UiButton4.Name = "UiButton4"
        Me.UiButton4.Size = New System.Drawing.Size(62, 22)
        Me.UiButton4.TabIndex = 77
        Me.UiButton4.Text = "ÊÌ—«Ì‘"
        Me.UiButton4.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'UiButton3
        '
        Me.UiButton3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UiButton3.Image = CType(resources.GetObject("UiButton3.Image"), System.Drawing.Image)
        Me.UiButton3.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far
        Me.UiButton3.Location = New System.Drawing.Point(446, 135)
        Me.UiButton3.Name = "UiButton3"
        Me.UiButton3.Size = New System.Drawing.Size(62, 22)
        Me.UiButton3.TabIndex = 76
        Me.UiButton3.Text = "À» "
        Me.UiButton3.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'UiGroupBox2
        '
        Me.UiGroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UiGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox2.BorderColor = System.Drawing.Color.Red
        Me.UiGroupBox2.Controls.Add(Me.txtsherkat)
        Me.UiGroupBox2.Controls.Add(Me.Label5)
        Me.UiGroupBox2.Controls.Add(Me.txtRevisionNum)
        Me.UiGroupBox2.Controls.Add(Me.Label4)
        Me.UiGroupBox2.Controls.Add(Me.txtDocCode)
        Me.UiGroupBox2.Controls.Add(Me.Label2)
        Me.UiGroupBox2.Controls.Add(Me.MskReviewDate)
        Me.UiGroupBox2.Controls.Add(Me.Label3)
        Me.UiGroupBox2.Controls.Add(Me.UiButton2)
        Me.UiGroupBox2.Controls.Add(Me.UiButton1)
        Me.UiGroupBox2.Controls.Add(Me.txtFilePath)
        Me.UiGroupBox2.Controls.Add(Me.lblFilePath)
        Me.UiGroupBox2.Controls.Add(Me.txtDocName)
        Me.UiGroupBox2.Controls.Add(Me.Label1)
        Me.UiGroupBox2.Location = New System.Drawing.Point(13, 17)
        Me.UiGroupBox2.Name = "UiGroupBox2"
        Me.UiGroupBox2.Size = New System.Drawing.Size(768, 112)
        Me.UiGroupBox2.TabIndex = 1
        Me.UiGroupBox2.Text = "À»  „” ‰œ«  »—Ê‰ ”«“„«‰Ì"
        '
        'txtRevisionNum
        '
        Me.txtRevisionNum.Location = New System.Drawing.Point(513, 75)
        Me.txtRevisionNum.Name = "txtRevisionNum"
        Me.txtRevisionNum.Size = New System.Drawing.Size(85, 21)
        Me.txtRevisionNum.TabIndex = 83
        Me.txtRevisionNum.Tag = "-1"
        Me.txtRevisionNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(588, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 17)
        Me.Label4.TabIndex = 82
        Me.Label4.Tag = "-1"
        Me.Label4.Text = "‘„«—Â »«“‰ê—Ì"
        '
        'txtDocCode
        '
        Me.txtDocCode.Location = New System.Drawing.Point(206, 23)
        Me.txtDocCode.Name = "txtDocCode"
        Me.txtDocCode.Size = New System.Drawing.Size(85, 21)
        Me.txtDocCode.TabIndex = 81
        Me.txtDocCode.Tag = "-1"
        Me.txtDocCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(297, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 80
        Me.Label2.Tag = "-1"
        Me.Label2.Text = "òœ ”‰œ"
        '
        'MskReviewDate
        '
        Me.MskReviewDate.Location = New System.Drawing.Point(20, 23)
        Me.MskReviewDate.Mask = "####/##/##"
        Me.MskReviewDate.Name = "MskReviewDate"
        Me.MskReviewDate.Size = New System.Drawing.Size(109, 21)
        Me.MskReviewDate.SkipLiterals = False
        Me.MskReviewDate.TabIndex = 79
        Me.MskReviewDate.Tag = "-1"
        Me.MskReviewDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(135, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 78
        Me.Label3.Tag = "-1"
        Me.Label3.Text = " «—ÌŒ »«“‰ê—Ì"
        '
        'UiButton2
        '
        Me.UiButton2.Location = New System.Drawing.Point(20, 50)
        Me.UiButton2.Name = "UiButton2"
        Me.UiButton2.Size = New System.Drawing.Size(62, 22)
        Me.UiButton2.TabIndex = 75
        Me.UiButton2.Text = "„‘«ÂœÂ"
        Me.UiButton2.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'UiButton1
        '
        Me.UiButton1.ButtonStyle = Janus.Windows.EditControls.ButtonStyle.Ellipsis
        Me.UiButton1.Location = New System.Drawing.Point(88, 53)
        Me.UiButton1.Name = "UiButton1"
        Me.UiButton1.Size = New System.Drawing.Size(29, 17)
        Me.UiButton1.TabIndex = 2
        Me.UiButton1.Text = "UiButton1"
        Me.UiButton1.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'txtFilePath
        '
        Me.txtFilePath.Location = New System.Drawing.Point(123, 51)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.Size = New System.Drawing.Size(475, 21)
        Me.txtFilePath.TabIndex = 72
        Me.txtFilePath.Tag = "-1"
        Me.txtFilePath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFilePath
        '
        Me.lblFilePath.AutoSize = True
        Me.lblFilePath.ForeColor = System.Drawing.Color.Navy
        Me.lblFilePath.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFilePath.Location = New System.Drawing.Point(601, 54)
        Me.lblFilePath.Name = "lblFilePath"
        Me.lblFilePath.Size = New System.Drawing.Size(155, 13)
        Me.lblFilePath.TabIndex = 74
        Me.lblFilePath.Tag = "-1"
        Me.lblFilePath.Text = " „”Ì— ›«Ì· «’·Ì »— —ÊÌ ‘»ﬂÂ "
        '
        'txtDocName
        '
        Me.txtDocName.Location = New System.Drawing.Point(342, 24)
        Me.txtDocName.Name = "txtDocName"
        Me.txtDocName.Size = New System.Drawing.Size(370, 21)
        Me.txtDocName.TabIndex = 68
        Me.txtDocName.Tag = "-1"
        Me.txtDocName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(718, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 67
        Me.Label1.Tag = "-1"
        Me.Label1.Text = "‰«„ ”‰œ"
        '
        'dg
        '
        Me.dg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dg.Location = New System.Drawing.Point(13, 163)
        Me.dg.Name = "dg"
        Me.dg.RecordNavigator = True
        Me.dg.Size = New System.Drawing.Size(768, 361)
        Me.dg.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(406, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 17)
        Me.Label5.TabIndex = 84
        Me.Label5.Tag = "-1"
        Me.Label5.Text = "‰«„ ‘—ò "
        '
        'txtsherkat
        '
        Me.txtsherkat.Location = New System.Drawing.Point(276, 75)
        Me.txtsherkat.Name = "txtsherkat"
        Me.txtsherkat.Size = New System.Drawing.Size(161, 21)
        Me.txtsherkat.TabIndex = 85
        Me.txtsherkat.Tag = "-1"
        Me.txtsherkat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FrmInsOutsideDoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 526)
        Me.Controls.Add(Me.UiGroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmInsOutsideDoc"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox2.ResumeLayout(False)
        Me.UiGroupBox2.PerformLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents dg As Janus.Windows.GridEX.GridEX
    Friend WithEvents txtDocName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFilePath As System.Windows.Forms.TextBox
    Friend WithEvents lblFilePath As System.Windows.Forms.Label
    Friend WithEvents UiButton2 As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiButton1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiButton5 As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiButton4 As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiButton3 As Janus.Windows.EditControls.UIButton
    Friend WithEvents MskReviewDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents JGridNavigator1 As JFrameWork.JGridNavigator
    Friend WithEvents txtDocCode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtRevisionNum As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtsherkat As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class

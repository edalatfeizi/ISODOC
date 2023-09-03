<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIsoInsertHistory
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmIsoInsertHistory))
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
        Me.lblDocID = New System.Windows.Forms.Label
        Me.lblDocTypeID = New System.Windows.Forms.Label
        Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox
        Me.lblMdepCode = New System.Windows.Forms.Label
        Me.lblHistorySave = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.lblReviewNum = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.lblReviewDate = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblDocCode = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblDocName = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.lblFilePath = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.ExplorerBarBackground
        Me.UiGroupBox1.Controls.Add(Me.lblDocID)
        Me.UiGroupBox1.Controls.Add(Me.lblDocTypeID)
        Me.UiGroupBox1.Controls.Add(Me.UiGroupBox2)
        Me.UiGroupBox1.Controls.Add(Me.Button2)
        Me.UiGroupBox1.Controls.Add(Me.Button1)
        Me.UiGroupBox1.Controls.Add(Me.lblFilePath)
        Me.UiGroupBox1.Controls.Add(Me.Label6)
        Me.UiGroupBox1.Location = New System.Drawing.Point(-9, -14)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Size = New System.Drawing.Size(575, 374)
        Me.UiGroupBox1.TabIndex = 0
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
        '
        'lblDocID
        '
        Me.lblDocID.BackColor = System.Drawing.Color.DarkGray
        Me.lblDocID.Location = New System.Drawing.Point(104, 315)
        Me.lblDocID.Name = "lblDocID"
        Me.lblDocID.Size = New System.Drawing.Size(64, 22)
        Me.lblDocID.TabIndex = 7
        Me.lblDocID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblDocID.Visible = False
        '
        'lblDocTypeID
        '
        Me.lblDocTypeID.BackColor = System.Drawing.Color.DarkGray
        Me.lblDocTypeID.Location = New System.Drawing.Point(21, 315)
        Me.lblDocTypeID.Name = "lblDocTypeID"
        Me.lblDocTypeID.Size = New System.Drawing.Size(64, 22)
        Me.lblDocTypeID.TabIndex = 6
        Me.lblDocTypeID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblDocTypeID.Visible = False
        '
        'UiGroupBox2
        '
        Me.UiGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox2.BorderColor = System.Drawing.Color.Yellow
        Me.UiGroupBox2.Controls.Add(Me.lblMdepCode)
        Me.UiGroupBox2.Controls.Add(Me.lblHistorySave)
        Me.UiGroupBox2.Controls.Add(Me.Label12)
        Me.UiGroupBox2.Controls.Add(Me.lblReviewNum)
        Me.UiGroupBox2.Controls.Add(Me.Label10)
        Me.UiGroupBox2.Controls.Add(Me.lblReviewDate)
        Me.UiGroupBox2.Controls.Add(Me.Label8)
        Me.UiGroupBox2.Controls.Add(Me.lblDocCode)
        Me.UiGroupBox2.Controls.Add(Me.Label4)
        Me.UiGroupBox2.Controls.Add(Me.lblDocName)
        Me.UiGroupBox2.Controls.Add(Me.Label1)
        Me.UiGroupBox2.Location = New System.Drawing.Point(21, 26)
        Me.UiGroupBox2.Name = "UiGroupBox2"
        Me.UiGroupBox2.Size = New System.Drawing.Size(530, 275)
        Me.UiGroupBox2.TabIndex = 2
        '
        'lblMdepCode
        '
        Me.lblMdepCode.BackColor = System.Drawing.Color.DarkGray
        Me.lblMdepCode.Location = New System.Drawing.Point(428, 225)
        Me.lblMdepCode.Name = "lblMdepCode"
        Me.lblMdepCode.Size = New System.Drawing.Size(64, 22)
        Me.lblMdepCode.TabIndex = 12
        Me.lblMdepCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMdepCode.Visible = False
        '
        'lblHistorySave
        '
        Me.lblHistorySave.BackColor = System.Drawing.Color.LightYellow
        Me.lblHistorySave.Location = New System.Drawing.Point(186, 170)
        Me.lblHistorySave.Name = "lblHistorySave"
        Me.lblHistorySave.Size = New System.Drawing.Size(251, 22)
        Me.lblHistorySave.TabIndex = 11
        Me.lblHistorySave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label12.Location = New System.Drawing.Point(443, 172)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 19)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "„œ  ‰êÂœ«—Ì"
        '
        'lblReviewNum
        '
        Me.lblReviewNum.BackColor = System.Drawing.Color.LightYellow
        Me.lblReviewNum.Location = New System.Drawing.Point(186, 133)
        Me.lblReviewNum.Name = "lblReviewNum"
        Me.lblReviewNum.Size = New System.Drawing.Size(250, 22)
        Me.lblReviewNum.TabIndex = 9
        Me.lblReviewNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label10.Location = New System.Drawing.Point(442, 136)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 19)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "‘„«—Â »«“‰ê—Ì"
        '
        'lblReviewDate
        '
        Me.lblReviewDate.BackColor = System.Drawing.Color.LightYellow
        Me.lblReviewDate.Location = New System.Drawing.Point(186, 91)
        Me.lblReviewDate.Name = "lblReviewDate"
        Me.lblReviewDate.Size = New System.Drawing.Size(251, 22)
        Me.lblReviewDate.TabIndex = 7
        Me.lblReviewDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label8.Location = New System.Drawing.Point(435, 91)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 19)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = " «—ÌŒ »«“‰ê—Ì"
        '
        'lblDocCode
        '
        Me.lblDocCode.BackColor = System.Drawing.Color.LightYellow
        Me.lblDocCode.Location = New System.Drawing.Point(20, 53)
        Me.lblDocCode.Name = "lblDocCode"
        Me.lblDocCode.Size = New System.Drawing.Size(417, 22)
        Me.lblDocCode.TabIndex = 3
        Me.lblDocCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Location = New System.Drawing.Point(443, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 19)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "ﬂœ ”‰œ"
        '
        'lblDocName
        '
        Me.lblDocName.BackColor = System.Drawing.Color.LightYellow
        Me.lblDocName.Location = New System.Drawing.Point(20, 17)
        Me.lblDocName.Name = "lblDocName"
        Me.lblDocName.Size = New System.Drawing.Size(417, 22)
        Me.lblDocName.TabIndex = 1
        Me.lblDocName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(443, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "‰«„ ”‰œ"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(207, 315)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 28)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "«‰’—«›"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(285, 315)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 28)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "»«Ìê«‰Ì"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblFilePath
        '
        Me.lblFilePath.BackColor = System.Drawing.Color.DarkGray
        Me.lblFilePath.Location = New System.Drawing.Point(395, 315)
        Me.lblFilePath.Name = "lblFilePath"
        Me.lblFilePath.Size = New System.Drawing.Size(118, 22)
        Me.lblFilePath.TabIndex = 5
        Me.lblFilePath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblFilePath.Visible = False
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(428, 340)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 19)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "„”Ì— ›«Ì·"
        Me.Label6.Visible = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "NOTE02.ICO")
        '
        'FrmIsoInsertHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 346)
        Me.Controls.Add(Me.UiGroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmIsoInsertHistory"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "»«Ìê«‰Ì ”‰œ"
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblDocName As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblHistorySave As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblReviewNum As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblReviewDate As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblFilePath As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblDocCode As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblDocTypeID As System.Windows.Forms.Label
    Friend WithEvents lblDocID As System.Windows.Forms.Label
    Friend WithEvents lblMdepCode As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
End Class

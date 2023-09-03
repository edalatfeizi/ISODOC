<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIso_TechnicalDoc
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
        Dim ExplorerBarGroup1 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
        Dim ExplorerBarItem1 As Janus.Windows.ExplorerBar.ExplorerBarItem = New Janus.Windows.ExplorerBar.ExplorerBarItem
        Dim ExplorerBarItem2 As Janus.Windows.ExplorerBar.ExplorerBarItem = New Janus.Windows.ExplorerBar.ExplorerBarItem
        Dim ExplorerBarItem3 As Janus.Windows.ExplorerBar.ExplorerBarItem = New Janus.Windows.ExplorerBar.ExplorerBarItem
        Dim ExplorerBarGroup2 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
        Dim ExplorerBarItem4 As Janus.Windows.ExplorerBar.ExplorerBarItem = New Janus.Windows.ExplorerBar.ExplorerBarItem
        Dim ExplorerBarGroup3 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
        Dim ExplorerBarItem5 As Janus.Windows.ExplorerBar.ExplorerBarItem = New Janus.Windows.ExplorerBar.ExplorerBarItem
        Dim ExplorerBarItem6 As Janus.Windows.ExplorerBar.ExplorerBarItem = New Janus.Windows.ExplorerBar.ExplorerBarItem
        Dim ExplorerBarGroup4 As Janus.Windows.ExplorerBar.ExplorerBarGroup = New Janus.Windows.ExplorerBar.ExplorerBarGroup
        Dim ExplorerBarItem7 As Janus.Windows.ExplorerBar.ExplorerBarItem = New Janus.Windows.ExplorerBar.ExplorerBarItem
        Dim ExplorerBarItem8 As Janus.Windows.ExplorerBar.ExplorerBarItem = New Janus.Windows.ExplorerBar.ExplorerBarItem
        Dim ExplorerBarItem9 As Janus.Windows.ExplorerBar.ExplorerBarItem = New Janus.Windows.ExplorerBar.ExplorerBarItem
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmIso_TechnicalDoc))
        Me.lblFilePath = New System.Windows.Forms.Label
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
        Me.ExplorerBar1 = New Janus.Windows.ExplorerBar.ExplorerBar
        Me.lblExecute = New System.Windows.Forms.Label
        Me.PicShow = New System.Windows.Forms.PictureBox
        Me.dg = New Janus.Windows.GridEX.GridEX
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GridEXPrintDocument1 = New Janus.Windows.GridEX.GridEXPrintDocument
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.ExplorerBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ExplorerBar1.SuspendLayout()
        CType(Me.PicShow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFilePath
        '
        Me.lblFilePath.BackColor = System.Drawing.Color.Transparent
        Me.lblFilePath.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblFilePath.Location = New System.Drawing.Point(778, 78)
        Me.lblFilePath.Name = "lblFilePath"
        Me.lblFilePath.Size = New System.Drawing.Size(170, 19)
        Me.lblFilePath.TabIndex = 26
        Me.lblFilePath.Text = "FilePath"
        Me.lblFilePath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.ExplorerBarBackground
        Me.UiGroupBox1.Controls.Add(Me.ExplorerBar1)
        Me.UiGroupBox1.Controls.Add(Me.dg)
        Me.UiGroupBox1.Controls.Add(Me.lblFilePath)
        Me.UiGroupBox1.Location = New System.Drawing.Point(-3, -10)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Size = New System.Drawing.Size(1024, 750)
        Me.UiGroupBox1.TabIndex = 27
        '
        'ExplorerBar1
        '
        Me.ExplorerBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExplorerBar1.Controls.Add(Me.lblExecute)
        Me.ExplorerBar1.Controls.Add(Me.PicShow)
        Me.ExplorerBar1.Cursor = System.Windows.Forms.Cursors.Hand
        ExplorerBarGroup1.FormatStyle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        ExplorerBarItem1.Cursor = System.Windows.Forms.Cursors.Default
        ExplorerBarItem1.FormatStyle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        ExplorerBarItem1.Icon = CType(resources.GetObject("ExplorerBarItem1.Icon"), System.Drawing.Icon)
        ExplorerBarItem1.Key = "btnViewDoc"
        ExplorerBarItem1.Text = "‰„«Ì‘ ”‰œ"
        ExplorerBarItem2.Cursor = System.Windows.Forms.Cursors.Default
        ExplorerBarItem2.FormatStyle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        ExplorerBarItem2.Icon = CType(resources.GetObject("ExplorerBarItem2.Icon"), System.Drawing.Icon)
        ExplorerBarItem2.Key = "btnLifeSheet"
        ExplorerBarItem2.Text = "Life Sheet"
        ExplorerBarItem3.Cursor = System.Windows.Forms.Cursors.Default
        ExplorerBarItem3.FormatStyle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        ExplorerBarItem3.Icon = CType(resources.GetObject("ExplorerBarItem3.Icon"), System.Drawing.Icon)
        ExplorerBarItem3.Key = "btnClose"
        ExplorerBarItem3.Text = "Œ—ÊÃ"
        ExplorerBarGroup1.Items.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarItem() {ExplorerBarItem1, ExplorerBarItem2, ExplorerBarItem3})
        ExplorerBarGroup1.Key = "Group4"
        ExplorerBarGroup1.TagString = "-1"
        ExplorerBarGroup1.Text = "ﬂ«—»—Ì"
        ExplorerBarGroup1.TextAlignment = Janus.Windows.ExplorerBar.Alignment.Center
        ExplorerBarGroup2.FormatStyle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        ExplorerBarItem4.FormatStyle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        ExplorerBarItem4.Icon = CType(resources.GetObject("ExplorerBarItem4.Icon"), System.Drawing.Icon)
        ExplorerBarItem4.Key = "btnSearch"
        ExplorerBarItem4.Text = "Ã” ÃÊ"
        ExplorerBarGroup2.Items.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarItem() {ExplorerBarItem4})
        ExplorerBarGroup2.Key = "Group1"
        ExplorerBarGroup2.TagString = "-1"
        ExplorerBarGroup2.Text = "Ã” ÃÊ "
        ExplorerBarGroup2.TextAlignment = Janus.Windows.ExplorerBar.Alignment.Center
        ExplorerBarGroup3.Expanded = False
        ExplorerBarGroup3.FormatStyle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        ExplorerBarItem5.FormatStyle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        ExplorerBarItem5.Icon = CType(resources.GetObject("ExplorerBarItem5.Icon"), System.Drawing.Icon)
        ExplorerBarItem5.Key = "btnFavoriteList"
        ExplorerBarItem5.Text = "·Ì”  ⁄·«ﬁÂ Â«"
        ExplorerBarItem6.FormatStyle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        ExplorerBarItem6.Icon = CType(resources.GetObject("ExplorerBarItem6.Icon"), System.Drawing.Icon)
        ExplorerBarItem6.Key = "addtoFavorite"
        ExplorerBarItem6.Text = "«›“Êœ‰ »Â ·Ì”  ⁄·«ﬁÂ Â«"
        ExplorerBarGroup3.Items.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarItem() {ExplorerBarItem5, ExplorerBarItem6})
        ExplorerBarGroup3.Key = "Group2"
        ExplorerBarGroup3.TagString = "-1"
        ExplorerBarGroup3.Text = "⁄·«ﬁÂ „‰œÌ Â«"
        ExplorerBarGroup3.TextAlignment = Janus.Windows.ExplorerBar.Alignment.Center
        ExplorerBarGroup4.Expanded = False
        ExplorerBarGroup4.FormatStyle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        ExplorerBarItem7.FormatStyle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        ExplorerBarItem7.Key = "btnEditBasic"
        ExplorerBarItem7.TagString = "629"
        ExplorerBarItem7.Text = "À» /ÊÌ—«Ì‘ «ÿ·«⁄«  Å«ÌÂ"
        ExplorerBarItem8.FormatStyle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        ExplorerBarItem8.Key = "btnEditMaster"
        ExplorerBarItem8.TagString = "629"
        ExplorerBarItem8.Text = "À» /ÊÌ—«Ì‘ „” ‰œ«  «’·Ì"
        ExplorerBarItem9.FormatStyle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        ExplorerBarItem9.Icon = CType(resources.GetObject("ExplorerBarItem9.Icon"), System.Drawing.Icon)
        ExplorerBarItem9.Key = "Print"
        ExplorerBarItem9.TagString = "-1"
        ExplorerBarItem9.Text = "ç«Å"
        ExplorerBarGroup4.Items.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarItem() {ExplorerBarItem7, ExplorerBarItem8, ExplorerBarItem9})
        ExplorerBarGroup4.Key = "Group3"
        ExplorerBarGroup4.TagString = "629"
        ExplorerBarGroup4.Text = " ‰ŸÌ„« "
        ExplorerBarGroup4.TextAlignment = Janus.Windows.ExplorerBar.Alignment.Center
        Me.ExplorerBar1.Groups.AddRange(New Janus.Windows.ExplorerBar.ExplorerBarGroup() {ExplorerBarGroup1, ExplorerBarGroup2, ExplorerBarGroup3, ExplorerBarGroup4})
        Me.ExplorerBar1.Location = New System.Drawing.Point(597, 11)
        Me.ExplorerBar1.Name = "ExplorerBar1"
        Me.ExplorerBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ExplorerBar1.Selectable = True
        Me.ExplorerBar1.Size = New System.Drawing.Size(197, 559)
        Me.ExplorerBar1.TabIndex = 38
        Me.ExplorerBar1.Tag = "-1"
        Me.ExplorerBar1.Text = "ExplorerBar1"
        Me.ExplorerBar1.VisualStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
        Me.ExplorerBar1.VisualStyleAreas.BackgroundStyle = Janus.Windows.ExplorerBar.VisualStyle.Standard
        Me.ExplorerBar1.VisualStyleAreas.BorderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
        Me.ExplorerBar1.VisualStyleAreas.GroupHeaderStyle = Janus.Windows.ExplorerBar.VisualStyle.Office2003
        Me.ExplorerBar1.VisualStyleAreas.HoverItemStyle = Janus.Windows.ExplorerBar.VisualStyle.Standard
        Me.ExplorerBar1.VisualStyleAreas.ItemsStyle = Janus.Windows.ExplorerBar.VisualStyle.Standard
        Me.ExplorerBar1.VisualStyleAreas.SelectedItemStyle = Janus.Windows.ExplorerBar.VisualStyle.Standard
        '
        'lblExecute
        '
        Me.lblExecute.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblExecute.AutoSize = True
        Me.lblExecute.BackColor = System.Drawing.Color.Transparent
        Me.lblExecute.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExecute.ForeColor = System.Drawing.Color.Orange
        Me.lblExecute.Location = New System.Drawing.Point(57, 496)
        Me.lblExecute.Name = "lblExecute"
        Me.lblExecute.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblExecute.Size = New System.Drawing.Size(114, 13)
        Me.lblExecute.TabIndex = 1
        Me.lblExecute.Text = "·ÿ›« ﬂ„Ì ’»— ﬂ‰Ìœ..."
        Me.lblExecute.Visible = False
        '
        'PicShow
        '
        Me.PicShow.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PicShow.BackColor = System.Drawing.Color.Transparent
        Me.PicShow.Enabled = False
        Me.PicShow.Image = CType(resources.GetObject("PicShow.Image"), System.Drawing.Image)
        Me.PicShow.Location = New System.Drawing.Point(17, 489)
        Me.PicShow.Name = "PicShow"
        Me.PicShow.Size = New System.Drawing.Size(37, 35)
        Me.PicShow.TabIndex = 33
        Me.PicShow.TabStop = False
        Me.PicShow.Visible = False
        '
        'dg
        '
        Me.dg.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.dg.AlternatingColors = True
        Me.dg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dg.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.dg.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
        Me.dg.Location = New System.Drawing.Point(8, 14)
        Me.dg.Name = "dg"
        Me.dg.Size = New System.Drawing.Size(583, 556)
        Me.dg.TabIndex = 29
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'GridEXPrintDocument1
        '
        Me.GridEXPrintDocument1.GridEX = Me.dg
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'FrmIso_TechnicalDoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.UiGroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmIso_TechnicalDoc"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "FrmIso_TechnicalDoc"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        CType(Me.ExplorerBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ExplorerBar1.ResumeLayout(False)
        Me.ExplorerBar1.PerformLayout()
        CType(Me.PicShow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblFilePath As System.Windows.Forms.Label
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents dg As Janus.Windows.GridEX.GridEX
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ExplorerBar1 As Janus.Windows.ExplorerBar.ExplorerBar
    Friend WithEvents lblExecute As System.Windows.Forms.Label
    Friend WithEvents PicShow As System.Windows.Forms.PictureBox
    Friend WithEvents GridEXPrintDocument1 As Janus.Windows.GridEX.GridEXPrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
End Class

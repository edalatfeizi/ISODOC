<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIsoDepartDoc
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmIsoDepartDoc))
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnShow = New DevExpress.XtraEditors.SimpleButton()
        Me.PicShow = New System.Windows.Forms.PictureBox()
        Me.btnRegister = New DevExpress.XtraEditors.SimpleButton()
        Me.lblWait = New System.Windows.Forms.Label()
        Me.LstMdep = New System.Windows.Forms.ListBox()
        Me.LstDocName = New System.Windows.Forms.ListBox()
        Me.dg = New Janus.Windows.GridEX.GridEX()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.«›“Êœ‰”‰œ»Â·Ì” ⁄·«ﬁÂÂ«ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.„‘«ÂœÂ·Ì” ⁄·«ﬁÂToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.PicShow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.ExplorerBarBackground
        Me.UiGroupBox1.Controls.Add(Me.btnCancel)
        Me.UiGroupBox1.Controls.Add(Me.btnShow)
        Me.UiGroupBox1.Controls.Add(Me.PicShow)
        Me.UiGroupBox1.Controls.Add(Me.btnRegister)
        Me.UiGroupBox1.Controls.Add(Me.lblWait)
        Me.UiGroupBox1.Controls.Add(Me.LstMdep)
        Me.UiGroupBox1.Controls.Add(Me.LstDocName)
        Me.UiGroupBox1.Controls.Add(Me.dg)
        Me.UiGroupBox1.Location = New System.Drawing.Point(-4, -6)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Size = New System.Drawing.Size(1010, 588)
        Me.UiGroupBox1.TabIndex = 0
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnCancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.btnCancel.Location = New System.Drawing.Point(48, 189)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(86, 20)
        Me.btnCancel.TabIndex = 28
        Me.btnCancel.Text = "Œ—ÊÃ"
        '
        'btnShow
        '
        Me.btnShow.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnShow.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.btnShow.Location = New System.Drawing.Point(220, 189)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(86, 20)
        Me.btnShow.TabIndex = 26
        Me.btnShow.Text = "„‘«ÂœÂ"
        Me.btnShow.ToolTip = "„‘«ÂœÂ ”‰œ"
        '
        'PicShow
        '
        Me.PicShow.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PicShow.BackColor = System.Drawing.Color.Transparent
        Me.PicShow.Image = CType(resources.GetObject("PicShow.Image"), System.Drawing.Image)
        Me.PicShow.Location = New System.Drawing.Point(83, 76)
        Me.PicShow.Name = "PicShow"
        Me.PicShow.Size = New System.Drawing.Size(34, 34)
        Me.PicShow.TabIndex = 24
        Me.PicShow.TabStop = False
        Me.PicShow.Visible = False
        '
        'btnRegister
        '
        Me.btnRegister.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnRegister.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.btnRegister.Location = New System.Drawing.Point(134, 189)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(86, 20)
        Me.btnRegister.TabIndex = 27
        Me.btnRegister.Text = "À»  Ê  ‰ŸÌ„"
        Me.btnRegister.ToolTip = "»—êÂ À»  Ê  ‰ŸÌ„"
        '
        'lblWait
        '
        Me.lblWait.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblWait.BackColor = System.Drawing.Color.Transparent
        Me.lblWait.Font = New System.Drawing.Font("Traffic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblWait.Location = New System.Drawing.Point(123, 80)
        Me.lblWait.Name = "lblWait"
        Me.lblWait.Size = New System.Drawing.Size(143, 30)
        Me.lblWait.TabIndex = 25
        Me.lblWait.Text = "·ÿ›« ﬂ„Ì ’»— ﬂ‰Ìœ..."
        Me.lblWait.Visible = False
        '
        'LstMdep
        '
        Me.LstMdep.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LstMdep.BackColor = System.Drawing.Color.AliceBlue
        Me.LstMdep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LstMdep.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LstMdep.FormattingEnabled = True
        Me.LstMdep.Location = New System.Drawing.Point(583, 16)
        Me.LstMdep.Name = "LstMdep"
        Me.LstMdep.Size = New System.Drawing.Size(205, 535)
        Me.LstMdep.TabIndex = 12
        '
        'LstDocName
        '
        Me.LstDocName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LstDocName.BackColor = System.Drawing.Color.AliceBlue
        Me.LstDocName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LstDocName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LstDocName.FormattingEnabled = True
        Me.LstDocName.Location = New System.Drawing.Point(351, 16)
        Me.LstDocName.Name = "LstDocName"
        Me.LstDocName.Size = New System.Drawing.Size(228, 184)
        Me.LstDocName.TabIndex = 11
        '
        'dg
        '
        Me.dg.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.dg.AlternatingColors = True
        Me.dg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dg.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.dg.GroupByBoxVisible = False
        Me.dg.Location = New System.Drawing.Point(10, 215)
        Me.dg.Name = "dg"
        Me.dg.RecordNavigator = True
        Me.dg.Size = New System.Drawing.Size(569, 349)
        Me.dg.TabIndex = 23
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.«›“Êœ‰”‰œ»Â·Ì” ⁄·«ﬁÂÂ«ToolStripMenuItem, Me.„‘«ÂœÂ·Ì” ⁄·«ﬁÂToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(206, 48)
        '
        '«›“Êœ‰”‰œ»Â·Ì” ⁄·«ﬁÂÂ«ToolStripMenuItem
        '
        Me.«›“Êœ‰”‰œ»Â·Ì” ⁄·«ﬁÂÂ«ToolStripMenuItem.Image = CType(resources.GetObject("«›“Êœ‰”‰œ»Â·Ì” ⁄·«ﬁÂÂ«ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.«›“Êœ‰”‰œ»Â·Ì” ⁄·«ﬁÂÂ«ToolStripMenuItem.Name = "«›“Êœ‰”‰œ»Â·Ì” ⁄·«ﬁÂÂ«ToolStripMenuItem"
        Me.«›“Êœ‰”‰œ»Â·Ì” ⁄·«ﬁÂÂ«ToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.«›“Êœ‰”‰œ»Â·Ì” ⁄·«ﬁÂÂ«ToolStripMenuItem.Text = "«›“Êœ‰ ”‰œ »Â ·Ì”  ⁄·«ﬁÂ Â«"
        '
        '„‘«ÂœÂ·Ì” ⁄·«ﬁÂToolStripMenuItem
        '
        Me.„‘«ÂœÂ·Ì” ⁄·«ﬁÂToolStripMenuItem.Image = CType(resources.GetObject("„‘«ÂœÂ·Ì” ⁄·«ﬁÂToolStripMenuItem.Image"), System.Drawing.Image)
        Me.„‘«ÂœÂ·Ì” ⁄·«ﬁÂToolStripMenuItem.Name = "„‘«ÂœÂ·Ì” ⁄·«ﬁÂToolStripMenuItem"
        Me.„‘«ÂœÂ·Ì” ⁄·«ﬁÂToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.„‘«ÂœÂ·Ì” ⁄·«ﬁÂToolStripMenuItem.Text = "„‘«ÂœÂ ·Ì”  ⁄·«ﬁÂ"
        '
        'FrmIsoDepartDoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.UiGroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmIsoDepartDoc"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "„‘«ÂœÂ «”‰«œ »Â  ›ﬂÌﬂ Ê«Õœ"
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        CType(Me.PicShow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents LstMdep As System.Windows.Forms.ListBox
    Friend WithEvents LstDocName As System.Windows.Forms.ListBox
    Friend WithEvents dg As Janus.Windows.GridEX.GridEX
    Friend WithEvents lblWait As System.Windows.Forms.Label
    Friend WithEvents PicShow As System.Windows.Forms.PictureBox
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRegister As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnShow As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents «›“Êœ‰”‰œ»Â·Ì” ⁄·«ﬁÂÂ«ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents „‘«ÂœÂ·Ì” ⁄·«ﬁÂToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class

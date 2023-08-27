<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIsoOtherDoc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmIsoOtherDoc))
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
        Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnShow = New DevExpress.XtraEditors.SimpleButton
        Me.btnSetting = New DevExpress.XtraEditors.SimpleButton
        Me.PicShow = New System.Windows.Forms.PictureBox
        Me.lblSettingPath = New System.Windows.Forms.Label
        Me.lblFilePath = New System.Windows.Forms.Label
        Me.dg = New Janus.Windows.GridEX.GridEX
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox2.SuspendLayout()
        CType(Me.PicShow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.ExplorerBarBackground
        Me.UiGroupBox1.Controls.Add(Me.UiGroupBox2)
        Me.UiGroupBox1.Controls.Add(Me.PicShow)
        Me.UiGroupBox1.Controls.Add(Me.lblSettingPath)
        Me.UiGroupBox1.Controls.Add(Me.lblFilePath)
        Me.UiGroupBox1.Controls.Add(Me.dg)
        Me.UiGroupBox1.Location = New System.Drawing.Point(-2, -10)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Size = New System.Drawing.Size(927, 583)
        Me.UiGroupBox1.TabIndex = 0
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
        '
        'UiGroupBox2
        '
        Me.UiGroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.UiGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox2.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.UiGroupBox2.Controls.Add(Me.btnCancel)
        Me.UiGroupBox2.Controls.Add(Me.btnShow)
        Me.UiGroupBox2.Controls.Add(Me.btnSetting)
        Me.UiGroupBox2.Location = New System.Drawing.Point(242, 15)
        Me.UiGroupBox2.Name = "UiGroupBox2"
        Me.UiGroupBox2.Size = New System.Drawing.Size(312, 54)
        Me.UiGroupBox2.TabIndex = 38
        Me.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
        '
        'btnCancel
        '
        Me.btnCancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.btnCancel.Location = New System.Drawing.Point(15, 18)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(78, 25)
        Me.btnCancel.TabIndex = 27
        Me.btnCancel.Text = "«‰’—«›"
        Me.btnCancel.ToolTip = "Œ—ÊÃ"
        '
        'btnShow
        '
        Me.btnShow.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.btnShow.Location = New System.Drawing.Point(224, 18)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(79, 24)
        Me.btnShow.TabIndex = 26
        Me.btnShow.Text = "„‘«ÂœÂ"
        Me.btnShow.ToolTip = "„‘«ÂœÂ ”‰œ"
        '
        'btnSetting
        '
        Me.btnSetting.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.btnSetting.Location = New System.Drawing.Point(99, 18)
        Me.btnSetting.Name = "btnSetting"
        Me.btnSetting.Size = New System.Drawing.Size(119, 25)
        Me.btnSetting.TabIndex = 30
        Me.btnSetting.Text = "»—êÂ À»  Ê  ‰ŸÌ„"
        Me.btnSetting.ToolTip = "„‘«ÂœÂ »—êÂ À»  Ê  ‰ŸÌ„"
        '
        'PicShow
        '
        Me.PicShow.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PicShow.BackColor = System.Drawing.Color.Transparent
        Me.PicShow.Image = CType(resources.GetObject("PicShow.Image"), System.Drawing.Image)
        Me.PicShow.Location = New System.Drawing.Point(560, 27)
        Me.PicShow.Name = "PicShow"
        Me.PicShow.Size = New System.Drawing.Size(37, 35)
        Me.PicShow.TabIndex = 37
        Me.PicShow.TabStop = False
        Me.PicShow.Visible = False
        '
        'lblSettingPath
        '
        Me.lblSettingPath.Location = New System.Drawing.Point(674, 17)
        Me.lblSettingPath.Name = "lblSettingPath"
        Me.lblSettingPath.Size = New System.Drawing.Size(101, 15)
        Me.lblSettingPath.TabIndex = 36
        Me.lblSettingPath.Text = "lblSettingPath"
        Me.lblSettingPath.Visible = False
        '
        'lblFilePath
        '
        Me.lblFilePath.Location = New System.Drawing.Point(662, 47)
        Me.lblFilePath.Name = "lblFilePath"
        Me.lblFilePath.Size = New System.Drawing.Size(101, 15)
        Me.lblFilePath.TabIndex = 35
        Me.lblFilePath.Text = "lblFilePath"
        Me.lblFilePath.Visible = False
        '
        'dg
        '
        Me.dg.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.dg.AlternatingColors = True
        Me.dg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dg.BackgroundImageDrawMode = Janus.Windows.GridEX.BackgroundImageDrawMode.None
        Me.dg.ColumnSetNavigation = Janus.Windows.GridEX.ColumnSetNavigation.ColumnSet
        Me.dg.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.dg.FilterRowFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.dg.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.dg.Location = New System.Drawing.Point(14, 79)
        Me.dg.Name = "dg"
        Me.dg.Size = New System.Drawing.Size(768, 485)
        Me.dg.TabIndex = 33
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'FrmIsoOtherDoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.UiGroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmIsoOtherDoc"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox2.ResumeLayout(False)
        CType(Me.PicShow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents dg As Janus.Windows.GridEX.GridEX
    Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnShow As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSetting As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PicShow As System.Windows.Forms.PictureBox
    Friend WithEvents lblSettingPath As System.Windows.Forms.Label
    Friend WithEvents lblFilePath As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class

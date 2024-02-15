<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIsoDocShow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmIsoDocShow))
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnShow = New DevExpress.XtraEditors.SimpleButton()
        Me.PicShow = New System.Windows.Forms.PictureBox()
        Me.dg = New Janus.Windows.GridEX.GridEX()
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
        Me.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.ExplorerBarGroupBackground
        Me.UiGroupBox1.Controls.Add(Me.UiGroupBox2)
        Me.UiGroupBox1.Controls.Add(Me.PicShow)
        Me.UiGroupBox1.Controls.Add(Me.dg)
        Me.UiGroupBox1.Location = New System.Drawing.Point(-2, -13)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Size = New System.Drawing.Size(660, 334)
        Me.UiGroupBox1.TabIndex = 25
        Me.UiGroupBox1.Tag = "-1"
        '
        'UiGroupBox2
        '
        Me.UiGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox2.BorderColor = System.Drawing.Color.DarkBlue
        Me.UiGroupBox2.Controls.Add(Me.btnCancel)
        Me.UiGroupBox2.Controls.Add(Me.btnShow)
        Me.UiGroupBox2.Location = New System.Drawing.Point(250, 25)
        Me.UiGroupBox2.Name = "UiGroupBox2"
        Me.UiGroupBox2.Size = New System.Drawing.Size(187, 54)
        Me.UiGroupBox2.TabIndex = 36
        Me.UiGroupBox2.Tag = "-1"
        Me.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
        '
        'btnCancel
        '
        Me.btnCancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.btnCancel.Location = New System.Drawing.Point(12, 18)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(78, 25)
        Me.btnCancel.TabIndex = 27
        Me.btnCancel.Tag = "-1"
        Me.btnCancel.Text = "«‰’—«›"
        Me.btnCancel.ToolTip = "Œ—ÊÃ"
        '
        'btnShow
        '
        Me.btnShow.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.btnShow.Location = New System.Drawing.Point(96, 18)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(79, 24)
        Me.btnShow.TabIndex = 26
        Me.btnShow.Tag = "-1"
        Me.btnShow.Text = "„‘«ÂœÂ"
        Me.btnShow.ToolTip = "„‘«ÂœÂ ”‰œ"
        '
        'PicShow
        '
        Me.PicShow.BackColor = System.Drawing.Color.Transparent
        Me.PicShow.Image = CType(resources.GetObject("PicShow.Image"), System.Drawing.Image)
        Me.PicShow.Location = New System.Drawing.Point(443, 37)
        Me.PicShow.Name = "PicShow"
        Me.PicShow.Size = New System.Drawing.Size(37, 35)
        Me.PicShow.TabIndex = 35
        Me.PicShow.TabStop = False
        Me.PicShow.Tag = "-1"
        Me.PicShow.Visible = False
        '
        'dg
        '
        Me.dg.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.dg.AlternatingColors = True
        Me.dg.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.dg.GroupByBoxVisible = False
        Me.dg.Location = New System.Drawing.Point(14, 85)
        Me.dg.Name = "dg"
        Me.dg.Size = New System.Drawing.Size(629, 232)
        Me.dg.TabIndex = 0
        Me.dg.Tag = "-1"
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        Me.Timer1.Tag = "-1"
        '
        'FrmIsoDocShow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 316)
        Me.Controls.Add(Me.UiGroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmIsoDocShow"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnShow As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PicShow As System.Windows.Forms.PictureBox
End Class

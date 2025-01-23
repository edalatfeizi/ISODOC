<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMasterReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMasterReport))
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.IkidFormToolbar1 = New WLFormGlobalCtrl_DT.IKIDFormToolbar()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.dgdShowInfo = New System.Windows.Forms.DataGrid()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnShow = New DevExpress.XtraEditors.SimpleButton()
        Me.DgSelectDoc = New IKIDUtility.DgSelect()
        Me.dgdMDepart = New System.Windows.Forms.DataGrid()
        Me.dgdDocName = New System.Windows.Forms.DataGrid()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.dgdShowInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgdMDepart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgdDocName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.ExplorerBarBackground
        Me.UiGroupBox1.Controls.Add(Me.IkidFormToolbar1)
        Me.UiGroupBox1.Controls.Add(Me.SimpleButton1)
        Me.UiGroupBox1.Controls.Add(Me.dgdShowInfo)
        Me.UiGroupBox1.Controls.Add(Me.btnCancel)
        Me.UiGroupBox1.Controls.Add(Me.btnShow)
        Me.UiGroupBox1.Controls.Add(Me.DgSelectDoc)
        Me.UiGroupBox1.Controls.Add(Me.dgdMDepart)
        Me.UiGroupBox1.Controls.Add(Me.dgdDocName)
        Me.UiGroupBox1.Location = New System.Drawing.Point(-9, -19)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Size = New System.Drawing.Size(800, 600)
        Me.UiGroupBox1.TabIndex = 0
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
        '
        'IkidFormToolbar1
        '
        Me.IkidFormToolbar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.IkidFormToolbar1.Location = New System.Drawing.Point(12, 21)
        Me.IkidFormToolbar1.Name = "IkidFormToolbar1"
        Me.IkidFormToolbar1.Size = New System.Drawing.Size(200, 24)
        Me.IkidFormToolbar1.TabIndex = 34
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(378, 23)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(68, 19)
        Me.SimpleButton1.TabIndex = 33
        Me.SimpleButton1.Text = "‰„«Ì‘ "
        '
        'dgdShowInfo
        '
        Me.dgdShowInfo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgdShowInfo.DataMember = ""
        Me.dgdShowInfo.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgdShowInfo.Location = New System.Drawing.Point(11, 45)
        Me.dgdShowInfo.Name = "dgdShowInfo"
        Me.dgdShowInfo.ReadOnly = True
        Me.dgdShowInfo.Size = New System.Drawing.Size(521, 526)
        Me.dgdShowInfo.TabIndex = 32
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnCancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.btnCancel.ImageOptions.Image = CType(resources.GetObject("btnCancel.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(238, 23)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(68, 19)
        Me.btnCancel.TabIndex = 31
        Me.btnCancel.Text = "Œ—ÊÃ"
        '
        'btnShow
        '
        Me.btnShow.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnShow.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.btnShow.ImageOptions.Image = CType(resources.GetObject("btnShow.ImageOptions.Image"), System.Drawing.Image)
        Me.btnShow.Location = New System.Drawing.Point(308, 23)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(68, 19)
        Me.btnShow.TabIndex = 30
        Me.btnShow.Text = "ç«Å"
        '
        'DgSelectDoc
        '
        Me.DgSelectDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgSelectDoc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.DgSelectDoc.Location = New System.Drawing.Point(608, 23)
        Me.DgSelectDoc.Name = "DgSelectDoc"
        Me.DgSelectDoc.Size = New System.Drawing.Size(175, 22)
        Me.DgSelectDoc.TabIndex = 3
        '
        'dgdMDepart
        '
        Me.dgdMDepart.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgdMDepart.DataMember = ""
        Me.dgdMDepart.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgdMDepart.Location = New System.Drawing.Point(538, 304)
        Me.dgdMDepart.Name = "dgdMDepart"
        Me.dgdMDepart.Size = New System.Drawing.Size(246, 267)
        Me.dgdMDepart.TabIndex = 1
        '
        'dgdDocName
        '
        Me.dgdDocName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgdDocName.DataMember = ""
        Me.dgdDocName.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgdDocName.Location = New System.Drawing.Point(538, 45)
        Me.dgdDocName.Name = "dgdDocName"
        Me.dgdDocName.Size = New System.Drawing.Size(247, 253)
        Me.dgdDocName.TabIndex = 0
        '
        'FrmMasterReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 564)
        Me.Controls.Add(Me.UiGroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMasterReport"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        CType(Me.dgdShowInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgdMDepart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgdDocName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents dgdMDepart As System.Windows.Forms.DataGrid
    Friend WithEvents dgdDocName As System.Windows.Forms.DataGrid
    Friend WithEvents DgSelectDoc As IKIDUtility.DgSelect
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnShow As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgdShowInfo As System.Windows.Forms.DataGrid
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents IkidFormToolbar1 As WLFormGlobalCtrl_DT.IKIDFormToolbar
End Class

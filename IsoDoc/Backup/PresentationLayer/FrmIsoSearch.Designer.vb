<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIsoSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmIsoSearch))
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
        Me.UiGroupBox3 = New Janus.Windows.EditControls.UIGroupBox
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton
        Me.lblFilePath = New System.Windows.Forms.Label
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.btnShow = New DevExpress.XtraEditors.SimpleButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.IkidFormToolbar1 = New WLFormGlobalCtrl_DT.IKIDFormToolbar
        Me.dgdSearch = New System.Windows.Forms.DataGrid
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox3.SuspendLayout()
        CType(Me.dgdSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.ExplorerBarBackground
        Me.UiGroupBox1.Controls.Add(Me.UiGroupBox3)
        Me.UiGroupBox1.Controls.Add(Me.IkidFormToolbar1)
        Me.UiGroupBox1.Controls.Add(Me.dgdSearch)
        Me.UiGroupBox1.Location = New System.Drawing.Point(-4, -12)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Size = New System.Drawing.Size(1040, 747)
        Me.UiGroupBox1.TabIndex = 0
        Me.UiGroupBox1.Text = "UiGroupBox1"
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
        '
        'UiGroupBox3
        '
        Me.UiGroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.UiGroupBox3.Controls.Add(Me.btnSearch)
        Me.UiGroupBox3.Controls.Add(Me.btnCancel)
        Me.UiGroupBox3.Controls.Add(Me.lblFilePath)
        Me.UiGroupBox3.Controls.Add(Me.txtSearch)
        Me.UiGroupBox3.Controls.Add(Me.btnShow)
        Me.UiGroupBox3.Controls.Add(Me.Label1)
        Me.UiGroupBox3.Location = New System.Drawing.Point(20, 17)
        Me.UiGroupBox3.Name = "UiGroupBox3"
        Me.UiGroupBox3.Size = New System.Drawing.Size(764, 73)
        Me.UiGroupBox3.TabIndex = 36
        '
        'btnSearch
        '
        Me.btnSearch.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.btnSearch.Location = New System.Drawing.Point(167, 18)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(77, 22)
        Me.btnSearch.TabIndex = 36
        Me.btnSearch.Text = "Ã”  Ê ÃÊÌ"
        '
        'btnCancel
        '
        Me.btnCancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.btnCancel.Location = New System.Drawing.Point(310, 46)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(68, 22)
        Me.btnCancel.TabIndex = 29
        Me.btnCancel.Text = "Œ—ÊÃ"
        '
        'lblFilePath
        '
        Me.lblFilePath.Location = New System.Drawing.Point(33, 21)
        Me.lblFilePath.Name = "lblFilePath"
        Me.lblFilePath.Size = New System.Drawing.Size(122, 28)
        Me.lblFilePath.TabIndex = 35
        Me.lblFilePath.Text = "lblFilePath"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(248, 18)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(367, 21)
        Me.txtSearch.TabIndex = 33
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnShow
        '
        Me.btnShow.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.btnShow.Location = New System.Drawing.Point(381, 46)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(68, 22)
        Me.btnShow.TabIndex = 28
        Me.btnShow.Text = "„‘«ÂœÂ"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(624, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 20)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "⁄»«—  „Ê—œ Ã”  ÊÃÊÌ"
        '
        'IkidFormToolbar1
        '
        Me.IkidFormToolbar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.IkidFormToolbar1.Location = New System.Drawing.Point(19, 94)
        Me.IkidFormToolbar1.Name = "IkidFormToolbar1"
        Me.IkidFormToolbar1.Size = New System.Drawing.Size(272, 22)
        Me.IkidFormToolbar1.TabIndex = 31
        '
        'dgdSearch
        '
        Me.dgdSearch.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgdSearch.DataMember = ""
        Me.dgdSearch.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.dgdSearch.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgdSearch.Location = New System.Drawing.Point(17, 119)
        Me.dgdSearch.Name = "dgdSearch"
        Me.dgdSearch.ReadOnly = True
        Me.dgdSearch.Size = New System.Drawing.Size(767, 447)
        Me.dgdSearch.TabIndex = 6
        '
        'FrmIsoSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.UiGroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmIsoSearch"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "Ã”  Ê ÃÊÌ"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox3.ResumeLayout(False)
        Me.UiGroupBox3.PerformLayout()
        CType(Me.dgdSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents dgdSearch As System.Windows.Forms.DataGrid
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnShow As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents IkidFormToolbar1 As WLFormGlobalCtrl_DT.IKIDFormToolbar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblFilePath As System.Windows.Forms.Label
    Friend WithEvents UiGroupBox3 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIsoHistoryShow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmIsoHistoryShow))
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
        Me.UiGroupBox3 = New Janus.Windows.EditControls.UIGroupBox
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnShow = New DevExpress.XtraEditors.SimpleButton
        Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox
        Me.ChkAllDoc = New System.Windows.Forms.CheckBox
        Me.cmbDocName = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.IkidFormToolbar1 = New WLFormGlobalCtrl_DT.IKIDFormToolbar
        Me.dgdHistory = New System.Windows.Forms.DataGrid
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox3.SuspendLayout()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox2.SuspendLayout()
        CType(Me.dgdHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.ExplorerBarBackground
        Me.UiGroupBox1.Controls.Add(Me.UiGroupBox3)
        Me.UiGroupBox1.Controls.Add(Me.UiGroupBox2)
        Me.UiGroupBox1.Controls.Add(Me.IkidFormToolbar1)
        Me.UiGroupBox1.Controls.Add(Me.dgdHistory)
        Me.UiGroupBox1.Location = New System.Drawing.Point(-8, -9)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Size = New System.Drawing.Size(1027, 745)
        Me.UiGroupBox1.TabIndex = 0
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
        '
        'UiGroupBox3
        '
        Me.UiGroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.UiGroupBox3.Controls.Add(Me.btnCancel)
        Me.UiGroupBox3.Controls.Add(Me.btnShow)
        Me.UiGroupBox3.Location = New System.Drawing.Point(434, 81)
        Me.UiGroupBox3.Name = "UiGroupBox3"
        Me.UiGroupBox3.Size = New System.Drawing.Size(159, 41)
        Me.UiGroupBox3.TabIndex = 31
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(8, 14)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(68, 22)
        Me.btnCancel.TabIndex = 29
        Me.btnCancel.Text = "«‰’—«›"
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(82, 14)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(68, 22)
        Me.btnShow.TabIndex = 28
        Me.btnShow.Text = "„‘«ÂœÂ"
        '
        'UiGroupBox2
        '
        Me.UiGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox2.BorderColor = System.Drawing.Color.Yellow
        Me.UiGroupBox2.Controls.Add(Me.ChkAllDoc)
        Me.UiGroupBox2.Controls.Add(Me.cmbDocName)
        Me.UiGroupBox2.Controls.Add(Me.Label1)
        Me.UiGroupBox2.Location = New System.Drawing.Point(21, 15)
        Me.UiGroupBox2.Name = "UiGroupBox2"
        Me.UiGroupBox2.Size = New System.Drawing.Size(983, 64)
        Me.UiGroupBox2.TabIndex = 22
        Me.UiGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
        '
        'ChkAllDoc
        '
        Me.ChkAllDoc.AutoSize = True
        Me.ChkAllDoc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ChkAllDoc.Location = New System.Drawing.Point(656, 26)
        Me.ChkAllDoc.Name = "ChkAllDoc"
        Me.ChkAllDoc.Size = New System.Drawing.Size(73, 17)
        Me.ChkAllDoc.TabIndex = 22
        Me.ChkAllDoc.Text = "Â„Â „Ê«—œ"
        Me.ChkAllDoc.UseVisualStyleBackColor = True
        '
        'cmbDocName
        '
        Me.cmbDocName.FormattingEnabled = True
        Me.cmbDocName.Location = New System.Drawing.Point(746, 23)
        Me.cmbDocName.Name = "cmbDocName"
        Me.cmbDocName.Size = New System.Drawing.Size(172, 21)
        Me.cmbDocName.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(912, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 21)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "‰«„ ”‰œ"
        '
        'IkidFormToolbar1
        '
        Me.IkidFormToolbar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.IkidFormToolbar1.Location = New System.Drawing.Point(20, 106)
        Me.IkidFormToolbar1.Name = "IkidFormToolbar1"
        Me.IkidFormToolbar1.Size = New System.Drawing.Size(249, 24)
        Me.IkidFormToolbar1.TabIndex = 19
        '
        'dgdHistory
        '
        Me.dgdHistory.DataMember = ""
        Me.dgdHistory.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgdHistory.Location = New System.Drawing.Point(20, 130)
        Me.dgdHistory.Name = "dgdHistory"
        Me.dgdHistory.ReadOnly = True
        Me.dgdHistory.Size = New System.Drawing.Size(988, 587)
        Me.dgdHistory.TabIndex = 18
        '
        'FrmIsoHistoryShow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 734)
        Me.Controls.Add(Me.UiGroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmIsoHistoryShow"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "«”‰«œ »«Ìê«‰Ì ‘œÂ"
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox3.ResumeLayout(False)
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox2.ResumeLayout(False)
        Me.UiGroupBox2.PerformLayout()
        CType(Me.dgdHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents IkidFormToolbar1 As WLFormGlobalCtrl_DT.IKIDFormToolbar
    Friend WithEvents dgdHistory As System.Windows.Forms.DataGrid
    Friend WithEvents cmbDocName As System.Windows.Forms.ComboBox
    Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ChkAllDoc As System.Windows.Forms.CheckBox
    Friend WithEvents UiGroupBox3 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnShow As DevExpress.XtraEditors.SimpleButton
End Class

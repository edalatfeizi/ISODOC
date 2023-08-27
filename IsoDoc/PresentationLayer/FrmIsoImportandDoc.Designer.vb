<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIsoImportandDoc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmIsoImportandDoc))
        Me.dgdimportand = New System.Windows.Forms.DataGrid
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
        Me.Label138 = New System.Windows.Forms.Label
        Me.cmbDocType = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtDocCode = New System.Windows.Forms.TextBox
        Me.btnShow = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.txtFilePath = New System.Windows.Forms.TextBox
        Me.lblFilePath = New System.Windows.Forms.Label
        Me.txtDocName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.UiGroupBox8 = New Janus.Windows.EditControls.UIGroupBox
        Me.btnEdit = New System.Windows.Forms.Button
        Me.btnIns = New System.Windows.Forms.Button
        Me.btnDel = New System.Windows.Forms.Button
        Me.FontDialog1 = New System.Windows.Forms.FontDialog
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.IkidFormToolbar1 = New WLFormGlobalCtrl_DT.IKIDFormToolbar
        Me.UiGroupBox52 = New Janus.Windows.EditControls.UIGroupBox
        Me.btnConvertTobinary = New System.Windows.Forms.Button
        CType(Me.dgdimportand, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.UiGroupBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox8.SuspendLayout()
        CType(Me.UiGroupBox52, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox52.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgdimportand
        '
        Me.dgdimportand.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgdimportand.DataMember = ""
        Me.dgdimportand.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgdimportand.Location = New System.Drawing.Point(12, 168)
        Me.dgdimportand.Name = "dgdimportand"
        Me.dgdimportand.ReadOnly = True
        Me.dgdimportand.Size = New System.Drawing.Size(921, 401)
        Me.dgdimportand.TabIndex = 0
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.BorderColor = System.Drawing.Color.Yellow
        Me.UiGroupBox1.Controls.Add(Me.Label138)
        Me.UiGroupBox1.Controls.Add(Me.cmbDocType)
        Me.UiGroupBox1.Controls.Add(Me.Label2)
        Me.UiGroupBox1.Controls.Add(Me.txtDocCode)
        Me.UiGroupBox1.Controls.Add(Me.btnShow)
        Me.UiGroupBox1.Controls.Add(Me.btnAdd)
        Me.UiGroupBox1.Controls.Add(Me.txtFilePath)
        Me.UiGroupBox1.Controls.Add(Me.lblFilePath)
        Me.UiGroupBox1.Controls.Add(Me.txtDocName)
        Me.UiGroupBox1.Controls.Add(Me.Label1)
        Me.UiGroupBox1.Location = New System.Drawing.Point(12, 8)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Size = New System.Drawing.Size(894, 112)
        Me.UiGroupBox1.TabIndex = 1
        '
        'Label138
        '
        Me.Label138.AutoSize = True
        Me.Label138.BackColor = System.Drawing.Color.Transparent
        Me.Label138.ForeColor = System.Drawing.Color.Black
        Me.Label138.Location = New System.Drawing.Point(738, 83)
        Me.Label138.Name = "Label138"
        Me.Label138.Size = New System.Drawing.Size(46, 13)
        Me.Label138.TabIndex = 78
        Me.Label138.Tag = "-1"
        Me.Label138.Text = "‰Ê⁄ ”‰œ"
        '
        'cmbDocType
        '
        Me.cmbDocType.FormattingEnabled = True
        Me.cmbDocType.Location = New System.Drawing.Point(552, 80)
        Me.cmbDocType.Name = "cmbDocType"
        Me.cmbDocType.Size = New System.Drawing.Size(166, 21)
        Me.cmbDocType.TabIndex = 77
        Me.cmbDocType.Tag = "-1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(166, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "ﬂœ ”‰œ"
        '
        'txtDocCode
        '
        Me.txtDocCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDocCode.Location = New System.Drawing.Point(45, 15)
        Me.txtDocCode.Name = "txtDocCode"
        Me.txtDocCode.Size = New System.Drawing.Size(106, 21)
        Me.txtDocCode.TabIndex = 75
        Me.txtDocCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnShow
        '
        Me.btnShow.ForeColor = System.Drawing.Color.Black
        Me.btnShow.Location = New System.Drawing.Point(105, 52)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(72, 23)
        Me.btnShow.TabIndex = 73
        Me.btnShow.Tag = "-1"
        Me.btnShow.Text = "„‘«ÂœÂ"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Location = New System.Drawing.Point(183, 53)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(31, 20)
        Me.btnAdd.TabIndex = 71
        Me.btnAdd.Tag = "-1"
        Me.btnAdd.Text = "..."
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtFilePath
        '
        Me.txtFilePath.Location = New System.Drawing.Point(221, 52)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.Size = New System.Drawing.Size(497, 21)
        Me.txtFilePath.TabIndex = 72
        Me.txtFilePath.Tag = "-1"
        Me.txtFilePath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFilePath
        '
        Me.lblFilePath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFilePath.AutoSize = True
        Me.lblFilePath.ForeColor = System.Drawing.Color.Black
        Me.lblFilePath.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFilePath.Location = New System.Drawing.Point(738, 55)
        Me.lblFilePath.Name = "lblFilePath"
        Me.lblFilePath.Size = New System.Drawing.Size(155, 13)
        Me.lblFilePath.TabIndex = 74
        Me.lblFilePath.Tag = "-1"
        Me.lblFilePath.Text = " „”Ì— ›«Ì· «’·Ì »— —ÊÌ ‘»ﬂÂ "
        '
        'txtDocName
        '
        Me.txtDocName.Location = New System.Drawing.Point(221, 15)
        Me.txtDocName.Name = "txtDocName"
        Me.txtDocName.Size = New System.Drawing.Size(497, 21)
        Me.txtDocName.TabIndex = 68
        Me.txtDocName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(738, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "‰«„ ”‰œ"
        '
        'UiGroupBox8
        '
        Me.UiGroupBox8.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox8.Controls.Add(Me.btnEdit)
        Me.UiGroupBox8.Controls.Add(Me.btnIns)
        Me.UiGroupBox8.Controls.Add(Me.btnDel)
        Me.UiGroupBox8.Location = New System.Drawing.Point(397, 115)
        Me.UiGroupBox8.Name = "UiGroupBox8"
        Me.UiGroupBox8.Size = New System.Drawing.Size(146, 51)
        Me.UiGroupBox8.TabIndex = 17
        Me.UiGroupBox8.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
        '
        'btnEdit
        '
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnEdit.Location = New System.Drawing.Point(52, 11)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(42, 37)
        Me.btnEdit.TabIndex = 2
        Me.btnEdit.Tag = "-1"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnIns
        '
        Me.btnIns.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnIns.Image = CType(resources.GetObject("btnIns.Image"), System.Drawing.Image)
        Me.btnIns.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnIns.Location = New System.Drawing.Point(97, 11)
        Me.btnIns.Name = "btnIns"
        Me.btnIns.Size = New System.Drawing.Size(42, 37)
        Me.btnIns.TabIndex = 15
        Me.btnIns.Tag = "-1"
        Me.btnIns.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnDel.Image = CType(resources.GetObject("btnDel.Image"), System.Drawing.Image)
        Me.btnDel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnDel.Location = New System.Drawing.Point(6, 11)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(42, 37)
        Me.btnDel.TabIndex = 0
        Me.btnDel.Tag = "-1"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'IkidFormToolbar1
        '
        Me.IkidFormToolbar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IkidFormToolbar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.IkidFormToolbar1.Location = New System.Drawing.Point(13, 145)
        Me.IkidFormToolbar1.Name = "IkidFormToolbar1"
        Me.IkidFormToolbar1.Size = New System.Drawing.Size(224, 24)
        Me.IkidFormToolbar1.TabIndex = 19
        '
        'UiGroupBox52
        '
        Me.UiGroupBox52.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox52.Controls.Add(Me.btnConvertTobinary)
        Me.UiGroupBox52.ForeColor = System.Drawing.Color.Red
        Me.UiGroupBox52.Location = New System.Drawing.Point(673, 118)
        Me.UiGroupBox52.Name = "UiGroupBox52"
        Me.UiGroupBox52.Size = New System.Drawing.Size(175, 51)
        Me.UiGroupBox52.TabIndex = 20
        Me.UiGroupBox52.Tag = "-1"
        Me.UiGroupBox52.Text = "Convert Document To Binary"
        Me.UiGroupBox52.TextAlignment = Janus.Windows.EditControls.TextAlignment.Center
        Me.UiGroupBox52.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
        '
        'btnConvertTobinary
        '
        Me.btnConvertTobinary.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btnConvertTobinary.Image = CType(resources.GetObject("btnConvertTobinary.Image"), System.Drawing.Image)
        Me.btnConvertTobinary.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnConvertTobinary.Location = New System.Drawing.Point(74, 11)
        Me.btnConvertTobinary.Name = "btnConvertTobinary"
        Me.btnConvertTobinary.Size = New System.Drawing.Size(42, 37)
        Me.btnConvertTobinary.TabIndex = 15
        Me.btnConvertTobinary.Tag = "629"
        Me.btnConvertTobinary.UseVisualStyleBackColor = True
        '
        'FrmIsoImportandDoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(945, 581)
        Me.Controls.Add(Me.UiGroupBox1)
        Me.Controls.Add(Me.UiGroupBox52)
        Me.Controls.Add(Me.IkidFormToolbar1)
        Me.Controls.Add(Me.UiGroupBox8)
        Me.Controls.Add(Me.dgdimportand)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmIsoImportandDoc"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgdimportand, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.UiGroupBox1.PerformLayout()
        CType(Me.UiGroupBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox8.ResumeLayout(False)
        CType(Me.UiGroupBox52, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox52.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgdimportand As System.Windows.Forms.DataGrid
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents UiGroupBox8 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnIns As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents txtDocName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtFilePath As System.Windows.Forms.TextBox
    Friend WithEvents lblFilePath As System.Windows.Forms.Label
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDocCode As System.Windows.Forms.TextBox
    Friend WithEvents IkidFormToolbar1 As WLFormGlobalCtrl_DT.IKIDFormToolbar
    Friend WithEvents Label138 As System.Windows.Forms.Label
    Friend WithEvents cmbDocType As System.Windows.Forms.ComboBox
    Friend WithEvents UiGroupBox52 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnConvertTobinary As System.Windows.Forms.Button
End Class

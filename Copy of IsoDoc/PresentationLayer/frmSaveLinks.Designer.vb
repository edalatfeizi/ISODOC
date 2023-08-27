<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaveLinks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSaveLinks))
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
        Me.btnBinary = New Janus.Windows.EditControls.UIButton
        Me.btnUp = New Janus.Windows.EditControls.UIButton
        Me.btnDel = New Janus.Windows.EditControls.UIButton
        Me.btnSave = New Janus.Windows.EditControls.UIButton
        Me.UiGroupBox3 = New Janus.Windows.EditControls.UIGroupBox
        Me.grdLinks = New Janus.Windows.GridEX.GridEX
        Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox
        Me.txtSearch = New System.Windows.Forms.MaskedTextBox
        Me.btnLink = New Janus.Windows.EditControls.UIButton
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbDocs = New System.Windows.Forms.ComboBox
        Me.txtTitle = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Label4 = New System.Windows.Forms.Label
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox3.SuspendLayout()
        CType(Me.grdLinks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.ExplorerBarBackground
        Me.UiGroupBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.UiGroupBox1.Controls.Add(Me.btnBinary)
        Me.UiGroupBox1.Controls.Add(Me.btnUp)
        Me.UiGroupBox1.Controls.Add(Me.btnDel)
        Me.UiGroupBox1.Controls.Add(Me.btnSave)
        Me.UiGroupBox1.Controls.Add(Me.UiGroupBox3)
        Me.UiGroupBox1.Controls.Add(Me.UiGroupBox2)
        Me.UiGroupBox1.Location = New System.Drawing.Point(1, -5)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Size = New System.Drawing.Size(885, 430)
        Me.UiGroupBox1.TabIndex = 0
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
        '
        'btnBinary
        '
        Me.btnBinary.Icon = CType(resources.GetObject("btnBinary.Icon"), System.Drawing.Icon)
        Me.btnBinary.Location = New System.Drawing.Point(256, 102)
        Me.btnBinary.Name = "btnBinary"
        Me.btnBinary.Size = New System.Drawing.Size(57, 23)
        Me.btnBinary.TabIndex = 3
        Me.btnBinary.Text = "Binary"
        Me.btnBinary.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'btnUp
        '
        Me.btnUp.Icon = CType(resources.GetObject("btnUp.Icon"), System.Drawing.Icon)
        Me.btnUp.Location = New System.Drawing.Point(447, 102)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(75, 23)
        Me.btnUp.TabIndex = 1
        Me.btnUp.TabStop = False
        Me.btnUp.Text = "ÊÌ—«Ì‘"
        Me.btnUp.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'btnDel
        '
        Me.btnDel.Icon = CType(resources.GetObject("btnDel.Icon"), System.Drawing.Icon)
        Me.btnDel.Location = New System.Drawing.Point(348, 102)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(75, 23)
        Me.btnDel.TabIndex = 2
        Me.btnDel.TabStop = False
        Me.btnDel.Text = "Õ–›"
        Me.btnDel.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'btnSave
        '
        Me.btnSave.Icon = CType(resources.GetObject("btnSave.Icon"), System.Drawing.Icon)
        Me.btnSave.Location = New System.Drawing.Point(551, 102)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 0
        Me.btnSave.TabStop = False
        Me.btnSave.Text = "œ—Ã"
        Me.btnSave.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'UiGroupBox3
        '
        Me.UiGroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UiGroupBox3.Controls.Add(Me.grdLinks)
        Me.UiGroupBox3.Location = New System.Drawing.Point(3, 124)
        Me.UiGroupBox3.Name = "UiGroupBox3"
        Me.UiGroupBox3.Size = New System.Drawing.Size(879, 303)
        Me.UiGroupBox3.TabIndex = 1
        Me.UiGroupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
        '
        'grdLinks
        '
        Me.grdLinks.Location = New System.Drawing.Point(4, 10)
        Me.grdLinks.Name = "grdLinks"
        Me.grdLinks.Size = New System.Drawing.Size(872, 290)
        Me.grdLinks.TabIndex = 0
        '
        'UiGroupBox2
        '
        Me.UiGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.UiGroupBox2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UiGroupBox2.Controls.Add(Me.Label4)
        Me.UiGroupBox2.Controls.Add(Me.txtSearch)
        Me.UiGroupBox2.Controls.Add(Me.btnLink)
        Me.UiGroupBox2.Controls.Add(Me.txtAddress)
        Me.UiGroupBox2.Controls.Add(Me.Label3)
        Me.UiGroupBox2.Controls.Add(Me.cmbDocs)
        Me.UiGroupBox2.Controls.Add(Me.txtTitle)
        Me.UiGroupBox2.Controls.Add(Me.Label2)
        Me.UiGroupBox2.Controls.Add(Me.Label1)
        Me.UiGroupBox2.Location = New System.Drawing.Point(3, 6)
        Me.UiGroupBox2.Name = "UiGroupBox2"
        Me.UiGroupBox2.Size = New System.Drawing.Size(879, 90)
        Me.UiGroupBox2.TabIndex = 0
        Me.UiGroupBox2.TextAlignment = Janus.Windows.EditControls.TextAlignment.Center
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(625, 11)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(182, 21)
        Me.txtSearch.TabIndex = 0
        '
        'btnLink
        '
        Me.btnLink.Icon = CType(resources.GetObject("btnLink.Icon"), System.Drawing.Icon)
        Me.btnLink.Location = New System.Drawing.Point(90, 62)
        Me.btnLink.Name = "btnLink"
        Me.btnLink.Size = New System.Drawing.Size(57, 23)
        Me.btnLink.TabIndex = 4
        Me.btnLink.Text = "Link"
        Me.btnLink.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(153, 64)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(655, 21)
        Me.txtAddress.TabIndex = 3
        Me.txtAddress.Text = "-"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(807, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "„”Ì— ·Ì‰ﬂ :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbDocs
        '
        Me.cmbDocs.FormattingEnabled = True
        Me.cmbDocs.Location = New System.Drawing.Point(90, 12)
        Me.cmbDocs.Name = "cmbDocs"
        Me.cmbDocs.Size = New System.Drawing.Size(470, 21)
        Me.cmbDocs.TabIndex = 1
        Me.cmbDocs.TabStop = False
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(626, 37)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(181, 21)
        Me.txtTitle.TabIndex = 2
        Me.txtTitle.Text = "-"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(807, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "⁄‰Ê«‰ ·Ì‰ﬂ :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(560, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "‰«„ ”‰œ :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(807, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 22)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "òœ ”‰œ :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmSaveLinks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(887, 426)
        Me.Controls.Add(Me.UiGroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSaveLinks"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "À»  ·Ì‰ﬂ Â«"
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox3.ResumeLayout(False)
        CType(Me.grdLinks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox2.ResumeLayout(False)
        Me.UiGroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents UiGroupBox3 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents grdLinks As Janus.Windows.GridEX.GridEX
    Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents btnUp As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnDel As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnSave As Janus.Windows.EditControls.UIButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents cmbDocs As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnLink As Janus.Windows.EditControls.UIButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnBinary As Janus.Windows.EditControls.UIButton
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtSearch As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class

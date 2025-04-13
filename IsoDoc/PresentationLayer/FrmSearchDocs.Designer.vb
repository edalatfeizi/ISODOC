<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSearchDocs
    Inherits DevExpress.XtraEditors.XtraForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSearchDocs))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton()
        Me.txtSearch = New DevExpress.XtraEditors.TextEdit()
        Me.panelShowDoc = New DevExpress.XtraEditors.PanelControl()
        Me.btnShowDoc = New DevExpress.XtraEditors.SimpleButton()
        Me.grdSearchResult = New DevExpress.XtraGrid.GridControl()
        Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelShowDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelShowDoc.SuspendLayout()
        CType(Me.grdSearchResult, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnSearch)
        Me.PanelControl1.Controls.Add(Me.txtSearch)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1106, 93)
        Me.PanelControl1.TabIndex = 12
        '
        'btnSearch
        '
        Me.btnSearch.Appearance.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSearch.Appearance.Font = New System.Drawing.Font("Vazirmatn", 10.0!)
        Me.btnSearch.Appearance.Options.UseBackColor = True
        Me.btnSearch.Appearance.Options.UseFont = True
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.ImageOptions.Image = CType(resources.GetObject("btnSave.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(648, 12)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(115, 35)
        Me.btnSearch.TabIndex = 26
        Me.btnSearch.Text = "جستجو"
        '
        'txtSearch
        '
        Me.txtSearch.EditValue = ""
        Me.txtSearch.Location = New System.Drawing.Point(781, 12)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Properties.Appearance.Font = New System.Drawing.Font("Vazirmatn SemiBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Properties.Appearance.Options.UseFont = True
        Me.txtSearch.Properties.Appearance.Options.UseTextOptions = True
        Me.txtSearch.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtSearch.Properties.NullText = "جستجو بر اساس عنوان یا کد سند"
        Me.txtSearch.Properties.NullValuePrompt = "جستجو بر اساس عنوان یا کد سند"
        Me.txtSearch.Properties.ShowNullValuePrompt = CType(((DevExpress.XtraEditors.ShowNullValuePromptOptions.EmptyValue Or DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorFocused) _
            Or DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorReadOnly), DevExpress.XtraEditors.ShowNullValuePromptOptions)
        Me.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSearch.Size = New System.Drawing.Size(318, 28)
        Me.txtSearch.TabIndex = 0
        '
        'panelShowDoc
        '
        Me.panelShowDoc.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.panelShowDoc.Appearance.Options.UseBackColor = True
        Me.panelShowDoc.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.panelShowDoc.Controls.Add(Me.btnShowDoc)
        Me.panelShowDoc.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelShowDoc.Location = New System.Drawing.Point(0, 555)
        Me.panelShowDoc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panelShowDoc.Name = "panelShowDoc"
        Me.panelShowDoc.Size = New System.Drawing.Size(1106, 57)
        Me.panelShowDoc.TabIndex = 13
        '
        'btnShowDoc
        '
        Me.btnShowDoc.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnShowDoc.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnShowDoc.Appearance.BorderColor = System.Drawing.Color.Transparent
        Me.btnShowDoc.Appearance.Font = New System.Drawing.Font("Vazirmatn SemiBold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowDoc.Appearance.Options.UseBackColor = True
        Me.btnShowDoc.Appearance.Options.UseBorderColor = True
        Me.btnShowDoc.Appearance.Options.UseFont = True
        Me.btnShowDoc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShowDoc.ImageOptions.Image = CType(resources.GetObject("btnShowDoc.ImageOptions.Image"), System.Drawing.Image)
        Me.btnShowDoc.Location = New System.Drawing.Point(471, 9)
        Me.btnShowDoc.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnShowDoc.Name = "btnShowDoc"
        Me.btnShowDoc.Size = New System.Drawing.Size(141, 45)
        Me.btnShowDoc.TabIndex = 12
        Me.btnShowDoc.Text = "مشاهده سند"
        '
        'grdSearchResult
        '
        Me.grdSearchResult.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdSearchResult.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.grdSearchResult.Location = New System.Drawing.Point(0, 93)
        Me.grdSearchResult.MainView = Me.gridView1
        Me.grdSearchResult.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grdSearchResult.Name = "grdSearchResult"
        Me.grdSearchResult.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.grdSearchResult.Size = New System.Drawing.Size(1106, 462)
        Me.grdSearchResult.TabIndex = 14
        Me.grdSearchResult.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
        '
        'gridView1
        '
        Me.gridView1.Appearance.Row.Font = New System.Drawing.Font("Vazirmatn", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridView1.Appearance.Row.Options.UseFont = True
        Me.gridView1.DetailHeight = 239
        Me.gridView1.GridControl = Me.grdSearchResult
        Me.gridView1.Name = "gridView1"
        '
        'FrmSearchDocs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1106, 612)
        Me.Controls.Add(Me.grdSearchResult)
        Me.Controls.Add(Me.panelShowDoc)
        Me.Controls.Add(Me.PanelControl1)
        Me.IconOptions.LargeImage = CType(resources.GetObject("FrmSearchDocs.IconOptions.LargeImage"), System.Drawing.Image)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSearchDocs"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "جستجوی اسناد"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.txtSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelShowDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelShowDoc.ResumeLayout(False)
        CType(Me.grdSearchResult, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Private WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtSearch As DevExpress.XtraEditors.TextEdit
    Private WithEvents panelShowDoc As DevExpress.XtraEditors.PanelControl
    Private WithEvents btnShowDoc As DevExpress.XtraEditors.SimpleButton
    Private WithEvents grdSearchResult As DevExpress.XtraGrid.GridControl
    Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
End Class

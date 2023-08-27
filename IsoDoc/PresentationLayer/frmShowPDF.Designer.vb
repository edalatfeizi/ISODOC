<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShowPDF
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmShowPDF))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.پرینتToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.زومToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.txt1 = New System.Windows.Forms.MaskedTextBox
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
        Me.grdLinks = New Janus.Windows.GridEX.GridEX
        Me.btnPreviousPage = New Janus.Windows.EditControls.UIButton
        Me.btnFirstPage = New Janus.Windows.EditControls.UIButton
        Me.btnLastPage = New Janus.Windows.EditControls.UIButton
        Me.btnNextPage = New Janus.Windows.EditControls.UIButton
        Me.btnPrint = New Janus.Windows.EditControls.UIButton
        Me.btnZoomOut = New Janus.Windows.EditControls.UIButton
        Me.btnZoomIN = New Janus.Windows.EditControls.UIButton
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.txt2 = New System.Windows.Forms.MaskedTextBox
        Me.AxPdf1 = New AxPdfLib.AxPdf
        Me.Slider1 = New DevComponents.DotNetBar.Controls.Slider
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.grdLinks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxPdf1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.پرینتToolStripMenuItem, Me.ToolStripMenuItem1, Me.زومToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(100, 54)
        '
        'پرینتToolStripMenuItem
        '
        Me.پرینتToolStripMenuItem.Image = CType(resources.GetObject("پرینتToolStripMenuItem.Image"), System.Drawing.Image)
        Me.پرینتToolStripMenuItem.Name = "پرینتToolStripMenuItem"
        Me.پرینتToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.پرینتToolStripMenuItem.Text = "پرینت"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(96, 6)
        '
        'زومToolStripMenuItem
        '
        Me.زومToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem3})
        Me.زومToolStripMenuItem.Image = CType(resources.GetObject("زومToolStripMenuItem.Image"), System.Drawing.Image)
        Me.زومToolStripMenuItem.Name = "زومToolStripMenuItem"
        Me.زومToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.زومToolStripMenuItem.Text = "زوم "
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Image = CType(resources.GetObject("ToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(82, 22)
        Me.ToolStripMenuItem2.Text = "+"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Image = CType(resources.GetObject("ToolStripMenuItem3.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(82, 22)
        Me.ToolStripMenuItem3.Text = "_"
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(92, 220)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(45, 21)
        Me.txt1.TabIndex = 8
        Me.txt1.Text = "1"
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.ExplorerBarGroupBackground
        Me.UiGroupBox1.BorderColor = System.Drawing.Color.Transparent
        Me.UiGroupBox1.Controls.Add(Me.grdLinks)
        Me.UiGroupBox1.Image = CType(resources.GetObject("UiGroupBox1.Image"), System.Drawing.Image)
        Me.UiGroupBox1.ImageSize = New System.Drawing.Size(1100, 97)
        Me.UiGroupBox1.Location = New System.Drawing.Point(-7, -1)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Size = New System.Drawing.Size(801, 93)
        Me.UiGroupBox1.TabIndex = 11
        Me.UiGroupBox1.Text = "جهت گرفتن پرينت كليك راست نماييد"
        '
        'grdLinks
        '
        Me.grdLinks.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdLinks.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.grdLinks.Location = New System.Drawing.Point(7, 0)
        Me.grdLinks.Name = "grdLinks"
        Me.grdLinks.Size = New System.Drawing.Size(801, 93)
        Me.grdLinks.TabIndex = 0
        Me.grdLinks.TabStop = False
        '
        'btnPreviousPage
        '
        Me.btnPreviousPage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPreviousPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnPreviousPage.Location = New System.Drawing.Point(0, 542)
        Me.btnPreviousPage.Name = "btnPreviousPage"
        Me.btnPreviousPage.Size = New System.Drawing.Size(52, 23)
        Me.btnPreviousPage.TabIndex = 19
        Me.btnPreviousPage.Text = "Previous"
        Me.btnPreviousPage.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'btnFirstPage
        '
        Me.btnFirstPage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnFirstPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnFirstPage.Location = New System.Drawing.Point(180, 542)
        Me.btnFirstPage.Name = "btnFirstPage"
        Me.btnFirstPage.Size = New System.Drawing.Size(32, 23)
        Me.btnFirstPage.TabIndex = 18
        Me.btnFirstPage.Text = "First"
        Me.btnFirstPage.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'btnLastPage
        '
        Me.btnLastPage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLastPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnLastPage.Location = New System.Drawing.Point(212, 542)
        Me.btnLastPage.Name = "btnLastPage"
        Me.btnLastPage.Size = New System.Drawing.Size(32, 23)
        Me.btnLastPage.TabIndex = 17
        Me.btnLastPage.Text = "Last"
        Me.btnLastPage.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'btnNextPage
        '
        Me.btnNextPage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnNextPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnNextPage.Location = New System.Drawing.Point(52, 542)
        Me.btnNextPage.Name = "btnNextPage"
        Me.btnNextPage.Size = New System.Drawing.Size(32, 23)
        Me.btnNextPage.TabIndex = 16
        Me.btnNextPage.Text = "Next"
        Me.btnNextPage.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnPrint.Icon = CType(resources.GetObject("btnPrint.Icon"), System.Drawing.Icon)
        Me.btnPrint.Location = New System.Drawing.Point(116, 542)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(32, 23)
        Me.btnPrint.TabIndex = 15
        Me.btnPrint.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'btnZoomOut
        '
        Me.btnZoomOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnZoomOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnZoomOut.Location = New System.Drawing.Point(148, 542)
        Me.btnZoomOut.Name = "btnZoomOut"
        Me.btnZoomOut.Size = New System.Drawing.Size(32, 23)
        Me.btnZoomOut.TabIndex = 14
        Me.btnZoomOut.Text = "-"
        Me.btnZoomOut.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'btnZoomIN
        '
        Me.btnZoomIN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnZoomIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnZoomIN.Location = New System.Drawing.Point(84, 542)
        Me.btnZoomIN.Name = "btnZoomIN"
        Me.btnZoomIN.Size = New System.Drawing.Size(32, 23)
        Me.btnZoomIN.TabIndex = 13
        Me.btnZoomIN.Text = "+"
        Me.btnZoomIN.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'Timer2
        '
        Me.Timer2.Interval = 1
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(232, 220)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(45, 21)
        Me.txt2.TabIndex = 12
        Me.txt2.Text = "1"
        '
        'AxPdf1
        '
        Me.AxPdf1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AxPdf1.Enabled = True
        Me.AxPdf1.Location = New System.Drawing.Point(0, 0)
        Me.AxPdf1.Name = "AxPdf1"
        Me.AxPdf1.OcxState = CType(resources.GetObject("AxPdf1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxPdf1.Size = New System.Drawing.Size(792, 543)
        Me.AxPdf1.TabIndex = 13
        '
        'Slider1
        '
        Me.Slider1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Slider1.Location = New System.Drawing.Point(275, 542)
        Me.Slider1.Name = "Slider1"
        Me.Slider1.Size = New System.Drawing.Size(488, 23)
        Me.Slider1.TabIndex = 20
        Me.Slider1.Value = 50
        '
        'frmShowPDF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.Slider1)
        Me.Controls.Add(Me.btnZoomIN)
        Me.Controls.Add(Me.btnZoomOut)
        Me.Controls.Add(Me.btnPreviousPage)
        Me.Controls.Add(Me.btnFirstPage)
        Me.Controls.Add(Me.btnLastPage)
        Me.Controls.Add(Me.btnNextPage)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.UiGroupBox1)
        Me.Controls.Add(Me.AxPdf1)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.txt2)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "frmShowPDF"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        CType(Me.grdLinks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxPdf1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents پرینتToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txt1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents زومToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents txt2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnZoomIN As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnZoomOut As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnPrint As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnNextPage As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnLastPage As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnFirstPage As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnPreviousPage As Janus.Windows.EditControls.UIButton
    Friend WithEvents AxPdf1 As AxPdfLib.AxPdf
    Friend WithEvents grdLinks As Janus.Windows.GridEX.GridEX
    Friend WithEvents Slider1 As DevComponents.DotNetBar.Controls.Slider





End Class

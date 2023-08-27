<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPDF
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPDF))
        Me.PdfDocument1 = New O2S.Components.PDFView4NET.PDFDocument(Me.components)
        Me.btnnextpage = New System.Windows.Forms.Button
        Me.btnprepage = New System.Windows.Forms.Button
        Me.txtpage = New System.Windows.Forms.MaskedTextBox
        Me.txtzoom = New System.Windows.Forms.MaskedTextBox
        Me.btninzoom = New System.Windows.Forms.Button
        Me.btnoutzoom = New System.Windows.Forms.Button
        Me.txtjump = New System.Windows.Forms.MaskedTextBox
        Me.btnjump = New System.Windows.Forms.Button
        Me.btnPrint = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.grdLinks = New Janus.Windows.GridEX.GridEX
        Me.btnZoomIN = New Janus.Windows.EditControls.UIButton
        Me.btnZoomOut = New Janus.Windows.EditControls.UIButton
        Me.btnPreviousPage = New Janus.Windows.EditControls.UIButton
        Me.UiButton1 = New Janus.Windows.EditControls.UIButton
        Me.UiButton2 = New Janus.Windows.EditControls.UIButton
        Me.btnFirstPage = New Janus.Windows.EditControls.UIButton
        Me.UiButton3 = New Janus.Windows.EditControls.UIButton
        Me.Slider1 = New DevComponents.DotNetBar.Controls.Slider
        Me.PdfPageView1 = New O2S.Components.PDFView4NET.PDFPageView
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblcount = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblCurentPage = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
        Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox
        CType(Me.grdLinks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnnextpage
        '
        Me.btnnextpage.Location = New System.Drawing.Point(748, 5)
        Me.btnnextpage.Name = "btnnextpage"
        Me.btnnextpage.Size = New System.Drawing.Size(26, 25)
        Me.btnnextpage.TabIndex = 1
        Me.btnnextpage.Text = ">>"
        Me.btnnextpage.UseVisualStyleBackColor = True
        Me.btnnextpage.Visible = False
        '
        'btnprepage
        '
        Me.btnprepage.Location = New System.Drawing.Point(642, 18)
        Me.btnprepage.Name = "btnprepage"
        Me.btnprepage.Size = New System.Drawing.Size(26, 25)
        Me.btnprepage.TabIndex = 2
        Me.btnprepage.Text = "<<"
        Me.btnprepage.UseVisualStyleBackColor = True
        Me.btnprepage.Visible = False
        '
        'txtpage
        '
        Me.txtpage.Location = New System.Drawing.Point(674, 21)
        Me.txtpage.Name = "txtpage"
        Me.txtpage.Size = New System.Drawing.Size(64, 21)
        Me.txtpage.TabIndex = 3
        Me.txtpage.Visible = False
        '
        'txtzoom
        '
        Me.txtzoom.Location = New System.Drawing.Point(671, 25)
        Me.txtzoom.Name = "txtzoom"
        Me.txtzoom.Size = New System.Drawing.Size(64, 21)
        Me.txtzoom.TabIndex = 6
        Me.txtzoom.Visible = False
        '
        'btninzoom
        '
        Me.btninzoom.Location = New System.Drawing.Point(671, 20)
        Me.btninzoom.Name = "btninzoom"
        Me.btninzoom.Size = New System.Drawing.Size(26, 25)
        Me.btninzoom.TabIndex = 5
        Me.btninzoom.Text = "+"
        Me.btninzoom.UseVisualStyleBackColor = True
        Me.btninzoom.Visible = False
        '
        'btnoutzoom
        '
        Me.btnoutzoom.Location = New System.Drawing.Point(741, 23)
        Me.btnoutzoom.Name = "btnoutzoom"
        Me.btnoutzoom.Size = New System.Drawing.Size(26, 25)
        Me.btnoutzoom.TabIndex = 4
        Me.btnoutzoom.Text = "-"
        Me.btnoutzoom.UseVisualStyleBackColor = True
        Me.btnoutzoom.Visible = False
        '
        'txtjump
        '
        Me.txtjump.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtjump.Location = New System.Drawing.Point(724, 81)
        Me.txtjump.Name = "txtjump"
        Me.txtjump.Size = New System.Drawing.Size(35, 21)
        Me.txtjump.TabIndex = 8
        Me.txtjump.Visible = False
        '
        'btnjump
        '
        Me.btnjump.Location = New System.Drawing.Point(642, 18)
        Me.btnjump.Name = "btnjump"
        Me.btnjump.Size = New System.Drawing.Size(55, 25)
        Me.btnjump.TabIndex = 7
        Me.btnjump.Text = "Jump"
        Me.btnjump.UseVisualStyleBackColor = True
        Me.btnjump.Visible = False
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(601, 19)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(129, 21)
        Me.btnPrint.TabIndex = 9
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        Me.btnPrint.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'grdLinks
        '
        Me.grdLinks.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.grdLinks.Location = New System.Drawing.Point(10, 19)
        Me.grdLinks.Name = "grdLinks"
        Me.grdLinks.Size = New System.Drawing.Size(300, 72)
        Me.grdLinks.TabIndex = 10
        Me.grdLinks.TabStop = False
        Me.grdLinks.Visible = False
        '
        'btnZoomIN
        '
        Me.btnZoomIN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnZoomIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnZoomIN.Location = New System.Drawing.Point(629, 30)
        Me.btnZoomIN.Name = "btnZoomIN"
        Me.btnZoomIN.Size = New System.Drawing.Size(32, 23)
        Me.btnZoomIN.TabIndex = 20
        Me.btnZoomIN.Text = "+"
        Me.btnZoomIN.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'btnZoomOut
        '
        Me.btnZoomOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnZoomOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnZoomOut.Location = New System.Drawing.Point(693, 30)
        Me.btnZoomOut.Name = "btnZoomOut"
        Me.btnZoomOut.Size = New System.Drawing.Size(32, 23)
        Me.btnZoomOut.TabIndex = 21
        Me.btnZoomOut.Text = "-"
        Me.btnZoomOut.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'btnPreviousPage
        '
        Me.btnPreviousPage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPreviousPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnPreviousPage.Location = New System.Drawing.Point(545, 30)
        Me.btnPreviousPage.Name = "btnPreviousPage"
        Me.btnPreviousPage.Size = New System.Drawing.Size(52, 23)
        Me.btnPreviousPage.TabIndex = 25
        Me.btnPreviousPage.Text = "Previous"
        Me.btnPreviousPage.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'UiButton1
        '
        Me.UiButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UiButton1.Location = New System.Drawing.Point(597, 30)
        Me.UiButton1.Name = "UiButton1"
        Me.UiButton1.Size = New System.Drawing.Size(32, 23)
        Me.UiButton1.TabIndex = 23
        Me.UiButton1.Text = "Next"
        Me.UiButton1.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'UiButton2
        '
        Me.UiButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UiButton2.Icon = CType(resources.GetObject("UiButton2.Icon"), System.Drawing.Icon)
        Me.UiButton2.Location = New System.Drawing.Point(661, 30)
        Me.UiButton2.Name = "UiButton2"
        Me.UiButton2.Size = New System.Drawing.Size(32, 23)
        Me.UiButton2.TabIndex = 22
        Me.UiButton2.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'btnFirstPage
        '
        Me.btnFirstPage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFirstPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnFirstPage.Location = New System.Drawing.Point(725, 30)
        Me.btnFirstPage.Name = "btnFirstPage"
        Me.btnFirstPage.Size = New System.Drawing.Size(32, 23)
        Me.btnFirstPage.TabIndex = 24
        Me.btnFirstPage.Text = "First"
        Me.btnFirstPage.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'UiButton3
        '
        Me.UiButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UiButton3.Location = New System.Drawing.Point(687, 79)
        Me.UiButton3.Name = "UiButton3"
        Me.UiButton3.Size = New System.Drawing.Size(36, 23)
        Me.UiButton3.TabIndex = 26
        Me.UiButton3.Text = "Jump"
        Me.UiButton3.Visible = False
        Me.UiButton3.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'Slider1
        '
        Me.Slider1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Slider1.Location = New System.Drawing.Point(207, 30)
        Me.Slider1.Name = "Slider1"
        Me.Slider1.Size = New System.Drawing.Size(332, 23)
        Me.Slider1.TabIndex = 27
        Me.Slider1.Value = 50
        '
        'PdfPageView1
        '
        Me.PdfPageView1.AllowDrop = True
        Me.PdfPageView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PdfPageView1.AutoScroll = True
        Me.PdfPageView1.Location = New System.Drawing.Point(14, 119)
        Me.PdfPageView1.Name = "PdfPageView1"
        Me.PdfPageView1.PageNumber = 0
        Me.PdfPageView1.Size = New System.Drawing.Size(751, 424)
        Me.PdfPageView1.TabIndex = 0
        Me.PdfPageView1.WorkMode = O2S.Components.PDFView4NET.UserInteractiveWorkMode.PanAndScan
        Me.PdfPageView1.Zoom = 100.0!
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(708, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(50, 14)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "ÕÝÍå :"
        '
        'lblcount
        '
        Me.lblcount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblcount.AutoSize = True
        Me.lblcount.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblcount.ForeColor = System.Drawing.Color.Red
        Me.lblcount.Location = New System.Drawing.Point(643, 65)
        Me.lblcount.Name = "lblcount"
        Me.lblcount.Size = New System.Drawing.Size(15, 14)
        Me.lblcount.TabIndex = 29
        Me.lblcount.Text = "0"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(221, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(401, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "ÈÑÇí íãÇíÔ Èíä ÕÝÍÇÊ ÇÒ ßáíÏ åÇí Page up - Page Down ÇÓÊÝÇÏå äãÇÆíÏ ."
        '
        'lblCurentPage
        '
        Me.lblCurentPage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCurentPage.AutoSize = True
        Me.lblCurentPage.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lblCurentPage.ForeColor = System.Drawing.Color.Red
        Me.lblCurentPage.Location = New System.Drawing.Point(687, 65)
        Me.lblCurentPage.Name = "lblCurentPage"
        Me.lblCurentPage.Size = New System.Drawing.Size(15, 14)
        Me.lblCurentPage.TabIndex = 31
        Me.lblCurentPage.Text = "0"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.Location = New System.Drawing.Point(664, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(17, 14)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "ÇÒ"
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox1.BorderColor = System.Drawing.Color.Maroon
        Me.UiGroupBox1.Controls.Add(Me.Label3)
        Me.UiGroupBox1.Controls.Add(Me.lblCurentPage)
        Me.UiGroupBox1.Controls.Add(Me.Label2)
        Me.UiGroupBox1.Controls.Add(Me.lblcount)
        Me.UiGroupBox1.Controls.Add(Me.Label1)
        Me.UiGroupBox1.Controls.Add(Me.Slider1)
        Me.UiGroupBox1.Controls.Add(Me.btnZoomIN)
        Me.UiGroupBox1.Controls.Add(Me.btnZoomOut)
        Me.UiGroupBox1.Controls.Add(Me.btnPreviousPage)
        Me.UiGroupBox1.Controls.Add(Me.btnFirstPage)
        Me.UiGroupBox1.Controls.Add(Me.UiButton1)
        Me.UiGroupBox1.Controls.Add(Me.UiButton2)
        Me.UiGroupBox1.Controls.Add(Me.btnjump)
        Me.UiGroupBox1.Controls.Add(Me.txtzoom)
        Me.UiGroupBox1.Controls.Add(Me.btninzoom)
        Me.UiGroupBox1.Controls.Add(Me.btnoutzoom)
        Me.UiGroupBox1.Controls.Add(Me.txtpage)
        Me.UiGroupBox1.Controls.Add(Me.btnprepage)
        Me.UiGroupBox1.Controls.Add(Me.btnnextpage)
        Me.UiGroupBox1.Location = New System.Drawing.Point(6, 4)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Size = New System.Drawing.Size(774, 97)
        Me.UiGroupBox1.TabIndex = 33
        '
        'UiGroupBox2
        '
        Me.UiGroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiGroupBox2.BorderColor = System.Drawing.Color.Maroon
        Me.UiGroupBox2.Controls.Add(Me.btnPrint)
        Me.UiGroupBox2.Location = New System.Drawing.Point(6, 104)
        Me.UiGroupBox2.Name = "UiGroupBox2"
        Me.UiGroupBox2.Size = New System.Drawing.Size(773, 442)
        Me.UiGroupBox2.TabIndex = 34
        '
        'frmPDF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 557)
        Me.Controls.Add(Me.UiButton3)
        Me.Controls.Add(Me.grdLinks)
        Me.Controls.Add(Me.txtjump)
        Me.Controls.Add(Me.PdfPageView1)
        Me.Controls.Add(Me.UiGroupBox1)
        Me.Controls.Add(Me.UiGroupBox2)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.KeyPreview = True
        Me.Name = "frmPDF"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grdLinks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.UiGroupBox1.PerformLayout()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PdfDocument1 As O2S.Components.PDFView4NET.PDFDocument
    Friend WithEvents btnnextpage As System.Windows.Forms.Button
    Friend WithEvents btnprepage As System.Windows.Forms.Button
    Friend WithEvents txtpage As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtzoom As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btninzoom As System.Windows.Forms.Button
    Friend WithEvents btnoutzoom As System.Windows.Forms.Button
    Friend WithEvents txtjump As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnjump As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents grdLinks As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnZoomIN As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnZoomOut As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnPreviousPage As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiButton1 As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiButton2 As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnFirstPage As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiButton3 As Janus.Windows.EditControls.UIButton
    Friend WithEvents Slider1 As DevComponents.DotNetBar.Controls.Slider
    Friend WithEvents PdfPageView1 As O2S.Components.PDFView4NET.PDFPageView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblcount As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblCurentPage As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLifeSheet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLifeSheet))
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
        Me.dgReview = New Janus.Windows.GridEX.GridEX
        Me.btnPrint = New Janus.Windows.EditControls.UIButton
        Me.UiButton1 = New Janus.Windows.EditControls.UIButton
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        CType(Me.dgReview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.BackgroundStyle = Janus.Windows.EditControls.BackgroundStyle.ExplorerBarBackground
        Me.UiGroupBox1.Controls.Add(Me.UiButton1)
        Me.UiGroupBox1.Controls.Add(Me.btnPrint)
        Me.UiGroupBox1.Controls.Add(Me.dgReview)
        Me.UiGroupBox1.Location = New System.Drawing.Point(-8, -11)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Size = New System.Drawing.Size(571, 362)
        Me.UiGroupBox1.TabIndex = 0
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2003
        '
        'dgReview
        '
        Me.dgReview.GroupByBoxVisible = False
        Me.dgReview.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
        Me.dgReview.Location = New System.Drawing.Point(20, 15)
        Me.dgReview.Name = "dgReview"
        Me.dgReview.Size = New System.Drawing.Size(532, 300)
        Me.dgReview.TabIndex = 0
        '
        'btnPrint
        '
        Me.btnPrint.Icon = CType(resources.GetObject("btnPrint.Icon"), System.Drawing.Icon)
        Me.btnPrint.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far
        Me.btnPrint.Location = New System.Drawing.Point(285, 321)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(72, 24)
        Me.btnPrint.TabIndex = 1
        Me.btnPrint.Text = "ç«Å"
        Me.btnPrint.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'UiButton1
        '
        Me.UiButton1.Icon = CType(resources.GetObject("UiButton1.Icon"), System.Drawing.Icon)
        Me.UiButton1.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far
        Me.UiButton1.Location = New System.Drawing.Point(207, 321)
        Me.UiButton1.Name = "UiButton1"
        Me.UiButton1.Size = New System.Drawing.Size(72, 24)
        Me.UiButton1.TabIndex = 2
        Me.UiButton1.Text = "«‰’—«›"
        Me.UiButton1.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003
        '
        'FrmLifeSheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 343)
        Me.Controls.Add(Me.UiGroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmLifeSheet"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Life Sheet"
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        CType(Me.dgReview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents dgReview As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnPrint As Janus.Windows.EditControls.UIButton
    Friend WithEvents UiButton1 As Janus.Windows.EditControls.UIButton
End Class

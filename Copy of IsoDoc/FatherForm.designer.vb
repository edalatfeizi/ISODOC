<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FatherForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FatherForm))
        Me.AxOfficeViewer1 = New AxOfficeViewer.AxOfficeViewer
        CType(Me.AxOfficeViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxOfficeViewer1
        '
        Me.AxOfficeViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AxOfficeViewer1.Enabled = True
        Me.AxOfficeViewer1.Location = New System.Drawing.Point(-1, 1)
        Me.AxOfficeViewer1.Name = "AxOfficeViewer1"
        Me.AxOfficeViewer1.OcxState = CType(resources.GetObject("AxOfficeViewer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxOfficeViewer1.Size = New System.Drawing.Size(793, 566)
        Me.AxOfficeViewer1.TabIndex = 21
        '
        'FatherForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.AxOfficeViewer1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ForeColor = System.Drawing.Color.Blue
        Me.Name = "FatherForm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "‰„«Ì‘"
        CType(Me.AxOfficeViewer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AxOfficeViewer1 As AxOfficeViewer.AxOfficeViewer

End Class

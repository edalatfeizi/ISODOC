<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BarSubItem2 = New DevExpress.XtraBars.BarSubItem
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.������������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.�������ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.���ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BarSubItem2
        '
        Me.BarSubItem2.Caption = "���� �� ���� ����"
        Me.BarSubItem2.Id = 1
        Me.BarSubItem2.Name = "BarSubItem2"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1016, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.������ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1016, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '������ToolStripMenuItem
        '
        Me.������ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.������������ToolStripMenuItem, Me.�������ToolStripMenuItem, Me.���ToolStripMenuItem})
        Me.������ToolStripMenuItem.Name = "������ToolStripMenuItem"
        Me.������ToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.������ToolStripMenuItem.Text = "������"
        '
        '������������ToolStripMenuItem
        '
        Me.������������ToolStripMenuItem.Name = "������������ToolStripMenuItem"
        Me.������������ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.������������ToolStripMenuItem.Text = "���� �� ������"
        '
        '�������ToolStripMenuItem
        '
        Me.�������ToolStripMenuItem.Name = "�������ToolStripMenuItem"
        Me.�������ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.�������ToolStripMenuItem.Text = "��� � ���"
        '
        '���ToolStripMenuItem
        '
        Me.���ToolStripMenuItem.Name = "���ToolStripMenuItem"
        Me.���ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.���ToolStripMenuItem.Text = "���"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1016, 734)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "������ ������� ���� �����"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarSubItem2 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ������������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents �������ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ���ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_SetAccessForViewDoc
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
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_SetAccessForViewDoc))
        Dim GridEXLayout2 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.Btn_Search = New DevComponents.DotNetBar.ButtonX()
        Me.Txt_searchSelectedPerson = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GrdSelectedPerson = New Janus.Windows.GridEX.GridEX()
        Me.GrdMain = New Janus.Windows.GridEX.GridEX()
        Me.Btn_Add = New DevComponents.DotNetBar.ButtonX()
        Me.Txt_search = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Btn_Remove = New DevComponents.DotNetBar.ButtonX()
        CType(Me.GrdSelectedPerson, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_Search
        '
        Me.Btn_Search.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btn_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Search.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Btn_Search.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Search.Font = New System.Drawing.Font("Nazanin", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Search.Location = New System.Drawing.Point(721, 34)
        Me.Btn_Search.Name = "Btn_Search"
        Me.Btn_Search.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10)
        Me.Btn_Search.Size = New System.Drawing.Size(40, 32)
        Me.Btn_Search.TabIndex = 87
        Me.Btn_Search.Text = ">>"
        '
        'Txt_searchSelectedPerson
        '
        Me.Txt_searchSelectedPerson.Location = New System.Drawing.Point(99, 43)
        Me.Txt_searchSelectedPerson.Name = "Txt_searchSelectedPerson"
        Me.Txt_searchSelectedPerson.Size = New System.Drawing.Size(159, 28)
        Me.Txt_searchSelectedPerson.TabIndex = 86
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(269, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 20)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "بخشی از نام خانوادگی شخص یا شماره پرسنلی را وارد نمایید :"
        '
        'GrdSelectedPerson
        '
        Me.GrdSelectedPerson.ColumnSetNavigation = Janus.Windows.GridEX.ColumnSetNavigation.ColumnSet
        Me.GrdSelectedPerson.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        GridEXLayout1.LayoutString = resources.GetString("GridEXLayout1.LayoutString")
        Me.GrdSelectedPerson.DesignTimeLayout = GridEXLayout1
        Me.GrdSelectedPerson.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdSelectedPerson.Font = New System.Drawing.Font("B Nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GrdSelectedPerson.GroupByBoxVisible = False
        Me.GrdSelectedPerson.Location = New System.Drawing.Point(-41, 93)
        Me.GrdSelectedPerson.Name = "GrdSelectedPerson"
        Me.GrdSelectedPerson.Size = New System.Drawing.Size(615, 526)
        Me.GrdSelectedPerson.TabIndex = 84
        Me.GrdSelectedPerson.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'GrdMain
        '
        Me.GrdMain.ColumnSetNavigation = Janus.Windows.GridEX.ColumnSetNavigation.ColumnSet
        Me.GrdMain.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        GridEXLayout2.LayoutString = resources.GetString("GridEXLayout2.LayoutString")
        Me.GrdMain.DesignTimeLayout = GridEXLayout2
        Me.GrdMain.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GrdMain.Font = New System.Drawing.Font("B Nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GrdMain.GroupByBoxVisible = False
        Me.GrdMain.Location = New System.Drawing.Point(646, 86)
        Me.GrdMain.Name = "GrdMain"
        Me.GrdMain.Size = New System.Drawing.Size(585, 526)
        Me.GrdMain.TabIndex = 83
        Me.GrdMain.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        '
        'Btn_Add
        '
        Me.Btn_Add.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Add.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Btn_Add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Add.Font = New System.Drawing.Font("Nazanin", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Add.Location = New System.Drawing.Point(581, 224)
        Me.Btn_Add.Name = "Btn_Add"
        Me.Btn_Add.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10)
        Me.Btn_Add.Size = New System.Drawing.Size(55, 46)
        Me.Btn_Add.TabIndex = 82
        Me.Btn_Add.Text = ">>"
        '
        'Txt_search
        '
        Me.Txt_search.Location = New System.Drawing.Point(767, 38)
        Me.Txt_search.Name = "Txt_search"
        Me.Txt_search.Size = New System.Drawing.Size(180, 28)
        Me.Txt_search.TabIndex = 81
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(947, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(288, 20)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "بخشی از نام خانوادگی شخص یا شماره پرسنلی را وارد نمایید :"
        '
        'Btn_Remove
        '
        Me.Btn_Remove.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Btn_Remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Remove.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Btn_Remove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Remove.Font = New System.Drawing.Font("Nazanin", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Remove.Location = New System.Drawing.Point(581, 285)
        Me.Btn_Remove.Name = "Btn_Remove"
        Me.Btn_Remove.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10)
        Me.Btn_Remove.Size = New System.Drawing.Size(55, 46)
        Me.Btn_Remove.TabIndex = 79
        Me.Btn_Remove.Text = "<<"
        '
        'Frm_SetAccessForViewDoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1241, 623)
        Me.Controls.Add(Me.Btn_Search)
        Me.Controls.Add(Me.Txt_searchSelectedPerson)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GrdSelectedPerson)
        Me.Controls.Add(Me.GrdMain)
        Me.Controls.Add(Me.Btn_Add)
        Me.Controls.Add(Me.Txt_search)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Btn_Remove)
        Me.Font = New System.Drawing.Font("B Nazanin", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Frm_SetAccessForViewDoc"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ثبت دسترسی مشاهده سند"
        CType(Me.GrdSelectedPerson, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Search As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Txt_searchSelectedPerson As TextBox
    Friend WithEvents Label1 As Label
    Private WithEvents GrdSelectedPerson As Janus.Windows.GridEX.GridEX
    Private WithEvents GrdMain As Janus.Windows.GridEX.GridEX
    Friend WithEvents Btn_Add As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Txt_search As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Btn_Remove As DevComponents.DotNetBar.ButtonX
End Class

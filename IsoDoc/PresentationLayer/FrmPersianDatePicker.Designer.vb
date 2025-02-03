<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPersianDatePicker
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
        Me.PersianCalender = New BehComponents.MonthCalendarX()
        Me.BtnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSelectDate = New DevComponents.DotNetBar.ButtonX()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PersianCalender
        '
        Me.PersianCalender.BoldedDayForeColor = System.Drawing.Color.Blue
        Me.PersianCalender.BorderColor = System.Drawing.Color.CadetBlue
        Me.PersianCalender.CalendarType = BehComponents.CalendarTypes.Persian
        Me.PersianCalender.DayRectTickness = 2.0!
        Me.PersianCalender.DaysBackColor = System.Drawing.Color.White
        Me.PersianCalender.DaysFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PersianCalender.DaysForeColor = System.Drawing.Color.Black
        Me.PersianCalender.EnglishAnnuallyBoldedDates = New Date(-1) {}
        Me.PersianCalender.EnglishBoldedDates = New Date(-1) {}
        Me.PersianCalender.EnglishHolidayDates = New Date(-1) {}
        Me.PersianCalender.EnglishMonthlyBoldedDates = New Date(-1) {}
        Me.PersianCalender.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PersianCalender.HolidayForeColor = System.Drawing.Color.Red
        Me.PersianCalender.HolidayWeekly = BehComponents.MonthCalendarX.DayOfWeekForHoliday.Friday
        Me.PersianCalender.LineWeekColor = System.Drawing.Color.Black
        Me.PersianCalender.Location = New System.Drawing.Point(-2, -4)
        Me.PersianCalender.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PersianCalender.Name = "PersianCalender"
        Me.PersianCalender.PersianAnnuallyBoldedDates = New BehComponents.PersianDateTime(-1) {}
        Me.PersianCalender.PersianBoldedDates = New BehComponents.PersianDateTime(-1) {}
        Me.PersianCalender.PersianHolidayDates = New BehComponents.PersianDateTime(-1) {}
        Me.PersianCalender.PersianMonthlyBoldedDates = New BehComponents.PersianDateTime(-1) {}
        Me.PersianCalender.ShowToday = True
        Me.PersianCalender.ShowTodayRect = True
        Me.PersianCalender.ShowToolTips = False
        Me.PersianCalender.ShowTrailing = True
        Me.PersianCalender.Size = New System.Drawing.Size(242, 249)
        Me.PersianCalender.Style_DaysButton = BehComponents.ButtonX.ButtonStyles.Simple
        Me.PersianCalender.Style_GotoTodayButton = BehComponents.ButtonX.ButtonStyles.Green
        Me.PersianCalender.Style_MonthButton = BehComponents.ButtonX.ButtonStyles.Blue
        Me.PersianCalender.Style_NextMonthButton = BehComponents.ButtonX.ButtonStyles.Green
        Me.PersianCalender.Style_PreviousMonthButton = BehComponents.ButtonX.ButtonStyles.Green
        Me.PersianCalender.Style_YearButton = BehComponents.ButtonX.ButtonStyles.Blue
        Me.PersianCalender.TabIndex = 1
        Me.PersianCalender.TitleBackColor = System.Drawing.Color.White
        Me.PersianCalender.TitleFont = New System.Drawing.Font("Tahoma", 8.25!)
        Me.PersianCalender.TitleForeColor = System.Drawing.Color.Black
        Me.PersianCalender.TodayBackColor = System.Drawing.Color.White
        Me.PersianCalender.TodayFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.PersianCalender.TodayForeColor = System.Drawing.Color.Black
        Me.PersianCalender.TodayRectColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PersianCalender.TodayRectTickness = 2.0!
        Me.PersianCalender.TrailingForeColor = System.Drawing.Color.DarkGray
        Me.PersianCalender.WeekDaysBackColor = System.Drawing.Color.White
        Me.PersianCalender.WeekDaysFont = New System.Drawing.Font("Tahoma", 8.25!)
        Me.PersianCalender.WeekDaysForeColor = System.Drawing.Color.Blue
        Me.PersianCalender.WeekStartsOn = BehComponents.MonthCalendarX.WeekDays.Saturday
        '
        'BtnCancel
        '
        Me.BtnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.Font = New System.Drawing.Font("Nazanin", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnCancel.Location = New System.Drawing.Point(1, 281)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.BtnCancel.Size = New System.Drawing.Size(236, 33)
        Me.BtnCancel.TabIndex = 89
        Me.BtnCancel.Text = "انصراف"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSelectDate)
        Me.GroupBox1.Controls.Add(Me.PersianCalender)
        Me.GroupBox1.Controls.Add(Me.BtnCancel)
        Me.GroupBox1.Location = New System.Drawing.Point(0, -1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(242, 318)
        Me.GroupBox1.TabIndex = 90
        Me.GroupBox1.TabStop = False
        '
        'btnSelectDate
        '
        Me.btnSelectDate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSelectDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSelectDate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSelectDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSelectDate.Font = New System.Drawing.Font("Nazanin", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSelectDate.Location = New System.Drawing.Point(1, 246)
        Me.btnSelectDate.Name = "btnSelectDate"
        Me.btnSelectDate.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.btnSelectDate.Size = New System.Drawing.Size(236, 33)
        Me.btnSelectDate.TabIndex = 90
        Me.btnSelectDate.Text = "تایید"
        '
        'FrmPersianDatePicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(237, 312)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmPersianDatePicker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents PersianCalender As BehComponents.MonthCalendarX
    Friend WithEvents BtnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSelectDate As DevComponents.DotNetBar.ButtonX
End Class

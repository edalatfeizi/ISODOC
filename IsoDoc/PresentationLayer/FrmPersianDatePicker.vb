Public Class FrmPersianDatePicker
    Public Property SelectedDate As String

    Private Sub FrmPersianDatePicker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub PersianCalender_SelectedDateChanged(selectedDateTime As Date, selectedPersianDateTime As BehComponents.PersianDateTime) Handles PersianCalender.SelectedDateChanged


    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub PersianCalender_TodayDateChanged(todayDateTime As Date, todayPersianDateTime As BehComponents.PersianDateTime) Handles PersianCalender.TodayDateChanged

    End Sub
    Private Sub SelectDate()
        SelectedDate = PersianCalender.GetSelectedDateInPersianDateTime().ToShortDateString()
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnSelectDate_Click(sender As Object, e As EventArgs) Handles btnSelectDate.Click
        SelectDate()
    End Sub
End Class
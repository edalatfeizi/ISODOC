Public Class FrmIsoInsertHistory
    Private Bus_History1 As New Bus_History
    Dim DocName As String
    Dim date1 As String = Mdate1.GetIrani8Date_CurDate
    Dim FileInfo As System.IO.FileInfo
    Dim FilePath As String
    Dim DateHist As String = Mdate1.GetIrani8DateStr_CurDate
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MessageBox.Show("¬Ì« „ÿ„∆‰ Â” Ìœø", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) = Windows.Forms.DialogResult.Yes Then
            Try
                FileInfo = FileIO.FileSystem.GetFileInfo(lblFilePath.Text)
                DocName = FileInfo.Name
                ''FilePath = "\\Nt_dbms\xxdis1030$\Quality\situation of documents\History\" + date1 + DocName
                FilePath = "\\Nt_dbms\PDF\Quality\situation of documents\History\" + date1 + DocName
                FileInfo.CopyTo(FilePath)
                Bus_History1.InsertHistory(lblDocID.Text, lblDocName.Text, lblDocCode.Text, lblReviewNum.Text, lblReviewDate.Text, FilePath, lblDocTypeID.Text, DateHist)
                MessageBox.Show("”‰œ „Ê—œ ‰Ÿ— »«Ìê«‰Ì ‘œ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                Me.Close()
            Catch ex As Exception
                MessageBox.Show("Œÿ« œ— »«Ìê«‰Ì «ÿ·«⁄« ", "Œÿ«", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)

            End Try
        Else
            Exit Sub
        End If

    End Sub

End Class
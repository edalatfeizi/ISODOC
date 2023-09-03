Imports System.IO
Public Class frmTest

    Private Sub UiButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UiButton1.Click
        'Dim cn As String
        Dim str As String
        Dim dt As New DataTable
        Dim a As String
        Dim b, i As Integer
        Dim doctypeid As Integer

        str = "SELECT     MainId, DocPath   FROM   dbo.tbISODocuments WHERE     (DocPath <> '-')  order by DocPath"

        dt = persist1.GetDataTable(CnnString, str)
        For i = 0 To dt.Rows.Count - 1

            ''''Ì«› ‰ ‰Ê⁄ ›«Ì·
            b = Len(dt.DefaultView.Item(i).Item("DocPath"))
            a = Mid(dt.DefaultView.Item(i).Item("DocPath"), b - 2, 3)

            Select Case a
                Case "pdf"
                    doctypeid = 1
                Case "PDF"
                    doctypeid = 1
                Case "doc"
                    doctypeid = 2
                Case "DOC"
                    doctypeid = 2
                Case "ocx"
                    doctypeid = 2
                Case "xls"
                    doctypeid = 3
                Case "lsx"
                    doctypeid = 3
                Case "jpg"
                    doctypeid = 4
                Case "tif"
                    doctypeid = 5
                Case "DWG"
                    doctypeid = 6
                Case "dwg"
                    doctypeid = 6
                Case "XLS"
                    doctypeid = 3
                Case "htm"
                    doctypeid = 7

                Case Else
                    MsgBox(a)
            End Select

            persist1.Sp_AddParam("@MainId_1", SqlDbType.Int, dt.DefaultView.Item(i).Item("MainId"), ParameterDirection.Input)
            persist1.Sp_AddParam("@DocTypeID_3", SqlDbType.Int, doctypeid, ParameterDirection.Input)
            persist1.Sp_Exe("Sp_tbISODocuments_UpdPathNewType", CnnString, True)

        Next
    End Sub
    Private Function ReadFileToByteArray(ByVal FileName As String) As System.Array
        Dim fs As FileStream = New FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Read)
        Dim Len As Long
        Len = fs.Length
        Dim fileAsByte(Len) As Byte
        fs.Read(fileAsByte, 0, fileAsByte.Length)
        Dim MemoryStream1 As MemoryStream = New MemoryStream(fileAsByte)
        Return MemoryStream1.ToArray
    End Function

    Private Function saveAttach() As Byte()
        Dim fileName = Path.GetFileName(OpenFileDialog1.FileName.ToString())
        Dim content As Byte() = ReadFileToByteArray(fileName)
        Return content
    End Function

    Private Sub UiButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UiButton2.Click
        'Dim cn As String
        Dim str As String
        Dim dt As New DataTable
        Dim a As String
        Dim b, i As Integer
        Dim doctypeid As Integer
        Dim Image As Byte()

        str = "SELECT     MainId, DocPath   FROM   dbo.tbISODocuments WHERE     (DocPath <> '-') and (SUBSTRING(DocPath, 1, 48) = '\\Nt_dbms\xxdis1030$\Quality\FORM-PDF\PS-MAJMOE\') and (DocTypeID = 1) order by DocPath"

        dt = persist1.GetDataTable(CnnString, str)

        For i = 0 To dt.Rows.Count - 1

            Dim d As Integer
            Dim fileName = Path.GetFileName(dt.DefaultView.Item(i).Item("DocPath"))

            b = Len(dt.DefaultView.Item(i).Item("DocPath"))

            d = Len(Path.GetFileName(dt.DefaultView.Item(i).Item("DocPath")))
            a = ""
            a = Mid(dt.DefaultView.Item(i).Item("DocPath"), 1, b - d)
            Label1.Text = Path.GetFileName(dt.DefaultView.Item(i).Item("DocPath"))
            Label2.Text = a
            OpenFileDialog1.InitialDirectory = ""

            OpenFileDialog1.InitialDirectory = a

            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                Image = saveAttach()
            Else
                Dim z(0) As Byte
                Image = z

            End If
       
            persist1.Sp_AddParam("@MainId_1", SqlDbType.Int, dt.DefaultView.Item(i).Item("MainId"), ParameterDirection.Input)
            persist1.Sp_AddParam("@DocPathNew_2", SqlDbType.Image, Image, ParameterDirection.Input)
            persist1.Sp_Exe("Sp_tbISODocuments_UpdPathNew", CnnString, True)

        Next
    End Sub
End Class
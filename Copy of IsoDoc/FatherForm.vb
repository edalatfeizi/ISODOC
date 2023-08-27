
Public Class FatherForm
    Dim mFilePath As String
    Friend OpenMode As Module1.Mode
    Public Property FilePath() As String
        Get
            Return mFilePath
        End Get
        Set(ByVal value As String)
            mFilePath = value
        End Set
    End Property

    Private Sub FatherForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Select Case OpenMode
            Case Module1.Mode.User
                AxOfficeViewer1.Open(FilePath, "Word.Document", "sgdfgdfga", "afarinesh")
                If OpenMode = 1 Then
                    AxOfficeViewer1.OfficeProtectDocument()
                    AxOfficeViewer1.OfficeToolbarVisible("Standard", False)
                    AxOfficeViewer1.OfficeToolbarVisible("Formatting", False)
                    AxOfficeViewer1.OfficeToolbarVisible("Drawing", False)
                    AxOfficeViewer1.OfficeToolbarVisible("Tables and Borders", False)
                    AxOfficeViewer1.Menubar = False
                    AxOfficeViewer1.AllowDrop = False
                    AxOfficeViewer1.DisableCopyHotKey(True)
                    AxOfficeViewer1.DisableFileHotKey(True)
                    AxOfficeViewer1.DisableSaveHotKey(True)
                    AxOfficeViewer1.DisablePrintHotKey(True)
                    Dim x As New System.Windows.Forms.Control
                    For Each x In AxOfficeViewer1.Controls
                        x.Enabled = False
                    Next
                End If
        End Select
    End Sub
End Class

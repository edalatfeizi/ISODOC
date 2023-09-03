Public Class Bus_MessageHandler
    Dim FileInfo As System.IO.FileInfo
    Dim FileExt As String

    Friend Function GetFileExtension(ByVal FilePath As String) As String
        Try
            FileInfo = FileIO.FileSystem.GetFileInfo(FilePath)
            FileExt = FileInfo.Extension
            Select Case FileExt
                Case ".pdf"
                    GetFileExtension = "Acrobat Reader"

                Case ".doc", ".rtf", ".xls"
                    GetFileExtension = "Office"

                Case ".dwg"
                    GetFileExtension = "AutoCad"
                Case ".model"
                    GetFileExtension = "Catia"
                Case Else
                    GetFileExtension = ""
            End Select
        Catch ex As Exception
            GetFileExtension = ""
        End Try
    End Function



End Class

Public Class StartSystem
    Sub New(ByVal newLogID As String, ByVal newLogType As Boolean, ByVal newPasw As String)
        LogID = newLogID
        Pasw = newPasw
        LogType = newLogType

        'If newLogType = "False" Then
        '    CnnString = "packet size=4096;integrated security=SSPI;data source=SQLSRV;persist security info=False;initial catalog=Isodoc_New" '860917'
        'ElseIf newLogType = "True" Then
        '    CnnString = "packet size=4096;user id=" & newLogID.Trim & ";data source=SQLSRV;persist security info=False;" & "PWD=" & newPasw & ";initial catalog=Isodoc_New"
        'End If
        LogID = Val(newLogID)


        'ConString = "packet size=4096;user id=sa;Password=afarinesh;data source=SQLSRV;persist security info=False;initial catalog=InfoServices"
        'LogID = 103
        ' AppID = 3
    End Sub
    Sub showform()
        Dim f1 As New FrmIsoMain
        f1.ShowDialog()
    End Sub
End Class

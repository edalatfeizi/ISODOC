Public NotInheritable Class Constants

    ' Prevent instantiation
    Private Sub New()
    End Sub

    ' Shared ReadOnly reference 
    Public Shared ReadOnly DeveloperPersonCodes As IReadOnlyList(Of String) =
        New List(Of String) From {
            "14023910",
            "903015"
    }.AsReadOnly()

    Public Shared ReadOnly CEOOfficeBossDepCode As String = "AI0950" ' کد اداره رئیس حوزه مدیر عامل
    Public Shared ReadOnly CEOOfficeSecretaryDepCode As String = "AI0954" 'کد اداره مسئول دفتر مدیرعامل

    Public Shared ReadOnly CEODepCode As String = "A1000" ' کد اداره مدیر عامل
    Public Shared ReadOnly DeputyDepCode As String = "DM1038" ' کد ادراه قائم مقام 

    Public Shared ReadOnly BoardOfDirectorsDepCode As String = "A0000" ' کد اداره هیئت مدیره
End Class

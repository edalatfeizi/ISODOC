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

End Class

Imports System.Linq
Imports System.Runtime.CompilerServices

Module StringExtensions

    <Extension()>
    Public Function IsDeveloper(ByVal value As String) As Boolean
        If String.IsNullOrEmpty(value) Then
            Return False
        End If

        ' Compare case-insensitively
        Return Constants.DeveloperPersonCodes.Contains(value, StringComparer.OrdinalIgnoreCase)
    End Function

End Module


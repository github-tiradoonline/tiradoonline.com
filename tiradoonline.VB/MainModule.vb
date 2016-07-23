Module MainModule

    Sub Main()
        Dim bpColor As String = BloodPressureColor("120/89")

    End Sub

    Public Function BloodPressureColor(ByVal bp As String) As String

        Dim bpArray(1) As String

        bpArray = Split(bp, "/")
        If bpArray(1) >= 90 Then
            Return "#ff0000"
        Else
            Return "#000000"
        End If


    End Function

End Module

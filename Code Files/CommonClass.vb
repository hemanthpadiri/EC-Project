Imports System.Data ' Provides common classes like DataSet.
Imports System.IO
Imports Microsoft.VisualBasic

Class CommonClass

    Public Function Validate() As Integer
        Return 0
    End Function
    Public Sub getValue(ByVal itemCode As Integer)

        Dim codeVal() As Integer = {9999, 3034, 3040, 3035}
        Dim colorVal As String
        For counter As Integer = 0 To codeVal.Count Step 1
            If (itemCode = codeVal(counter)) Then
                Select Case codeVal(counter)
                    Case 9999
                        colorVal = "BRILLIANT WHITE EMULSION"

                    Case 3034
                        colorVal = "OFF-WHITE EMULSION"
                End Select

            End If

        Next
    End Sub
End Class

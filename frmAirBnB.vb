Public Class frmAirBnB
    Const cdecCostPerNight = 79D
    Dim strNumNights As String
    Dim intNumNights As Integer
    Dim decTotalCost As Double

    Private Sub btnDisplayCost_Click(sender As Object, e As EventArgs) Handles btnDisplayCost.Click
        'On click the button displays the the cost of stay
        If IsNumeric(txtNumNights.Text) Then

            intNumNights = Convert.ToInt32(txtNumNights.Text)
            decTotalCost = costCalculate(intNumNights, cdecCostPerNight)
            strNumNights = decTotalCost.ToString("C")

        Else
            MsgBox("Please input a valid number", , "Input Error")
        End If

        lblCost.Text = strNumNights

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click, MyBase.Load
        'On load or when clear button is clicked clears out inputs
        lblCost.Text = "$0.00"
        txtNumNights.Text = ""

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'button closes the form
        Me.Close()
    End Sub

    Private Function costCalculate(x As Integer, y As Integer)
        'calculates the night total x = number of nights and y = cost per night
        Return x * y

    End Function

End Class

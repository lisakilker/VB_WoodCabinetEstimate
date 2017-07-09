Public Class WoodCabinetApp

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtLinearFeet.Text = ""
        lblCostTotal.Text = ""
        radPine.Checked = True
        radOak.Checked = False
        radCherry.Checked = False
        txtLinearFeet.Focus()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'MsgBox("Enter the Linear Feet of the Cabinet", 48, "Input Error")
        Dim decOrderTotal As Decimal = 900D
        Dim blnVip As Boolean = True
        Dim decDiscount As Decimal = 0D

        If blnVip = True Then
            ' blnVip is True
            ' Customer is a VIP
            ' See if order is greater than $500
            If decOrderTotal > 500 Then
                ' Customer is a VIP and order is over $500
                ' Give 25% off
                decDiscount = 0.25D
            Else
                ' Customer is a VIP and order is not over $500
                decDiscount = 0.15D
            End If
        Else
            ' blnVip is not True
            ' Customer is not a VIP
            ' See if order is greater than $999
            If decOrderTotal > 999 Then
                ' Customer is not a VIP and order is over $999
                decDiscount = 0.1D
            Else
                ' Customer is not a VIP and order is not over $999
                decDiscount = 0.05D
            End If
        End If

        MsgBox("Discount rate is " & decDiscount.ToString("P0"))

    End Sub
End Class

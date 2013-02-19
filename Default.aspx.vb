
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub PerformCalButton_Click(sender As Object, e As System.EventArgs) Handles PerformCalButton.Click

        'Specify constant valus
        Const INTEREST_CALCS_PER_YEAR As Integer = 12
        Const PAYMENTS_PER_YEAR As Integer = 12

        'Create Vaiables to hol the values entered by the user
        Dim P As Decimal = LoanAmount.Text
        Dim r As Decimal = InterestRate.Text / 100
        Dim t As Decimal = length.Text

        Dim ratePerPeriod As Decimal
        ratePerPeriod = r / INTEREST_CALCS_PER_YEAR

        Dim payperiods As Integer
        payperiods = t * PAYMENTS_PER_YEAR

        Dim annualRate As Decimal
        annualRate = Math.Exp(INTEREST_CALCS_PER_YEAR * Math.Log(1 + ratePerPeriod)) - 1

        Dim intPerpayment As Decimal
        intPerpayment = (Math.Exp(Math.Log(annualRate + 1) / payperiods) - 1) * payperiods

        'Now compute the total cost of the loan
        Dim intPermoth As Decimal = intPerpayment / PAYMENTS_PER_YEAR

        Dim costPerMonth As Decimal
        costPerMonth = P * intPermoth / (1 - Math.Pow(intPermoth + 1, -payperiods))

        'Display the results in the results Label Web control
        Result.Text = "Your mortgage payment per month is $" & costPerMonth.ToString("#,###.##")


    End Sub
End Class

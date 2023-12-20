Public Class Form1
    Const Regular = 2000
    Const Special = 2500
    Const Supespecial = 5000
    Const Cheese = 500
    Const Bacon = 700
    Const Pepperoni = 800

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim re As String
        Dim oPrice As Integer
        Dim aPrice As Integer
        Dim Member As Integer

        If rdbRegular.Checked = True Then
            oPrice = Regular * txtQuantity.Text
        ElseIf rdbSpecial.Checked = True Then
            oPrice = Special * txtQuantity.Text
        ElseIf rdbSuperspecial.Checked = True Then
            oPrice = Supespecial * txtQuantity.Text
        End If

        If chbBacon.Checked = True Then
            aPrice = Cheese * txtQuantity.Text
        ElseIf chbBacon.Checked = True Then
            aPrice = Bacon * txtQuantity.Text
        ElseIf chbPepperoni.Checked = True Then
            aPrice = Pepperoni * txtQuantity.Text
        End If
        If cboMembership.Text = "Yes" Then
            Member = 5%
        Else
            cboMembership.Text = "No"
        End If

        re = "A teljes összeg: " & " HUF " & oPrice + aPrice - Member & Environment.NewLine
        MessageBox.Show(re, " Pizza Project ", MessageBoxButtons.OK)
    End Sub

End Class

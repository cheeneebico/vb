Public Class Annually
    Dim rate As Decimal
    Dim difference As Decimal

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label23_Click(sender As Object, e As EventArgs) Handles Label23.Click

    End Sub

    Private Sub Annually_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub txtboxntci_TextChanged(sender As Object, e As EventArgs) Handles txtboxntci.TextChanged
        If String.IsNullOrEmpty(txtboxgtci.Text) OrElse String.IsNullOrEmpty(txtboxtotald.Text) OrElse String.IsNullOrEmpty(txtboxntci.Text) Then Exit Sub
        If Not IsNumeric(txtboxtotald.Text) OrElse Not IsNumeric(txtboxgtci.Text) OrElse Not IsNumeric(txtboxntci.Text) Then Exit Sub


        txtboxntci.Text = CDbl(txtboxgtci.Text) - CDbl(txtboxtotald.Text)
    End Sub

    Private Sub txtboxgtci_TextChanged(sender As Object, e As EventArgs) Handles txtboxgtci.TextChanged
        If String.IsNullOrEmpty(txtboxgci.Text) OrElse String.IsNullOrEmpty(txtboxnt.Text) OrElse String.IsNullOrEmpty(txtboxgtci.Text) OrElse String.IsNullOrEmpty(txtboxtotald.Text) OrElse String.IsNullOrEmpty(txtboxntci.Text) Then Exit Sub
        If Not IsNumeric(txtboxgci.Text) OrElse Not IsNumeric(txtboxnt.Text) OrElse Not IsNumeric(txtboxtotald.Text) OrElse Not IsNumeric(txtboxgtci.Text) OrElse Not IsNumeric(txtboxntci.Text) Then Exit Sub

        txtboxgtci.Text = CDbl(txtboxgci.Text) - CDbl(txtboxnt.Text)
        txtboxntci.Text = CDbl(txtboxgtci.Text) - CDbl(txtboxtotald.Text)
    End Sub

    Private Sub txtboxgci_TextChanged(sender As Object, e As EventArgs) Handles txtboxgci.TextChanged
        If String.IsNullOrEmpty(txtboxgci.Text) OrElse String.IsNullOrEmpty(txtboxnt.Text) Then Exit Sub
        If Not IsNumeric(txtboxgci.Text) OrElse Not IsNumeric(txtboxnt.Text) Then Exit Sub

        txtboxgtci.Text = CDbl(txtboxgci.Text) - CDbl(txtboxnt.Text)
    End Sub

    Private Sub txtboxnt_TextChanged(sender As Object, e As EventArgs) Handles txtboxnt.TextChanged
        If String.IsNullOrEmpty(txtboxgci.Text) OrElse String.IsNullOrEmpty(txtboxnt.Text) Then Exit Sub
        If Not IsNumeric(txtboxgci.Text) OrElse Not IsNumeric(txtboxnt.Text) Then Exit Sub

        txtboxgtci.Text = CDbl(txtboxgci.Text) - CDbl(txtboxnt.Text)
    End Sub

    Private Sub txtboxtotald_TextChanged(sender As Object, e As EventArgs) Handles txtboxtotald.TextChanged
      If String.IsNullOrEmpty(txtboxgtci.Text) OrElse String.IsNullOrEmpty(txtboxtotald.Text) OrElse String.IsNullOrEmpty(txtboxntci.Text) Then Exit Sub
        If Not IsNumeric(txtboxtotald.Text) OrElse Not IsNumeric(txtboxgtci.Text) OrElse Not IsNumeric(txtboxntci.Text) Then Exit Sub

        txtboxntci.Text = CDbl(txtboxgtci.Text) - CDbl(txtboxtotald.Text)
    End Sub

    Private Sub txtboxnetsrrf_TextChanged(sender As Object, e As EventArgs) Handles txtboxnetsrrf.TextChanged
        If String.IsNullOrEmpty(txtboxnetsrrf.Text) OrElse String.IsNullOrEmpty(txtboxosd.Text) Then Exit Sub
        If Not IsNumeric(txtboxnetsrrf.Text) OrElse Not IsNumeric(txtboxosd.Text) Then Exit Sub

        txtboxosd.Text = CDbl(txtboxnetsrrf.Text) * 0.4
    End Sub

    Private Sub txtboxotiosft_TextChanged(sender As Object, e As EventArgs) Handles txtboxotiosft.TextChanged
        If String.IsNullOrEmpty(txtboxnetsrrf.Text) OrElse String.IsNullOrEmpty(txtboxotiosft.Text) Then Exit Sub
        If Not IsNumeric(txtboxnetsrrf.Text) OrElse Not IsNumeric(txtboxotiosft.Text) Then Exit Sub

        txtboxtotalsrrf.Text = CDbl(txtboxnetsrrf.Text) + CDbl(txtboxotiosft.Text)
    End Sub

    Private Sub txtboxtotalsrrf_TextChanged(sender As Object, e As EventArgs) Handles txtboxtotalsrrf.TextChanged
        If String.IsNullOrEmpty(txtboxnetsrrf.Text) OrElse String.IsNullOrEmpty(txtboxotiosft.Text) Then Exit Sub
        If Not IsNumeric(txtboxnetsrrf.Text) OrElse Not IsNumeric(txtboxotiosft.Text) Then Exit Sub

        txtboxtotalsrrf.Text = CDbl(txtboxnetsrrf.Text) + CDbl(txtboxotiosft.Text)
    End Sub

    Private Sub txtboxcos_TextChanged(sender As Object, e As EventArgs) Handles txtboxcos.TextChanged
        If String.IsNullOrEmpty(txtboxcos.Text) OrElse String.IsNullOrEmpty(txtboxgibp.Text) Then Exit Sub
        If Not IsNumeric(txtboxcos.Text) OrElse Not IsNumeric(txtboxgibp.Text) Then Exit Sub

        txtboxgibp.Text = CDbl(txtboxtotalsrrf.Text) - CDbl(txtboxcos.Text)
    End Sub

    Private Sub txtboxgibp_TextChanged(sender As Object, e As EventArgs) Handles txtboxgibp.TextChanged
        If String.IsNullOrEmpty(txtboxcos.Text) OrElse String.IsNullOrEmpty(txtboxgibp.Text) Then Exit Sub
        If Not IsNumeric(txtboxcos.Text) OrElse Not IsNumeric(txtboxgibp.Text) Then Exit Sub

        txtboxgibp.Text = CDbl(txtboxtotalsrrf.Text) - CDbl(txtboxcos.Text)
    End Sub

    Private Sub txtboxnoi_TextChanged(sender As Object, e As EventArgs) Handles txtboxnoi.TextChanged
        If String.IsNullOrEmpty(txtboxnoi.Text) OrElse String.IsNullOrEmpty(txtboxtgi.Text) Then Exit Sub
        If Not IsNumeric(txtboxnoi.Text) OrElse Not IsNumeric(txtboxtgi.Text) Then Exit Sub

        txtboxtgi.Text = CDbl(txtboxgibp.Text) + CDbl(txtboxnoi.Text)
    End Sub

    Private Sub txtboxtgi_TextChanged(sender As Object, e As EventArgs) Handles txtboxtgi.TextChanged
        If String.IsNullOrEmpty(txtboxnoi.Text) OrElse String.IsNullOrEmpty(txtboxtgi.Text) Then Exit Sub
        If Not IsNumeric(txtboxnoi.Text) OrElse Not IsNumeric(txtboxtgi.Text) Then Exit Sub

        txtboxtgi.Text = CDbl(txtboxgibp.Text) + CDbl(txtboxnoi.Text)

    End Sub

    Private Sub txtboxtaid_TextChanged(sender As Object, e As EventArgs) Handles txtboxtaid.TextChanged
        If String.IsNullOrEmpty(txtboxtaid.Text) OrElse String.IsNullOrEmpty(txtboxtgi.Text) OrElse String.IsNullOrEmpty(txtboxosd.Text) OrElse String.IsNullOrEmpty(txtboxtaxibp.Text) Then Exit Sub
        If Not IsNumeric(txtboxtaid.Text) OrElse Not IsNumeric(txtboxtgi.Text) OrElse Not IsNumeric(txtboxosd.Text) OrElse Not IsNumeric(txtboxtaxibp.Text) Then Exit Sub

        txtboxtaxibp.Text = CDbl(txtboxtgi.Text) - CDbl(txtboxtaid.Text)
    End Sub

    Private Sub txtboxosd_TextChanged(sender As Object, e As EventArgs) Handles txtboxosd.TextChanged
        If String.IsNullOrEmpty(txtboxnetsrrf.Text) OrElse String.IsNullOrEmpty(txtboxosd.Text) OrElse String.IsNullOrEmpty(txtboxtaxibp.Text) Then Exit Sub
        If Not IsNumeric(txtboxnetsrrf.Text) OrElse Not IsNumeric(txtboxosd.Text) Then Exit Sub

        txtboxosd.Text = txtboxnetsrrf.Text
    End Sub

    Private Sub txtboxtaxibp_TextChanged(sender As Object, e As EventArgs) Handles txtboxtaxibp.TextChanged
        If String.IsNullOrEmpty(txtboxtgi.Text) OrElse String.IsNullOrEmpty(txtboxtaid.Text) OrElse String.IsNullOrEmpty(txtboxosd.Text) OrElse String.IsNullOrEmpty(txtboxtaxibp.Text) Then Exit Sub
        If Not IsNumeric(txtboxtgi.Text) OrElse Not IsNumeric(txtboxtaid.Text) OrElse Not IsNumeric(txtboxosd.Text) OrElse Not IsNumeric(txtboxtaxibp.Text) Then Exit Sub

        txtboxtaxibp.Text = CDbl(txtboxtgi.Text) - CDbl(txtboxtaid.Text)
    End Sub

    Private Sub txtboxnettci_TextChanged(sender As Object, e As EventArgs) Handles txtboxnettci.TextChanged
       
    End Sub

    Private Sub txtboxnettaxi_TextChanged(sender As Object, e As EventArgs) Handles txtboxnettaxi.TextChanged
        If String.IsNullOrEmpty(txtboxtaxibp.Text) OrElse String.IsNullOrEmpty(txtboxtaid.Text) OrElse String.IsNullOrEmpty(txtboxosd.Text) OrElse String.IsNullOrEmpty(txtboxtaxibp.Text) Then Exit Sub
        If Not IsNumeric(txtboxtaxibp.Text) OrElse Not IsNumeric(txtboxnettci.Text) OrElse Not IsNumeric(txtboxnettaxi.Text) OrElse Not IsNumeric(txtboxtaxibp.Text) Then Exit Sub

        txtboxnettaxi.Text = CDbl(txtboxtaxibp.Text) + CDbl(txtboxnettci.Text)
    End Sub

    Private Sub txtboxtotaltaxincome_TextChanged(sender As Object, e As EventArgs) Handles txtboxtotaltaxincome.TextChanged
        If String.IsNullOrEmpty(txtboxtgi.Text) OrElse String.IsNullOrEmpty(txtboxtaid.Text) OrElse String.IsNullOrEmpty(txtboxosd.Text) OrElse String.IsNullOrEmpty(txtboxtaxibp.Text) Then Exit Sub
        If Not IsNumeric(txtboxtgi.Text) OrElse Not IsNumeric(txtboxtaid.Text) OrElse Not IsNumeric(txtboxosd.Text) OrElse Not IsNumeric(txtboxtaxibp.Text) Then Exit Sub

        txtboxtotaltaxincome.Text = CDbl(txtboxnettaxi.Text) - CDbl(txtboxetifany.Text)
    End Sub

    Private Sub txtboxed_TextChanged(sender As Object, e As EventArgs) Handles txtboxed.TextChanged

    End Sub

    Private Sub txtboxetifany_TextChanged(sender As Object, e As EventArgs) Handles txtboxetifany.TextChanged
        If String.IsNullOrEmpty(txtboxed.Text) OrElse String.IsNullOrEmpty(txtboxetifany.Text) Then Exit Sub
        If Not IsNumeric(txtboxed.Text) OrElse Not IsNumeric(txtboxetifany.Text) Then Exit Sub

        txtboxetifany.Text = CDbl(txtboxed.Text)

    End Sub

    Private Sub txtboxtaxduereg_TextChanged(sender As Object, e As EventArgs) Handles txtboxtaxduereg.TextChanged
        Dim tbval As Decimal

        If Not Decimal.TryParse(txtboxtotaltaxincome.Text, tbval) Then
            MessageBox.Show("Not a valid number.")
        End If

        If tbval >= 0 AndAlso tbval <= 10000 Then
            txtboxtaxduereg.Text = tbval * 0.05
        ElseIf tbval >= 10000 AndAlso tbval <= 30000 Then
            difference = tbval - 10000
            rate = difference * 0.1
            tbval = rate + 500
        ElseIf tbval >= 30000 AndAlso tbval <= 70000 Then
            difference = tbval - 30000
            rate = difference * 0.15
            tbval = rate + 2500
        ElseIf tbval >= 70000 AndAlso tbval <= 140000 Then
            difference = tbval - 70000
            rate = difference * 0.2
            tbval = rate + 8500
        ElseIf tbval >= 140000 AndAlso tbval <= 250000 Then
            difference = tbval - 140000
            rate = difference * 0.25
            tbval = rate + 22500
        ElseIf tbval >= 250000 AndAlso tbval <= 500000 Then
            difference = tbval - 250000
            rate = difference * 0.3
            tbval = rate + 50000
        ElseIf tbval >= 500000 AndAlso tbval <= 999999999999999 Then
            difference = tbval - 500000
            rate = difference * 0.32
            tbval = rate + 125000
        End If

        txtboxtaxduereg.Text = tbval.ToString()
    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label26_Click(sender As Object, e As EventArgs) Handles Label26.Click

    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub
End Class

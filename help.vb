Public Class Help

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try
            VisitLink1()
        Catch ex As Exception
            MessageBox.Show("Unable to open the link that was clicked.")
        End Try
    End Sub
    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Try
            VisitLink2()
        Catch ex As Exception
            MessageBox.Show("Unable to open the link that was clicked.")
        End Try
    End Sub

    Sub VisitLink1()
        LinkLabel1.LinkVisited = True
        System.Diagnostics.Process.Start("http://forums.d2jsp.org/user.php?i=385559")

    End Sub
    Sub VisitLink2()
        LinkLabel2.LinkVisited = True
        System.Diagnostics.Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=VXAQUDQLPC2AE&lc=AU&item_name=PoE%20FG%20Calc&item_number=FGCalc&currency_code=AUD&bn=PP%2dDonationsBF%3abtn_donate_SM%2egif%3aNonHosted")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub
End Class

Public Class WELCOME
    Dim user, pw As String

    Private Sub lgi_Click(sender As Object, e As EventArgs) Handles lgi.Click
        user = user1.Text
        pw = psw.Text

        If user = "maria2" And pw = "SpaceApp" Then
            MsgBox("Welcome to your Space")
            SCINCO.Show()
            Me.Hide()
        Else
            MsgBox("User or password incorrect")
        End If
    End Sub

    Private Sub sp_Click(sender As Object, e As EventArgs) Handles sp.Click
        Register.Show()
        me.hide
    End Sub


End Class

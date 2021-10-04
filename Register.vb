Public Class Register

    Dim fn, un, psw, em, reg As String
    Private Sub sp2_Click(sender As Object, e As EventArgs) Handles sp2.Click
        fn = fname.Text
        un = uname.Text
        psw = psw2.Text
        em = email.Text
        reg = rg.Text

        MsgBox("Account registered successfully, welcome!")

        SCINCO.Show()
        Me.Hide()

    End Sub
End Class
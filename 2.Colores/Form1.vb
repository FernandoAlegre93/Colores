Public Class Form1

    Private Sub btnIngreso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngreso.Click
        lblTexto.Text = txtIntroducir.Text
        txtIntroducir.Text = ""
    End Sub

    Private Sub rdbtnRojo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbtnRojo.CheckedChanged
        lblTexto.ForeColor = Color.Red
    End Sub

    Private Sub rdbtnVerde_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbtnVerde.CheckedChanged
        lblTexto.ForeColor = Color.Green
    End Sub

    Private Sub rdbtnAmarillo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbtnAmarillo.CheckedChanged
        lblTexto.ForeColor = Color.Yellow

    End Sub

    Private Sub rdbtnAzul_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbtnAzul.CheckedChanged
        lblTexto.BackColor = Color.Blue

    End Sub

    Private Sub rdbtnViol_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbtnViol.CheckedChanged
        lblTexto.BackColor = Color.Violet

    End Sub

    Private Sub rdbtnRosa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbtnRosa.CheckedChanged
        lblTexto.BackColor = Color.Pink
    End Sub

    Private Sub btnOcultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOcultar.Click
        lblTexto.Visible = False

    End Sub

    Private Sub btnVer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVer.Click
        lblTexto.Visible = True
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub
End Class

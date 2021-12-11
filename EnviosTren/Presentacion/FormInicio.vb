Public Class FormInicio
    Private Sub btnSeleccionarBD_Click(sender As Object, e As EventArgs) Handles btnSeleccionarBD.Click
        Me.ofdRuta.InitialDirectory = Application.StartupPath
        If (Me.ofdRuta.ShowDialog() = DialogResult.OK) Then
            Me.txtRuta.Text = Me.ofdRuta.FileName
            Me.btnConectarBD.Enabled = True
        End If
    End Sub

    Private Sub btnConectarBD_Click(sender As Object, e As EventArgs) Handles btnConectarBD.Click
        Dim prod As Producto = New Producto

        Try
            prod.LeerTodosProductos(Me.ofdRuta.FileName)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        Me.btnConectarBD.Enabled = False
        Me.btnSeleccionarBD.Enabled = False
        Me.btnGestionarD.Visible = True
        Me.btnConsultas.Visible = True
        Me.lblConectado.Visible = True
    End Sub

    Private Sub btnGestionarD_Click(sender As Object, e As EventArgs) Handles btnGestionarD.Click
        FormGestionDatos.ShowDialog()
    End Sub

    Private Sub btnConsultas_Click(sender As Object, e As EventArgs) Handles btnConsultas.Click
        FormConsultas.ShowDialog()
    End Sub
End Class

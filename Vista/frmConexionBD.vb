
Public Class frmConexionBD

    Dim objLogica As New Logica.nGeneral

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim TextoConfig As String = txtServer.Text & "," &
                                    txtPuerto.Text & "," &
                                    txtNombre.Text & "," &
                                    txtUsuario.Text & "," &
                                    txtContrasenia.Text

        System.IO.File.WriteAllText("DatosBD.cfg", TextoConfig)

        objLogica.ConfigurarBD()

        Me.Close()
    End Sub

    Private Sub frmConexionBD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim TextoConfig As String = System.IO.File.ReadAllText("DatosBD.cfg")
        Dim strConfig() As String = Split(TextoConfig, ",")

        Dim lastNonEmpty As Integer = -1
        For i As Integer = 0 To strConfig.Length - 1
            If strConfig(i) <> "" Then
                lastNonEmpty += 1
                strConfig(lastNonEmpty) = strConfig(i)
            End If
        Next
        ReDim Preserve strConfig(lastNonEmpty)

        txtServer.Text = strConfig(0)
        txtPuerto.Text = strConfig(1)
        txtNombre.Text = strConfig(2)
        txtUsuario.Text = strConfig(3)
        txtContrasenia.Text = strConfig(4)
    End Sub
End Class
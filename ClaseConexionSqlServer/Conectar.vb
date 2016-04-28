Imports System.Data.SqlClient
Public Class Conectar
    Dim conex As New ClsConexion
    Private Sub cmdConectar_Click(sender As Object, e As EventArgs) Handles cmdConectar.Click
        Try
            conex.Usuario = txtUsu.Text.Trim
            conex.Clave = txtPass.Text.Trim
            conex.Servidor = txtServer.Text.Trim
            conex.BaseDatos = txtBd.Text.Trim
            conex.Conectar()
            limpiar()
        Catch ex As SqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function limpiar()
        txtBd.Clear()
        txtPass.Clear()
        txtServer.Clear()
        txtUsu.Clear()
    End Function
End Class
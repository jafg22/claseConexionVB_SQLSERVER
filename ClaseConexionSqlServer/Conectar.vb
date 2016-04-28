﻿Imports System.Data.SqlClient
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
            MsgBox("Conexión hecha correctamente")
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


   
    Private Sub txtUsu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsu.KeyPress
        txtPass.Focus()
    End Sub
    Private Sub txtPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPass.KeyPress
        txtBd.Focus()
    End Sub
    Private Sub txtBd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBd.KeyPress
        txtServer.Focus()
    End Sub
End Class
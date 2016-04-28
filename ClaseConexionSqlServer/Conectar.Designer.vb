<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Conectar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmdConectar = New System.Windows.Forms.Button()
        Me.cmdDesconectar = New System.Windows.Forms.Button()
        Me.lblUsu = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.lblBd = New System.Windows.Forms.Label()
        Me.lblSer = New System.Windows.Forms.Label()
        Me.txtUsu = New System.Windows.Forms.TextBox()
        Me.txtBd = New System.Windows.Forms.TextBox()
        Me.txtServer = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmdConectar
        '
        Me.cmdConectar.Location = New System.Drawing.Point(15, 136)
        Me.cmdConectar.Name = "cmdConectar"
        Me.cmdConectar.Size = New System.Drawing.Size(87, 23)
        Me.cmdConectar.TabIndex = 0
        Me.cmdConectar.Text = "Conectar"
        Me.cmdConectar.UseVisualStyleBackColor = True
        '
        'cmdDesconectar
        '
        Me.cmdDesconectar.Location = New System.Drawing.Point(122, 136)
        Me.cmdDesconectar.Name = "cmdDesconectar"
        Me.cmdDesconectar.Size = New System.Drawing.Size(88, 23)
        Me.cmdDesconectar.TabIndex = 1
        Me.cmdDesconectar.Text = "Desconectar"
        Me.cmdDesconectar.UseVisualStyleBackColor = True
        '
        'lblUsu
        '
        Me.lblUsu.AutoSize = True
        Me.lblUsu.Location = New System.Drawing.Point(12, 9)
        Me.lblUsu.Name = "lblUsu"
        Me.lblUsu.Size = New System.Drawing.Size(43, 13)
        Me.lblUsu.TabIndex = 2
        Me.lblUsu.Text = "Usuario"
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Location = New System.Drawing.Point(12, 41)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(53, 13)
        Me.lblPass.TabIndex = 3
        Me.lblPass.Text = "Password"
        '
        'lblBd
        '
        Me.lblBd.AutoSize = True
        Me.lblBd.Location = New System.Drawing.Point(12, 70)
        Me.lblBd.Name = "lblBd"
        Me.lblBd.Size = New System.Drawing.Size(77, 13)
        Me.lblBd.TabIndex = 4
        Me.lblBd.Text = "Base de Datos"
        '
        'lblSer
        '
        Me.lblSer.AutoSize = True
        Me.lblSer.Location = New System.Drawing.Point(12, 104)
        Me.lblSer.Name = "lblSer"
        Me.lblSer.Size = New System.Drawing.Size(46, 13)
        Me.lblSer.TabIndex = 5
        Me.lblSer.Text = "Servidor"
        '
        'txtUsu
        '
        Me.txtUsu.Location = New System.Drawing.Point(61, 9)
        Me.txtUsu.Name = "txtUsu"
        Me.txtUsu.Size = New System.Drawing.Size(134, 20)
        Me.txtUsu.TabIndex = 6
        '
        'txtBd
        '
        Me.txtBd.Location = New System.Drawing.Point(95, 67)
        Me.txtBd.Name = "txtBd"
        Me.txtBd.Size = New System.Drawing.Size(100, 20)
        Me.txtBd.TabIndex = 8
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(64, 101)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(131, 20)
        Me.txtServer.TabIndex = 9
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(71, 38)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(124, 20)
        Me.txtPass.TabIndex = 10
        '
        'Conectar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(219, 176)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtServer)
        Me.Controls.Add(Me.txtBd)
        Me.Controls.Add(Me.txtUsu)
        Me.Controls.Add(Me.lblSer)
        Me.Controls.Add(Me.lblBd)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.lblUsu)
        Me.Controls.Add(Me.cmdDesconectar)
        Me.Controls.Add(Me.cmdConectar)
        Me.Name = "Conectar"
        Me.Text = "Conectar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdConectar As System.Windows.Forms.Button
    Friend WithEvents cmdDesconectar As System.Windows.Forms.Button
    Friend WithEvents lblUsu As System.Windows.Forms.Label
    Friend WithEvents lblPass As System.Windows.Forms.Label
    Friend WithEvents lblBd As System.Windows.Forms.Label
    Friend WithEvents lblSer As System.Windows.Forms.Label
    Friend WithEvents txtUsu As System.Windows.Forms.TextBox
    Friend WithEvents txtBd As System.Windows.Forms.TextBox
    Friend WithEvents txtServer As System.Windows.Forms.TextBox
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
End Class

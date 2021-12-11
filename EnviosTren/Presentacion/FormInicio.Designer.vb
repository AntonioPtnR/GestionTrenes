<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormInicio))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.lblBienvenido = New System.Windows.Forms.Label()
        Me.lblBBDD = New System.Windows.Forms.Label()
        Me.ofdRuta = New System.Windows.Forms.OpenFileDialog()
        Me.btnSeleccionarBD = New System.Windows.Forms.Button()
        Me.txtRuta = New System.Windows.Forms.TextBox()
        Me.btnConectarBD = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblConectado = New System.Windows.Forms.Label()
        Me.btnGestionarD = New System.Windows.Forms.Button()
        Me.btnConsultas = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1064, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'lblBienvenido
        '
        Me.lblBienvenido.AutoSize = True
        Me.lblBienvenido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBienvenido.Location = New System.Drawing.Point(12, 24)
        Me.lblBienvenido.Name = "lblBienvenido"
        Me.lblBienvenido.Size = New System.Drawing.Size(820, 24)
        Me.lblBienvenido.TabIndex = 1
        Me.lblBienvenido.Text = "Bienvenido a la aplicación de gestión de envíos de mercancías mediante ferrocarri" &
    "les. "
        '
        'lblBBDD
        '
        Me.lblBBDD.AllowDrop = True
        Me.lblBBDD.AutoEllipsis = True
        Me.lblBBDD.Location = New System.Drawing.Point(13, 84)
        Me.lblBBDD.Name = "lblBBDD"
        Me.lblBBDD.Size = New System.Drawing.Size(542, 83)
        Me.lblBBDD.TabIndex = 2
        Me.lblBBDD.Text = resources.GetString("lblBBDD.Text")
        '
        'btnSeleccionarBD
        '
        Me.btnSeleccionarBD.Location = New System.Drawing.Point(16, 219)
        Me.btnSeleccionarBD.Name = "btnSeleccionarBD"
        Me.btnSeleccionarBD.Size = New System.Drawing.Size(162, 30)
        Me.btnSeleccionarBD.TabIndex = 3
        Me.btnSeleccionarBD.Text = "Seleccionar ruta"
        Me.btnSeleccionarBD.UseVisualStyleBackColor = True
        '
        'txtRuta
        '
        Me.txtRuta.Enabled = False
        Me.txtRuta.Location = New System.Drawing.Point(16, 279)
        Me.txtRuta.Multiline = True
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.Size = New System.Drawing.Size(210, 115)
        Me.txtRuta.TabIndex = 4
        '
        'btnConectarBD
        '
        Me.btnConectarBD.Enabled = False
        Me.btnConectarBD.Location = New System.Drawing.Point(15, 427)
        Me.btnConectarBD.Name = "btnConectarBD"
        Me.btnConectarBD.Size = New System.Drawing.Size(98, 43)
        Me.btnConectarBD.TabIndex = 5
        Me.btnConectarBD.Text = "Conectar "
        Me.btnConectarBD.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(603, 72)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(403, 398)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'lblConectado
        '
        Me.lblConectado.AutoSize = True
        Me.lblConectado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConectado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblConectado.Location = New System.Drawing.Point(136, 438)
        Me.lblConectado.Name = "lblConectado"
        Me.lblConectado.Size = New System.Drawing.Size(90, 18)
        Me.lblConectado.TabIndex = 7
        Me.lblConectado.Text = "Conectado"
        Me.lblConectado.Visible = False
        '
        'btnGestionarD
        '
        Me.btnGestionarD.Location = New System.Drawing.Point(331, 219)
        Me.btnGestionarD.Name = "btnGestionarD"
        Me.btnGestionarD.Size = New System.Drawing.Size(207, 91)
        Me.btnGestionarD.TabIndex = 8
        Me.btnGestionarD.Text = "Gestionar datos"
        Me.btnGestionarD.UseVisualStyleBackColor = True
        Me.btnGestionarD.Visible = False
        '
        'btnConsultas
        '
        Me.btnConsultas.Location = New System.Drawing.Point(331, 316)
        Me.btnConsultas.Name = "btnConsultas"
        Me.btnConsultas.Size = New System.Drawing.Size(207, 91)
        Me.btnConsultas.TabIndex = 9
        Me.btnConsultas.Text = "Consultas"
        Me.btnConsultas.UseVisualStyleBackColor = True
        Me.btnConsultas.Visible = False
        '
        'FormInicio
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 556)
        Me.Controls.Add(Me.btnConsultas)
        Me.Controls.Add(Me.btnGestionarD)
        Me.Controls.Add(Me.lblConectado)
        Me.Controls.Add(Me.lblBBDD)
        Me.Controls.Add(Me.lblBienvenido)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnConectarBD)
        Me.Controls.Add(Me.btnSeleccionarBD)
        Me.Controls.Add(Me.txtRuta)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FormInicio"
        Me.Text = "Inicio"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents lblBienvenido As Label
    Friend WithEvents lblBBDD As Label
    Friend WithEvents ofdRuta As OpenFileDialog
    Friend WithEvents btnSeleccionarBD As Button
    Friend WithEvents txtRuta As TextBox
    Friend WithEvents btnConectarBD As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblConectado As Label
    Friend WithEvents btnGestionarD As Button
    Friend WithEvents btnConsultas As Button
End Class

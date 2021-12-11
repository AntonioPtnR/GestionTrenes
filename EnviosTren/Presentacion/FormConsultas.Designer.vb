<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConsultas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormConsultas))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.btnC1 = New System.Windows.Forms.Button()
        Me.btnC2 = New System.Windows.Forms.Button()
        Me.btnC3 = New System.Windows.Forms.Button()
        Me.btnC4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblFI = New System.Windows.Forms.Label()
        Me.lblFF = New System.Windows.Forms.Label()
        Me.lblNViajes = New System.Windows.Forms.Label()
        Me.lblTren = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.cmbTren = New System.Windows.Forms.ComboBox()
        Me.txtNViajes = New System.Windows.Forms.TextBox()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(588, 143)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(540, 355)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        Me.ListView1.Visible = False
        '
        'btnC1
        '
        Me.btnC1.Location = New System.Drawing.Point(27, 173)
        Me.btnC1.Name = "btnC1"
        Me.btnC1.Size = New System.Drawing.Size(124, 36)
        Me.btnC1.TabIndex = 1
        Me.btnC1.Text = "Consulta 1"
        Me.btnC1.UseVisualStyleBackColor = True
        '
        'btnC2
        '
        Me.btnC2.Location = New System.Drawing.Point(27, 267)
        Me.btnC2.Name = "btnC2"
        Me.btnC2.Size = New System.Drawing.Size(124, 36)
        Me.btnC2.TabIndex = 2
        Me.btnC2.Text = "Consulta 2"
        Me.btnC2.UseVisualStyleBackColor = True
        '
        'btnC3
        '
        Me.btnC3.Location = New System.Drawing.Point(27, 361)
        Me.btnC3.Name = "btnC3"
        Me.btnC3.Size = New System.Drawing.Size(124, 36)
        Me.btnC3.TabIndex = 3
        Me.btnC3.Text = "Consulta 3"
        Me.btnC3.UseVisualStyleBackColor = True
        '
        'btnC4
        '
        Me.btnC4.Location = New System.Drawing.Point(27, 462)
        Me.btnC4.Name = "btnC4"
        Me.btnC4.Size = New System.Drawing.Size(124, 36)
        Me.btnC4.TabIndex = 4
        Me.btnC4.Text = "Consulta 4"
        Me.btnC4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(583, 102)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 68)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Consulta 1:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Consulta 2:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Consulta 3:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Consulta 4:"
        '
        'lblFI
        '
        Me.lblFI.AutoSize = True
        Me.lblFI.Location = New System.Drawing.Point(237, 143)
        Me.lblFI.Name = "lblFI"
        Me.lblFI.Size = New System.Drawing.Size(83, 17)
        Me.lblFI.TabIndex = 7
        Me.lblFI.Text = "Fecha inicio"
        Me.lblFI.Visible = False
        '
        'lblFF
        '
        Me.lblFF.AutoSize = True
        Me.lblFF.Location = New System.Drawing.Point(237, 243)
        Me.lblFF.Name = "lblFF"
        Me.lblFF.Size = New System.Drawing.Size(66, 17)
        Me.lblFF.TabIndex = 8
        Me.lblFF.Text = "Fecha fin"
        Me.lblFF.Visible = False
        '
        'lblNViajes
        '
        Me.lblNViajes.AutoSize = True
        Me.lblNViajes.Location = New System.Drawing.Point(237, 437)
        Me.lblNViajes.Name = "lblNViajes"
        Me.lblNViajes.Size = New System.Drawing.Size(118, 17)
        Me.lblNViajes.TabIndex = 9
        Me.lblNViajes.Text = "Número de viajes"
        Me.lblNViajes.Visible = False
        '
        'lblTren
        '
        Me.lblTren.AutoSize = True
        Me.lblTren.Location = New System.Drawing.Point(237, 338)
        Me.lblTren.Name = "lblTren"
        Me.lblTren.Size = New System.Drawing.Size(38, 17)
        Me.lblTren.TabIndex = 10
        Me.lblTren.Text = "Tren"
        Me.lblTren.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(240, 178)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 11
        Me.DateTimePicker1.Visible = False
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(240, 272)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker2.TabIndex = 12
        Me.DateTimePicker2.Visible = False
        '
        'cmbTren
        '
        Me.cmbTren.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTren.FormattingEnabled = True
        Me.cmbTren.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmbTren.Location = New System.Drawing.Point(240, 368)
        Me.cmbTren.Name = "cmbTren"
        Me.cmbTren.Size = New System.Drawing.Size(200, 24)
        Me.cmbTren.TabIndex = 13
        Me.cmbTren.Visible = False
        '
        'txtNViajes
        '
        Me.txtNViajes.Location = New System.Drawing.Point(240, 469)
        Me.txtNViajes.Name = "txtNViajes"
        Me.txtNViajes.ReadOnly = True
        Me.txtNViajes.Size = New System.Drawing.Size(200, 22)
        Me.txtNViajes.TabIndex = 14
        Me.txtNViajes.Visible = False
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(998, 526)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(130, 35)
        Me.btnConsultar.TabIndex = 15
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        Me.btnConsultar.Visible = False
        '
        'FormConsultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1162, 599)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.txtNViajes)
        Me.Controls.Add(Me.cmbTren)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lblTren)
        Me.Controls.Add(Me.lblNViajes)
        Me.Controls.Add(Me.lblFF)
        Me.Controls.Add(Me.lblFI)
        Me.Controls.Add(Me.btnC4)
        Me.Controls.Add(Me.btnC3)
        Me.Controls.Add(Me.btnC2)
        Me.Controls.Add(Me.btnC1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormConsultas"
        Me.Text = "FormConsultas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents btnC1 As Button
    Friend WithEvents btnC2 As Button
    Friend WithEvents btnC3 As Button
    Friend WithEvents btnC4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblFI As Label
    Friend WithEvents lblFF As Label
    Friend WithEvents lblNViajes As Label
    Friend WithEvents lblTren As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents cmbTren As ComboBox
    Friend WithEvents txtNViajes As TextBox
    Friend WithEvents btnConsultar As Button
End Class

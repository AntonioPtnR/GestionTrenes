Public Class FormConsultas
    Dim opcionConsulta As Integer

    Private Sub btnC1_Click(sender As Object, e As EventArgs) Handles btnC1.Click
        Me.opcionConsulta = 1
        pulsadoDatos()
        Me.btnC1.BackColor = Color.LightBlue
        consultaNoVisible()
        limpiarCampos()
        comboTrenes()
        entradaDatosC1()
    End Sub

    Private Sub btnC2_Click(sender As Object, e As EventArgs) Handles btnC2.Click
        Me.opcionConsulta = 2
        pulsadoDatos()
        Me.btnC2.BackColor = Color.LightBlue
        consultaNoVisible()
        limpiarCampos()
        entradaDatosC2()
    End Sub

    Private Sub btnC3_Click(sender As Object, e As EventArgs) Handles btnC3.Click
        Me.opcionConsulta = 3
        pulsadoDatos()
        Me.btnC3.BackColor = Color.LightBlue
        consultaNoVisible()
        limpiarCampos()
        entradaDatosC2()
    End Sub

    Private Sub btnC4_Click(sender As Object, e As EventArgs) Handles btnC4.Click
        Me.btnConsultar.Visible = False
        Me.opcionConsulta = 4
        pulsadoDatos()
        Me.btnC4.BackColor = Color.LightBlue
        consultaNoVisible()
        InformacionViajeMasEconomico()
    End Sub

    Private Sub pulsadoDatos()
        btnC1.BackColor = DefaultBackColor
        btnC2.BackColor = DefaultBackColor
        btnC3.BackColor = DefaultBackColor
        btnC4.BackColor = DefaultBackColor
    End Sub

    Private Sub consultaNoVisible()
        Me.lblFI.Visible = False
        Me.lblFF.Visible = False
        Me.lblTren.Visible = False
        Me.lblNViajes.Visible = False
        Me.DateTimePicker1.Visible = False
        Me.DateTimePicker2.Visible = False
        Me.cmbTren.Visible = False
        Me.txtNViajes.Visible = False
        Me.ListView1.Visible = False
    End Sub

    Private Sub limpiarCampos()
        Me.DateTimePicker1.ResetText()
        Me.DateTimePicker2.ResetText()
        Me.cmbTren.Text = ""
        Me.txtNViajes.Text = ""
        ListView1.Clear()
    End Sub

    Private Sub comboTrenes()
        cmbTren.Text = Nothing
        cmbTren.Items.Clear()
        Dim tren As Tren = New Tren
        tren.LeerTodosTrenes()
        For Each t As Tren In tren.TDAO.Trenes
            cmbTren.Items.Add(t.Matricula)
        Next
    End Sub

    Private Sub entradaDatosC1()
        Me.lblFI.Visible = True
        Me.lblFF.Visible = True
        Me.lblTren.Visible = True
        Me.lblNViajes.Visible = True
        Me.DateTimePicker1.Visible = True
        Me.DateTimePicker2.Visible = True
        Me.cmbTren.Visible = True
        Me.txtNViajes.Visible = True
        Me.ListView1.Visible = True
        Me.btnConsultar.Visible = True
    End Sub

    Private Sub entradaDatosC2()
        Me.lblFI.Visible = True
        Me.lblFF.Visible = True
        Me.DateTimePicker1.Visible = True
        Me.DateTimePicker2.Visible = True
        Me.ListView1.Visible = True
        Me.btnConsultar.Visible = True
    End Sub

    Private Sub FormConsultas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnC1.BackColor = DefaultBackColor
        btnC2.BackColor = DefaultBackColor
        btnC3.BackColor = DefaultBackColor
        btnC4.BackColor = DefaultBackColor
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Select Case opcionConsulta
            Case 1
                If cmbTren.Text <> String.Empty Then
                    listaViajes(CDate(Format(Me.DateTimePicker1.Value, "yyyy/MM/dd")), CDate(Format(Me.DateTimePicker2.Value, "yyyy/MM/dd")), Me.cmbTren.Text)

                Else
                    MessageBox.Show("Campos vacíos, inténtelo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Case 2
                RankingTipoTren(CDate(Format(Me.DateTimePicker1.Value, "yyyy/MM/dd")), CDate(Format(Me.DateTimePicker2.Value, "yyyy/MM/dd")))
            Case 3
                RankingProductosEnviados(CDate(Format(Me.DateTimePicker1.Value, "yyyy/MM/dd")), CDate(Format(Me.DateTimePicker2.Value, "yyyy/MM/dd")))
        End Select
    End Sub

    Private Sub listaViajes(fechaI As Date, fechaF As Date, tren As String)
        ListView1.Clear()
        ListView1.Columns.Add("Fecha viaje")
        ListView1.Columns.Add("Producto")
        ListView1.Columns.Add("Descripción del producto")
        ListView1.Columns.Add("Toneladas Transportadas")
        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

        Dim via As Viaje = New Viaje
        Dim nv As Integer = 0
        via.LeerProductosFechas(fechaI, fechaF, tren)
        For Each v As Viaje In via.ViaDAO.Viajes
            Dim lista As ListViewItem = New ListViewItem(CStr(Format(v.FechaViaje, "yyyy/MM/dd")))
            lista.SubItems.Add(CStr(v.Producto.IdProducto))
            lista.SubItems.Add(v.DesProducto)
            lista.SubItems.Add(CStr(v.ToneladasTransportadas))
            ListView1.Items.Add(lista)
            nv += 1
        Next
        Me.txtNViajes.Text = CStr(nv)
    End Sub

    Private Sub RankingTipoTren(fechaI As Date, fechaF As Date)
        ListView1.Clear()
        ListView1.Columns.Add("Identificador")
        ListView1.Columns.Add("Descipción")
        ListView1.Columns.Add("Nº Viajes")
        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

        Dim tt As TipoTren = New TipoTren
        tt.LeerRankingTipoTren(fechaI, fechaF)
        For Each tipot As TipoTren In tt.TTrenDAO.Tipos_Tren
            Dim lista As ListViewItem = New ListViewItem(CStr(tipot.IdTipoTren))
            lista.SubItems.Add(tipot.DescTipoTren)
            lista.SubItems.Add(CStr(tipot.numTT))
            ListView1.Items.Add(lista)
        Next
    End Sub

    Private Sub RankingProductosEnviados(fechaI As Date, fechaF As Date)
        ListView1.Clear()
        ListView1.Columns.Add("Identificador")
        ListView1.Columns.Add("Descripción")
        ListView1.Columns.Add("Nº Envíos")
        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

        Dim prod As Producto = New Producto
        prod.LeerRankingProductos(fechaI, fechaF)
        For Each p As Producto In prod.ProDAO.Productos
            Dim lista As ListViewItem = New ListViewItem(CStr(p.IdProducto))
            lista.SubItems.Add(p.DescripProducto)
            lista.SubItems.Add(CStr(p.numP))
            ListView1.Items.Add(lista)
        Next
    End Sub

    Public Sub InformacionViajeMasEconomico()
        ListView1.Clear()
        ListView1.Columns.Add("Fecha viaje")
        ListView1.Columns.Add("Tren viaje")
        ListView1.Columns.Add("Tipo de Tren")
        ListView1.Columns.Add("Producto")
        ListView1.Columns.Add("Descripción")
        ListView1.Columns.Add("Toneladas")
        ListView1.Columns.Add("Cotización")
        ListView1.Columns.Add("Beneficio")
        ListView1.Visible = True
        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

        Dim via As Viaje = New Viaje
        Dim c As Cotizacion = New Cotizacion
        via.MostrarInfoViajeMaxBeneficio()
        For Each v As Viaje In via.ViaDAO.Viajes
            c.Producto = v.Producto
            Dim lista As ListViewItem = New ListViewItem(CStr(Format(v.FechaViaje, "yyyy/MM/dd")))
            lista.SubItems.Add(CStr(v.Tren.Matricula))
            lista.SubItems.Add(CStr(v.Tren.TipoTren.IdTipoTren))
            lista.SubItems.Add(CStr(v.Producto.IdProducto))
            lista.SubItems.Add(v.Producto.DescripProducto)
            lista.SubItems.Add(CStr(v.ToneladasTransportadas))
            lista.SubItems.Add(CStr(v.Cotizacion))
            lista.SubItems.Add(CStr(v.Beneficio))
            ListView1.Items.Add(lista)
        Next
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Me.btnConsultar.Enabled = True
        If (Format(Me.DateTimePicker1.Value, "yyyy/MM/dd") > Format(Me.DateTimePicker2.Value, "yyyy/MM/dd")) Then
            Me.btnConsultar.Enabled = False
        End If
    End Sub
End Class
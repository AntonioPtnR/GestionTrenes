Public Class FormGestionDatos
    Dim accion As Integer
    Dim opcionDatos As Integer

    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        Me.accion = 1
        pulsadoAccion()
        Me.btnAñadir.BackColor = Color.LightGreen
        gestionNoVisible()
        mostrarOpciones()
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Me.accion = 2
        pulsadoAccion()
        Me.btnActualizar.BackColor = Color.LightSkyBlue
        gestionNoVisible()
        mostrarOpciones()
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Me.accion = 3
        pulsadoAccion()
        Me.btnBorrar.BackColor = Color.OrangeRed
        gestionNoVisible()
        mostrarOpciones()
    End Sub

    Private Sub pulsadoAccion()
        Me.btnAñadir.BackColor = DefaultBackColor
        Me.btnActualizar.BackColor = DefaultBackColor
        Me.btnBorrar.BackColor = DefaultBackColor
        Me.btnTrenes.BackColor = DefaultBackColor
        Me.btnTiposTren.BackColor = DefaultBackColor
        Me.btnProductos.BackColor = DefaultBackColor
        Me.btnCotizaciones.BackColor = DefaultBackColor
        Me.btnViajes.BackColor = DefaultBackColor
    End Sub

    Private Sub pulsadoDatos()
        Me.btnTrenes.BackColor = DefaultBackColor
        Me.btnTiposTren.BackColor = DefaultBackColor
        Me.btnProductos.BackColor = DefaultBackColor
        Me.btnCotizaciones.BackColor = DefaultBackColor
        Me.btnViajes.BackColor = DefaultBackColor
    End Sub

    Private Sub gestionNoVisible()
        Me.ListView1.Visible = False
        Me.Label1.Visible = False
        Me.Label2.Visible = False
        Me.Label3.Visible = False
        Me.Label4.Visible = False
        Me.TextBox1.Enabled = True
        Me.TextBox1.Visible = False
        Me.TextBox2.Visible = False
        Me.TextBox3.Visible = False
        Me.ComboBox1.Visible = False
        Me.ComboBox2.Visible = False
        Me.DateTimePicker1.Visible = False
        Me.DateTimePicker2.Visible = False
        Me.DateTimePicker3.Visible = False
        Me.btnAplicar.Visible = False
    End Sub

    Private Sub limpiarCampos()
        Me.TextBox1.Text = ""
        Me.TextBox2.Text = ""
        Me.TextBox3.Text = ""
        Me.ComboBox1.Text = ""
        Me.ComboBox2.Text() = ""
        Select Case accion
            Case 1
                Me.DateTimePicker1.ResetText()
            Case 2
                Me.DateTimePicker3.ResetText()
            Case 3
                Me.DateTimePicker3.ResetText()
        End Select
        Me.DateTimePicker2.ResetText()
    End Sub

    Private Sub mostrarOpciones()
        Me.btnTrenes.Visible = True
        Me.btnTiposTren.Visible = True
        Me.btnProductos.Visible = True
        Me.btnCotizaciones.Visible = True
        Me.btnViajes.Visible = True
    End Sub

    Private Sub btnTrenes_Click(sender As Object, e As EventArgs) Handles btnTrenes.Click
        Me.opcionDatos = 1
        pulsadoDatos()
        Me.btnTrenes.BackColor = Color.Yellow
        gestionNoVisible()
        limpiarCampos()
        comboTiposTren()
        listaTrenes()
        mostrarGestionTren()
    End Sub


    Private Sub btnTiposTren_Click(sender As Object, e As EventArgs) Handles btnTiposTren.Click
        Me.opcionDatos = 2
        pulsadoDatos()
        Me.btnTiposTren.BackColor = Color.Yellow
        gestionNoVisible()
        limpiarCampos()
        listaTiposTren()
        mostrarGestionTipoTren()
    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        Me.opcionDatos = 3
        pulsadoDatos()
        Me.btnProductos.BackColor = Color.Yellow
        gestionNoVisible()
        limpiarCampos()
        listaProductos()
        mostrarGestionProducto()
    End Sub

    Private Sub btnCotizaciones_Click(sender As Object, e As EventArgs) Handles btnCotizaciones.Click
        Me.opcionDatos = 4
        pulsadoDatos()
        Me.btnCotizaciones.BackColor = Color.Yellow
        gestionNoVisible()
        limpiarCampos()
        comboProductos()
        listaCotizaciones()
        mostrarGestionCotizacion()
    End Sub
    Private Sub btnViajes_Click(sender As Object, e As EventArgs) Handles btnViajes.Click
        Me.opcionDatos = 5
        pulsadoDatos()
        Me.btnViajes.BackColor = Color.Yellow
        gestionNoVisible()
        limpiarCampos()
        comboTrenes()
        comboProductos2()
        listaViajes()
        mostrarGestionViaje()
    End Sub

    Private Sub mostrarGestionTren()
        Me.ListView1.Visible = True
        Me.Label1.Text = "Matrícula"
        Me.Label1.Visible = True
        Me.Label2.Text = "Tipo de tren"
        Me.Label2.Visible = True
        Me.TextBox1.Visible = True
        Me.ComboBox2.Visible = True
        Me.btnAplicar.Visible = True
    End Sub

    Private Sub mostrarGestionTipoTren()
        Me.ListView1.Visible = True
        Me.Label2.Text = "Descripción"
        Me.Label2.Visible = True
        Me.Label3.Text = "Capacidad máxima"
        Me.Label3.Visible = True
        Me.TextBox2.Visible = True
        Me.TextBox3.Visible = True
        Me.btnAplicar.Visible = True
    End Sub

    Private Sub mostrarGestionProducto()
        Me.ListView1.Visible = True
        Me.Label2.Text = "Descripción"
        Me.Label2.Visible = True
        Me.TextBox2.Visible = True
        Me.btnAplicar.Visible = True
    End Sub

    Private Sub mostrarGestionCotizacion()
        Me.ListView1.Visible = True
        Me.Label1.Text = "Producto"
        Me.Label1.Visible = True
        Me.Label2.Text = "Fecha"
        Me.Label2.Visible = True
        Me.DateTimePicker2.Visible = True
        Me.Label3.Text = "Euros/Tonelada"
        Me.Label3.Visible = True
        Me.ComboBox1.Visible = True
        Me.DateTimePicker2.Visible = True
        Me.TextBox3.Visible = True
        Me.btnAplicar.Visible = True
    End Sub

    Private Sub mostrarGestionViaje()
        Select Case accion
            Case 1
                Me.DateTimePicker1.Visible = True
                Me.DateTimePicker1.ResetText()
            Case 2
                Me.DateTimePicker3.Visible = True
                Me.DateTimePicker3.ResetText()
            Case 3
                Me.DateTimePicker3.Visible = True
                Me.DateTimePicker3.ResetText()
        End Select
        Me.ListView1.Visible = True
        Me.Label1.Text = "Tren"
        Me.Label1.Visible = True
        Me.Label2.Text = "Producto"
        Me.Label2.Visible = True
        Me.Label3.Text = "Toneladas transportadas"
        Me.Label3.Visible = True
        Me.Label4.Text = "Fecha"
        Me.Label4.Visible = True
        Me.ComboBox1.Visible = True
        Me.ComboBox2.Visible = True
        Me.TextBox3.Visible = True
        Me.btnAplicar.Visible = True
    End Sub

    Private Sub comboTiposTren()
        ComboBox2.Text = Nothing
        ComboBox2.Items.Clear()
        Dim tipot As TipoTren = New TipoTren
        tipot.LeerTodosTiposTren()
        For Each t As TipoTren In tipot.TTrenDAO.Tipos_Tren
            ComboBox2.Items.Add(t.IdTipoTren)
        Next
    End Sub

    Private Sub comboProductos()
        ComboBox1.Text = Nothing
        ComboBox1.Items.Clear()
        Dim prod As Producto = New Producto
        prod.LeerTodosProductos()
        For Each p As Producto In prod.ProDAO.Productos
            ComboBox1.Items.Add(p.IdProducto)
        Next
    End Sub

    Public Sub comboTrenes()
        ComboBox1.Text = Nothing
        ComboBox1.Items.Clear()
        Dim tren As Tren = New Tren
        tren.LeerTodosTrenes()
        For Each t As Tren In Tren.TDAO.Trenes
            ComboBox1.Items.Add(t.Matricula)
        Next

    End Sub

    Private Sub comboProductos2()
        ComboBox2.Text = Nothing
        ComboBox2.Items.Clear()
        Dim prod As Producto = New Producto
        prod.LeerTodosProductos()
        For Each p As Producto In prod.ProDAO.Productos
            ComboBox2.Items.Add(p.IdProducto)
        Next
    End Sub

    Private Sub listaTrenes()
        ListView1.Clear()
        ListView1.Columns.Add("Matricula")
        ListView1.Columns.Add("Tipo de tren")
        ListView1.Columns.Add("Descripción T.Tren")
        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

        Dim tren As Tren = New Tren
        tren.LeerTodosTrenes()
        For Each t As Tren In tren.TDAO.Trenes
            Dim lista As ListViewItem = New ListViewItem(t.Matricula)
            lista.SubItems.Add(CStr(t.TipoTren.IdTipoTren))
            lista.SubItems.Add(t.TipoTren.DescTipoTren)
            ListView1.Items.Add(lista)
        Next
    End Sub

    Private Sub listaTiposTren()
        ListView1.Clear()
        ListView1.Columns.Add("Identificador")
        ListView1.Columns.Add("Descripcion")
        ListView1.Columns.Add("Capacidad Max.")
        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

        Dim tipot As TipoTren = New TipoTren
        tipot.LeerTodosTiposTren()
        For Each t As TipoTren In tipot.TTrenDAO.Tipos_Tren
            Dim lista As ListViewItem = New ListViewItem(CStr(t.IdTipoTren))
            lista.SubItems.Add(t.DescTipoTren)
            lista.SubItems.Add(CStr(t.CapacidadMax))
            ListView1.Items.Add(lista)
        Next
    End Sub

    Private Sub listaProductos()
        ListView1.Clear()
        ListView1.Columns.Add("Identificador")
        ListView1.Columns.Add("Descripción")
        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

        Dim prod As Producto = New Producto
        prod.LeerTodosProductos()
        For Each p As Producto In prod.ProDAO.Productos
            Dim lista As ListViewItem = New ListViewItem(CStr(p.IdProducto))
            lista.SubItems.Add(p.DescripProducto)
            ListView1.Items.Add(lista)
        Next
    End Sub

    Private Sub listaCotizaciones()
        ListView1.Clear()
        ListView1.Columns.Add("Producto")
        ListView1.Columns.Add("Descripción Producto")
        ListView1.Columns.Add("Fecha Cotización")
        ListView1.Columns.Add("Euros/Tonelada")
        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

        Dim cot As Cotizacion = New Cotizacion
        cot.LeerTodasCotizaciones()
        For Each c As Cotizacion In cot.CotDAO.Cotizaciones
            Dim lista As ListViewItem = New ListViewItem(CStr(c.Producto.IdProducto))
            lista.SubItems.Add(c.Producto.DescripProducto)
            lista.SubItems.Add(CStr(Format(c.Fecha, "yyyy/MM/dd")))
            lista.SubItems.Add(CStr(c.EurosPorTonelada))
            ListView1.Items.Add(lista)
        Next
    End Sub

    Private Sub listaViajes()
        ListView1.Clear()
        ListView1.Columns.Add("Fecha viaje")
        ListView1.Columns.Add("Tren viaje")
        ListView1.Columns.Add("Producto")
        ListView1.Columns.Add("Descripción Producto")
        ListView1.Columns.Add("Toneladas Transportadas")
        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

        Dim via As Viaje = New Viaje
        via.LeerTodosViajes()
        For Each v As Viaje In via.ViaDAO.Viajes
            Dim lista As ListViewItem = New ListViewItem(CStr(Format(v.FechaViaje, "yyyy/MM/dd")))
            lista.SubItems.Add(v.Tren.Matricula)
            lista.SubItems.Add(CStr(v.Producto.IdProducto))
            lista.SubItems.Add(v.Producto.DescripProducto)
            lista.SubItems.Add(CStr(v.ToneladasTransportadas))
            ListView1.Items.Add(lista)
        Next
    End Sub

    Private Sub FormGestionDatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.btnAñadir.BackColor = DefaultBackColor
        Me.btnActualizar.BackColor = DefaultBackColor
        Me.btnBorrar.BackColor = DefaultBackColor
    End Sub

    Private Sub btnAplicar_Click(sender As Object, e As EventArgs) Handles btnAplicar.Click
        Select Case accion
            Case 1
                Select Case opcionDatos
                    Case 1
                        Dim t As Tren
                        If Me.TextBox1.Text <> String.Empty And Me.ComboBox2.Text <> String.Empty Then
                            Dim tt As TipoTren
                            t = New Tren(Me.TextBox1.Text)
                            tt = New TipoTren(CInt(Me.ComboBox2.Text))
                            t.TipoTren = tt
                            Try
                                If t.InsertarTren() <> 1 Then
                                    MessageBox.Show("Error al insertar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    Exit Sub
                                End If
                            Catch ex As Exception
                                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Exit Sub
                            End Try
                            Me.ListView1.Items.Add(t.Matricula)
                            limpiarCampos()
                            listaTrenes()
                            MessageBox.Show("Tren insertado correctamente.", "Insertado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Campos vacíos, inténtelo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Case 2
                        Dim tt As TipoTren
                        If Me.TextBox2.Text <> String.Empty And Me.TextBox3.Text <> String.Empty Then
                            tt = New TipoTren()
                            tt.DescTipoTren = Me.TextBox2.Text
                            Try
                                tt.CapacidadMax = Integer.Parse(Me.TextBox3.Text)

                            Catch ex As FormatException
                                MessageBox.Show("El valor de capacidad tiene que ser numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Exit Sub
                            End Try
                            If Integer.Parse(Me.TextBox3.Text) < 0 Then
                                MessageBox.Show("El valor de la capacidad tiene que ser positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Else
                                Try
                                    If tt.InsertarTipoTren() <> 1 Then
                                        MessageBox.Show("Error al insertar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                        Exit Sub
                                    End If
                                Catch ex As Exception
                                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    Exit Sub
                                End Try
                                Me.ListView1.Items.Add(CStr(tt.IdTipoTren))
                                limpiarCampos()
                                listaTiposTren()
                                MessageBox.Show("Tipo de tren insertado correctamente.", "Insertado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        Else
                            MessageBox.Show("Campos vacíos, inténtelo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Case 3
                        Dim prod As Producto
                        If Me.TextBox2.Text <> String.Empty Then
                            prod = New Producto()
                            prod.DescripProducto = Me.TextBox2.Text
                            Try
                                If prod.InsertarProducto <> 1 Then
                                    MessageBox.Show("Error al insertar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    Exit Sub
                                End If
                            Catch ex As Exception
                                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Exit Sub
                            End Try
                            Me.ListView1.Items.Add(CStr(prod.IdProducto))
                            limpiarCampos()
                            listaProductos()
                            MessageBox.Show("Producto insertado correctamente.", "Insertado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Campos vacíos, inténtelo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Case 4
                        Dim cot As Cotizacion
                        If Me.ComboBox1.Text <> String.Empty And Me.TextBox3.Text <> String.Empty Then
                            Dim p As Producto

                            p = New Producto(CInt(ComboBox1.Text))
                            cot = New Cotizacion(p, CDate(Format(Me.DateTimePicker2.Value, "yyyy/MM/dd")))
                            Try
                                cot.EurosPorTonelada = Double.Parse(Me.TextBox3.Text)
                            Catch ex As FormatException
                                MessageBox.Show("El valor de euros/tonelada tiene que ser numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Exit Sub
                            End Try
                            If Double.Parse(Me.TextBox3.Text) < 0 Then
                                MessageBox.Show("El valor de euros/tonelada tiene que ser positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Else
                                Try
                                    If cot.InsertarCotizacion <> 1 Then
                                        MessageBox.Show("Error al insertar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                        Exit Sub
                                    End If
                                Catch ex As Exception
                                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    Exit Sub
                                End Try
                                Me.ListView1.Items.Add(CStr(cot.Producto.IdProducto))
                                limpiarCampos()
                                comboProductos()
                                listaCotizaciones()
                                MessageBox.Show("Cotización insertada correctamente.", "Insertada", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        Else
                            MessageBox.Show("Campos vacíos, inténtelo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Case 5
                        Dim v As Viaje
                        If Me.ComboBox1.Text <> String.Empty And Me.ComboBox2.Text <> String.Empty And Me.TextBox3.Text <> Nothing Then
                            Dim t As Tren
                            Dim p As Producto

                            t = New Tren(Me.ComboBox1.Text)
                            p = New Producto(CInt(ComboBox2.Text))
                            v = New Viaje(CDate(Format(Me.DateTimePicker1.Value, "yyyy/MM/dd")), t, p)
                            Try
                                v.ToneladasTransportadas = Integer.Parse(Me.TextBox3.Text)
                            Catch ex As FormatException
                                MessageBox.Show("El valor de toneladas tiene que ser numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Exit Sub
                            End Try
                            If Integer.Parse(Me.TextBox3.Text) < 0 Then
                                MessageBox.Show("El valor de toneladas tiene que ser positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Else
                                Try
                                    If v.InsertarViaje <> 1 Then
                                        MessageBox.Show("Error al insertar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                        Exit Sub
                                    End If
                                Catch ex As Exception
                                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    Exit Sub
                                End Try
                                Me.ListView1.Items.Add(Format(v.FechaViaje.ToShortDateString, "yyyy/MM/dd"))
                                limpiarCampos()
                                listaViajes()
                                MessageBox.Show("Viaje insertado correctamente.", "Insertado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        Else
                            MessageBox.Show("Campos vacíos, inténtelo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If

                End Select
            Case 2
                Select Case opcionDatos
                    Case 1
                        Dim t As Tren
                        If Me.TextBox1.Text <> String.Empty And Me.ComboBox2.Text <> String.Empty Then
                            Dim tt As TipoTren

                            t = New Tren(Me.TextBox1.Text)
                            tt = New TipoTren(CInt(Me.ComboBox2.Text))
                            t.TipoTren = tt
                            Try
                                If t.ActualizarTren() <> 1 Then
                                    MessageBox.Show("Error al actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    Exit Sub
                                End If
                            Catch ex As Exception
                                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Exit Sub
                            End Try
                            limpiarCampos()
                            listaTrenes()
                            MessageBox.Show("Tren actualizado correctamente.", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Campos vacíos, inténtelo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Case 2
                        Dim tt As TipoTren
                        If Me.TextBox1.Text <> String.Empty And Me.TextBox2.Text <> String.Empty And Me.TextBox3.Text <> String.Empty Then
                            tt = New TipoTren(CInt(Me.TextBox1.Text))
                            tt.DescTipoTren = Me.TextBox2.Text
                            Try
                                tt.CapacidadMax = Integer.Parse(Me.TextBox3.Text)

                            Catch ex As FormatException
                                MessageBox.Show("El valor de capacidad tiene que ser numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Exit Sub
                            End Try
                            If Integer.Parse(Me.TextBox3.Text) < 0 Then
                                MessageBox.Show("El valor de la capacidad tiene que ser positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Else
                                Try
                                    If tt.ActualizarTipoTren() <> 1 Then
                                        MessageBox.Show("Error al actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                        Exit Sub
                                    End If
                                Catch ex As Exception
                                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    Exit Sub
                                End Try
                                limpiarCampos()
                                listaTiposTren()
                                MessageBox.Show("Tipo de tren actualizado correctamente.", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        Else
                            MessageBox.Show("Campos vacíos, inténtelo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Case 3
                        Dim p As Producto
                        If Me.TextBox1.Text <> String.Empty And Me.TextBox2.Text <> String.Empty Then
                            p = New Producto(CInt(Me.TextBox1.Text))
                            p.DescripProducto = Me.TextBox2.Text

                            Try
                                If p.ActualizarProducto() <> 1 Then
                                    MessageBox.Show("Error al actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    Exit Sub
                                End If
                            Catch ex As Exception
                                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Exit Sub
                            End Try
                            limpiarCampos()
                            listaProductos()
                            MessageBox.Show("Producto actualizado correctamente.", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Campos vacíos, inténtelo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Case 4
                        Dim c As Cotizacion
                        If Me.ComboBox1.Text <> String.Empty And Me.DateTimePicker2.Value <> Nothing And Me.TextBox3.Text <> String.Empty Then
                            Dim p As Producto
                            p = New Producto(CInt(Me.ComboBox1.Text))
                            c = New Cotizacion(p, CDate(Format(Me.DateTimePicker2.Value, "yyyy/MM/dd")))
                            Try
                                c.EurosPorTonelada = Double.Parse(Me.TextBox3.Text)
                            Catch ex As FormatException
                                MessageBox.Show("El valor de euros/tonelada tiene que ser numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Exit Sub
                            End Try
                            If Double.Parse(Me.TextBox3.Text) < 0 Then
                                MessageBox.Show("El valor de euros/tonelada tiene que ser positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Else

                                Try
                                    If c.ActualizarCotizacion() <> 1 Then
                                        MessageBox.Show("Error al actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                        Exit Sub
                                    End If
                                Catch ex As Exception
                                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    Exit Sub
                                End Try
                                limpiarCampos()
                                comboProductos()
                                listaCotizaciones()
                                MessageBox.Show("Cotización actualizada correctamente.", "Actualizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        Else
                            MessageBox.Show("Campos vacíos, inténtelo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Case 5
                        Dim v As Viaje
                        If Me.ComboBox1.Text <> String.Empty And Me.ComboBox2.Text <> String.Empty And Me.TextBox3.Text <> String.Empty And Me.DateTimePicker1.Value <> Nothing Then
                            Dim t As Tren
                            Dim p As Producto
                            t = New Tren(Me.ComboBox1.Text)
                            p = New Producto(CInt(Me.ComboBox2.Text))
                            v = New Viaje(CDate(Format(Me.DateTimePicker3.Value, "yyyy/MM/dd")), t, p)
                            Try
                                v.ToneladasTransportadas = Integer.Parse(Me.TextBox3.Text)
                            Catch ex As FormatException
                                MessageBox.Show("El valor de toneladas tiene que ser numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Exit Sub
                            End Try
                            If Integer.Parse(Me.TextBox3.Text) < 0 Then
                                MessageBox.Show("El valor de toneladas tiene que ser positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Else
                                Try
                                    If v.ActualizarViaje() <> 1 Then
                                        MessageBox.Show("Error al actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                        Exit Sub
                                    End If
                                Catch ex As Exception
                                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    Exit Sub
                                End Try
                                limpiarCampos()
                                listaViajes()
                                MessageBox.Show("Viaje actualizado correctamente.", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        Else
                            MessageBox.Show("Campos vacíos, inténtelo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                End Select
            Case 3
                Select Case opcionDatos
                    Case 1
                        Dim t As Tren
                        If Me.TextBox1.Text <> String.Empty And Me.ComboBox2.Text <> String.Empty Then
                            If MessageBox.Show("¿Estás seguro que quieres eliminar el tren " & Me.TextBox1.Text & "?", "Por favor, confirma", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                                Dim tt As TipoTren

                                t = New Tren(Me.TextBox1.Text)
                                tt = New TipoTren(CInt(Me.ComboBox2.Text))
                                t.TipoTren = tt
                                Try
                                    If t.BorrarTren() <> 1 Then
                                        MessageBox.Show("Error al eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                        Exit Sub
                                    End If
                                Catch ex As Exception
                                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    Exit Sub
                                End Try
                                limpiarCampos()
                                listaTrenes()
                                MessageBox.Show("Tren con matrícula " & t.Matricula & " elimindado.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        Else
                            MessageBox.Show("Campos vacíos, inténtelo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Case 2
                        Dim tt As TipoTren
                        If Me.TextBox1.Text <> String.Empty And Me.TextBox2.Text <> String.Empty And Me.TextBox3.Text <> String.Empty Then
                            If MessageBox.Show("¿Estás seguro que quieres eliminar el tipo de tren " & Me.TextBox1.Text & "?", "Por favor, confirma", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                                tt = New TipoTren(CInt(Me.TextBox1.Text))
                                tt.DescTipoTren = Me.TextBox2.Text
                                tt.CapacidadMax = CInt(Me.TextBox3.Text)

                                Try
                                    If tt.BorrarTipoTren() <> 1 Then
                                        MessageBox.Show("Error al eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                        Exit Sub
                                    End If
                                Catch ex As Exception
                                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    Exit Sub
                                End Try
                                limpiarCampos()
                                listaTiposTren()
                                MessageBox.Show("Has eliminado el tipo de tren con id " & tt.IdTipoTren & ".", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        Else
                            MessageBox.Show("Campos vacíos, inténtelo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Case 3
                        Dim p As Producto
                        If Me.TextBox1.Text <> String.Empty And Me.TextBox2.Text <> String.Empty Then
                            If MessageBox.Show("¿Estás seguro que quieres eliminar el producto " & Me.TextBox1.Text & "?", "Por favor, confirma", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                                p = New Producto(CInt(Me.TextBox1.Text))
                                p.DescripProducto = Me.TextBox2.Text

                                Try
                                    If p.BorrarProducto() <> 1 Then
                                        MessageBox.Show("Error al eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                        Exit Sub
                                    End If
                                Catch ex As Exception
                                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    Exit Sub
                                End Try
                                limpiarCampos()
                                listaProductos()
                                MessageBox.Show("Has eliminado el producto con id " & p.IdProducto & ".", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        Else
                            MessageBox.Show("Campos vacíos, inténtelo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Case 4
                        Dim c As Cotizacion
                        If Me.ComboBox1.Text <> String.Empty And Me.DateTimePicker2.Value <> Nothing And Me.TextBox3.Text <> String.Empty Then
                            If MessageBox.Show("¿Estás seguro que quieres eliminar la cotizacion con fecha " & Format(Me.DateTimePicker2.Value, "yyyy/MM/dd") & "?", "Por favor, confirma", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                                Dim p As Producto

                                p = New Producto(CInt(Me.ComboBox1.Text))
                                c = New Cotizacion(p, (CDate(Format(Me.DateTimePicker2.Value, "yyyy/MM/dd"))))
                                c.EurosPorTonelada = CDbl(Me.TextBox3.Text)
                                Try
                                    If c.BorrarCotizacion() <> 1 Then
                                        MessageBox.Show("Error al eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                        Exit Sub
                                    End If
                                Catch ex As Exception
                                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    Exit Sub
                                End Try
                                limpiarCampos()
                                comboProductos()
                                listaCotizaciones()
                                MessageBox.Show("Has eliminado la cotización con producto " & c.Producto.IdProducto & ".", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        Else
                            MessageBox.Show("Campos vacíos, inténtelo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Case 5
                        Dim v As Viaje
                        If Me.ComboBox1.Text <> String.Empty And Me.ComboBox2.Text <> String.Empty And Me.TextBox3.Text <> String.Empty And Me.DateTimePicker1.Value <> Nothing Then
                            If MessageBox.Show("¿Estás seguro que quieres eliminar el viaje con fecha " & Format(Me.DateTimePicker1.Value, "yyyy/MM/dd") & "?", "Por favor, confirma", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                                Dim t As Tren
                                Dim p As Producto

                                t = New Tren(Me.ComboBox1.Text)
                                p = New Producto(CInt(Me.ComboBox2.Text))
                                v = New Viaje(CDate(Format(Me.DateTimePicker3.Value, "yyyy/MM/dd")), t, p)
                                Try
                                    v.ToneladasTransportadas = Integer.Parse(Me.TextBox3.Text)
                                Catch ex As FormatException
                                    MessageBox.Show("El valor de toneladas tiene que ser numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    Exit Sub
                                End Try
                                If Integer.Parse(Me.TextBox3.Text) < 0 Then
                                    MessageBox.Show("El valor de toneladas tiene que ser positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Else
                                    Try
                                        If v.BorrarViaje() <> 1 Then
                                            MessageBox.Show("Error al eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                            Exit Sub
                                        End If
                                    Catch ex As Exception
                                        MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                                        Exit Sub
                                    End Try
                                    limpiarCampos()
                                    listaViajes()
                                    MessageBox.Show("Has eliminado el viaje con fecha " & Format(v.FechaViaje, "yyyy/MM/dd") & ".", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                End If
                            End If
                        Else
                            MessageBox.Show("Campos vacíos, inténtelo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                End Select
        End Select
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        Select Case opcionDatos
            Case 1
                Dim t As Tren
                If Me.ListView1.SelectedItems.Count > 0 Then
                    Dim item As ListViewItem = ListView1.SelectedItems(0)
                    Dim tt As TipoTren

                    t = New Tren(item.SubItems(0).Text)
                    tt = New TipoTren(CInt(item.SubItems(1).Text))
                    t.TipoTren = tt

                    Try
                        t.LeerTren()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End Try
                    Me.TextBox1.Text = t.Matricula
                    Me.ComboBox2.Text = CStr(t.TipoTren.IdTipoTren)
                End If
            Case 2
                Dim tt As TipoTren
                If Me.ListView1.SelectedItems.Count > 0 Then
                    Dim item As ListViewItem = ListView1.SelectedItems(0)

                    tt = New TipoTren(CInt(item.SubItems(0).Text))
                    tt.DescTipoTren = item.SubItems(1).Text
                    tt.CapacidadMax = CInt(item.SubItems(2).Text)

                    Try
                        tt.LeerTipoTren()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End Try
                    Me.TextBox1.Text = CStr(tt.IdTipoTren)
                    Me.TextBox2.Text = tt.DescTipoTren
                    Me.TextBox3.Text = CStr(tt.CapacidadMax)
                End If
            Case 3
                Dim p As Producto
                If Me.ListView1.SelectedItems.Count > 0 Then
                    Dim item As ListViewItem = ListView1.SelectedItems(0)

                    p = New Producto(CInt(item.SubItems(0).Text))
                    p.DescripProducto = item.SubItems(1).Text

                    Try
                        p.LeerProducto()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End Try
                    Me.TextBox1.Text = CStr(p.IdProducto)
                    Me.TextBox2.Text = p.DescripProducto
                End If
            Case 4
                Dim c As Cotizacion
                If Me.ListView1.SelectedItems.Count > 0 Then
                    Dim item As ListViewItem = ListView1.SelectedItems(0)
                    Dim p As Producto

                    p = New Producto(CInt(item.SubItems(0).Text))
                    c = New Cotizacion(p, CDate(item.SubItems(2).Text))
                    c.EurosPorTonelada = CDbl(item.SubItems(3).Text)

                    Try
                        c.LeerCotizacion()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End Try
                    Me.ComboBox1.Text = CStr(c.Producto.IdProducto)
                    Me.DateTimePicker2.Value = CDate(c.Fecha)
                    Me.TextBox3.Text = CStr(c.EurosPorTonelada)
                End If
            Case 5
                Dim v As Viaje
                If Me.ListView1.SelectedItems.Count > 0 Then
                    Dim item As ListViewItem = ListView1.SelectedItems(0)
                    Select Case accion
                        Case 1
                            Me.DateTimePicker1.Value = CDate(item.SubItems(0).Text)
                        Case 2
                            Me.DateTimePicker3.Value = CDate(item.SubItems(0).Text)
                        Case 3
                            Me.DateTimePicker3.Value = CDate(item.SubItems(0).Text)
                    End Select

                    Dim t As Tren
                    Dim p As Producto

                    t = New Tren(item.SubItems(1).Text)
                    p = New Producto(CInt(item.SubItems(2).Text))
                    v = New Viaje(CDate(item.SubItems(0).Text), t, p)
                    v.ToneladasTransportadas = CInt(item.SubItems(4).Text)

                    Try
                        v.LeerViaje()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End Try
                    Me.ComboBox1.Text = v.Tren.Matricula
                    Me.ComboBox2.Text = CStr(v.Producto.IdProducto)
                    Me.TextBox3.Text = CStr(v.ToneladasTransportadas)
                End If
        End Select
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        'Esto se hace para que en la opcion insertar-trenes recoja los trenes disponibles en el comboBoxTrenes en una fecha concreta
        'y no afecte a la hora de actualizar y borrar. Por ello hay dos DateTimePicker, el 1 para insertar y el 2 para actualizar y borrar
        ComboBox1.Text = Nothing
        ComboBox1.Items.Clear()
        Dim tren As Tren = New Tren
        tren.LeerTrenesDisponibles(CDate(Format(Me.DateTimePicker1.Value, "yyyy/MM/dd")))
        For Each t As Tren In tren.TDAO.Trenes
            ComboBox1.Items.Add(t.Matricula)
        Next
    End Sub
End Class
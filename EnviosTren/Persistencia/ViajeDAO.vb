Public Class ViajeDAO
    Public ReadOnly Property Viajes As Collection

    Public Sub New()
        Me.Viajes = New Collection
    End Sub

    Public Sub LeerTodas(ruta As String)
        Dim v As Viaje
        Dim t As Tren
        Dim p As Producto
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT v.FechaViaje, v.Tren, v.Producto, p.DescripProducto, v.ToneladasTransportadas FROM Viajes v, Trenes t, Productos p WHERE v.Tren = t.Matricula AND v.Producto = p.IdProducto ORDER BY FechaViaje")
        For Each aux In col
            t = New Tren(aux(2).ToString)
            p = New Producto(CInt(aux(3).ToString))
            p.DescripProducto = aux(4).ToString
            v = New Viaje(CDate(aux(1).ToString), t, p)
            v.ToneladasTransportadas = CInt(aux(5).ToString)
            Me.Viajes.Add(v)
        Next
    End Sub

    Public Sub LeerTodas()
        Dim v As Viaje
        Dim t As Tren
        Dim p As Producto
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT v.FechaViaje, v.Tren, v.Producto, p.DescripProducto, v.ToneladasTransportadas FROM Viajes v, Trenes t, Productos p WHERE v.Tren = t.Matricula AND v.Producto = p.IdProducto ORDER BY FechaViaje")
        For Each aux In col
            t = New Tren(aux(2).ToString)
            p = New Producto(CInt(aux(3).ToString))
            p.DescripProducto = aux(4).ToString
            v = New Viaje(CDate(aux(1).ToString), t, p)
            v.ToneladasTransportadas = CInt(aux(5).ToString)
            Me.Viajes.Add(v)
        Next
    End Sub

    Public Sub LeerPFechas(fechaI As Date, fechaF As Date, tren As String)
        Dim v As Viaje
        Dim p As Producto
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT v.FechaViaje, p.IdProducto, p.DescripProducto, v.ToneladasTransportadas FROM Viajes v INNER JOIN Productos p ON (v.Producto = p.IdProducto) WHERE Tren='" & tren & "' AND FechaViaje BETWEEN #" & Format(fechaI, "yyyy/MM/dd") & "# AND #" & Format(fechaF, "yyyy/MM/dd") & "# ORDER BY v.FechaViaje ")
        For Each aux In col
            p = New Producto(CInt(aux(2).ToString))
            v = New Viaje(CDate(aux(1).ToString), p)
            v.DesProducto = aux(3).ToString
            v.ToneladasTransportadas = CInt(aux(4).ToString)
            Me.Viajes.Add(v)
        Next
    End Sub

    Public Sub LeerVMaxBeneficio()
        Dim v As Viaje
        Dim t As Tren
        Dim tt As TipoTren
        Dim p As Producto
        Dim c As Cotizacion
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT TOP 1 v.FechaViaje,t.Matricula,t.TipoTren,p.IdProducto,p.DescripProducto,v.ToneladasTransportadas,c.EurosPorTonelada,(c.EurosPorTonelada*v.ToneladasTransportadas) FROM Viajes v,Trenes t,Cotizaciones c,Productos p WHERE v.Tren=t.Matricula AND v.Producto=p.IdProducto AND c.Producto=p.IdProducto ORDER BY (c.EurosPorTonelada*v.ToneladasTransportadas) DESC")
        For Each aux In col
            p = New Producto(CInt(aux(4).ToString))
            p.DescripProducto = aux(5).ToString
            t = New Tren(aux(2).ToString)
            tt = New TipoTren(CInt(aux(3).ToString))
            t.TipoTren = tt
            v = New Viaje(CDate(aux(1).ToString), t, p)
            v.ToneladasTransportadas = CInt(aux(6).ToString)
            v.Cotizacion = CDbl(aux(7).ToString)
            v.Beneficio = CInt(aux(8).ToString)
            c = New Cotizacion(p, CDate(aux(1).ToString))
            Me.Viajes.Add(v)
        Next
    End Sub

    Public Sub Leer(ByRef v As Viaje)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Viajes WHERE FechaViaje=#" & Format(v.FechaViaje, "yyyy/MM/dd") & "# AND Tren='" & v.Tren.Matricula & "' AND Producto=" & v.Producto.IdProducto & ";")
        For Each aux In col
            v.ToneladasTransportadas = CInt(aux(4).ToString)
        Next
    End Sub

    Public Function Insertar(ByVal v As Viaje) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Viajes VALUES (#" & Format(v.FechaViaje, "yyyy/MM/dd") & "#, '" & v.Tren.Matricula & "', " & v.Producto.IdProducto & ", " & v.ToneladasTransportadas & ");")
    End Function

    Public Function Actualizar(ByVal v As Viaje) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Viajes SET ToneladasTransportadas=" & v.ToneladasTransportadas & " WHERE FechaViaje=#" & Format(v.FechaViaje, "yyyy/MM/dd") & "# AND Tren='" & v.Tren.Matricula & "' AND Producto=" & v.Producto.IdProducto & ";")
    End Function

    Public Function Borrar(ByVal v As Viaje) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Viajes WHERE FechaViaje=#" & Format(v.FechaViaje, "yyyy/MM/dd") & "# AND Tren='" & v.Tren.Matricula & "' AND Producto=" & v.Producto.IdProducto & ";")
    End Function
End Class

Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class ProductosD
      Public Class TodosLosMovimientosDeInventarioC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of TodosLosMovimientosDeInventario_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("c6de2632-1a43-40d7-96f4-3813727a756d"))
              me.ID = new GUID("c6de2632-1a43-40d7-96f4-3813727a756d")
              me.Titulo  = "Todos los Movimientos de inventario"
          End sub
          <ProtoContract>
          Public Class TodosLosMovimientosDeInventario_FilaC
                <ProtoMember(100)>  Public Producto As String
                <ProtoMember(101)>  Public Lote As String
                <ProtoMember(102)>  Public StockDisponible As Decimal
                <ProtoMember(103)>  Public StockInventario As Decimal
                <ProtoMember(104)>  Public StockTramite As Decimal
                <ProtoMember(105)>  Public StockReservado As Decimal
                <ProtoMember(106)>  Public Fecha As Date?
                <ProtoMember(107)>  Public Ubicacion As String
                <ProtoMember(108)>  Public Origen As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Producto = o("Producto").STR
              Me.Lote = o("Lote").STR
              Me.StockDisponible = o("StockDisponible").DEC
              Me.StockInventario = o("StockInventario").DEC
              Me.StockTramite = o("StockTramite").DEC
              Me.StockReservado = o("StockReservado").DEC
              Me.Fecha = o("Fecha").ToDateTime_UTC
              Me.Ubicacion = o("Ubicacion").STR
              Me.Origen = o("Origen").STR
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of TodosLosMovimientosDeInventario_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New TodosLosMovimientosDeInventario_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
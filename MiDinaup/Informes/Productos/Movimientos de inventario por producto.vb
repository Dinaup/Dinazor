Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class ProductosD
      Public Class MovimientosDeInventarioPorProductoC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of MovimientosDeInventarioPorProducto_FilaC)
          Public TokenCambios As Guid
          Sub new(Producto As Guid)
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("65e67232-4bfe-43af-bb0e-52e365328f14"))
              me.ID = new GUID("65e67232-4bfe-43af-bb0e-52e365328f14")
              me.Titulo  = "Movimientos de inventario por producto"
              Agregar_Respuesta("Producto",Producto)
          End sub
          <ProtoContract>
          Public Class MovimientosDeInventarioPorProducto_FilaC
                <ProtoMember(100)>  Public Producto As String
                <ProtoMember(101)>  Public Lote As String
                <ProtoMember(102)>  Public StockTramite As Decimal
                <ProtoMember(103)>  Public Fecha As Date?
                <ProtoMember(104)>  Public StockReservado As Decimal
                <ProtoMember(105)>  Public StockDisponible As Decimal
                <ProtoMember(106)>  Public StockInventario As Decimal
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Producto = o("Producto").STR
              Me.Lote = o("Lote").STR
              Me.StockTramite = o("StockTramite").DEC
              Me.Fecha = o("Fecha").ToDateTime_UTC
              Me.StockReservado = o("StockReservado").DEC
              Me.StockDisponible = o("StockDisponible").DEC
              Me.StockInventario = o("StockInventario").DEC
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of MovimientosDeInventarioPorProducto_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New MovimientosDeInventarioPorProducto_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class MovimientosinternosdeinventarioD
      Public Class SeguimientoDeLotesC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of SeguimientoDeLotes_FilaC)
          Public TokenCambios As Guid
          Sub new(Lote As Guid)
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("e5767dd5-5757-453f-8a56-372882477215"))
              me.ID = new GUID("e5767dd5-5757-453f-8a56-372882477215")
              me.Titulo  = "Seguimiento de lotes"
              Agregar_Respuesta("Lote",Lote)
          End sub
          <ProtoContract>
          Public Class SeguimientoDeLotes_FilaC
                <ProtoMember(100)>  Public StockReservado As Decimal
                <ProtoMember(101)>  Public Lote As String
                <ProtoMember(102)>  Public Empleado As String
                <ProtoMember(103)>  Public StockTramite As Decimal
                <ProtoMember(104)>  Public StockInventario As Decimal
                <ProtoMember(105)>  Public ClienteProveedor As String
                <ProtoMember(106)>  Public Fecha As Date?
                <ProtoMember(107)>  Public StockDisponible As Decimal
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.StockReservado = o("StockReservado").DEC
              Me.Lote = o("Lote").STR
              Me.Empleado = o("Empleado").STR
              Me.StockTramite = o("StockTramite").DEC
              Me.StockInventario = o("StockInventario").DEC
              Me.ClienteProveedor = o("ClienteProveedor").STR
              Me.Fecha = o("Fecha").ToDateTime_UTC
              Me.StockDisponible = o("StockDisponible").DEC
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of SeguimientoDeLotes_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New SeguimientoDeLotes_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
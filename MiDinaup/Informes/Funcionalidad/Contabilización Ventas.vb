Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class ContabilizacionVentasC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of ContabilizacionVentas_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("b513aea7-64ab-4c30-8fb6-04ce80ae68f1"))
              me.ID = new GUID("b513aea7-64ab-4c30-8fb6-04ce80ae68f1")
              me.Titulo  = "Contabilización Ventas"
          End sub
          <ProtoContract>
          Public Class ContabilizacionVentas_FilaC
                <ProtoMember(100)>  Public TextoPrincipal As String
                <ProtoMember(101)>  Public Cliente As String
                <ProtoMember(102)>  Public Fecha As Date?
                <ProtoMember(103)>  Public Total As Decimal
                <ProtoMember(104)>  Public Asiento As String
                <ProtoMember(105)>  Public AsientoImporte As Decimal
                <ProtoMember(106)>  Public UbicacionPrincipal As String
                <ProtoMember(107)>  Public Tipo As String
                <ProtoMember(108)>  Public Retencion As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.TextoPrincipal = o("TextoPrincipal").STR
              Me.Cliente = o("Cliente").STR
              Me.Fecha = o("Fecha").ToDate
              Me.Total = o("Total").DEC
              Me.Asiento = o("Asiento").STR
              Me.AsientoImporte = o("AsientoImporte").DEC
              Me.UbicacionPrincipal = o("UbicacionPrincipal").STR
              Me.Tipo = o("Tipo").STR
              Me.Retencion = o("Retencion").STR
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of ContabilizacionVentas_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New ContabilizacionVentas_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
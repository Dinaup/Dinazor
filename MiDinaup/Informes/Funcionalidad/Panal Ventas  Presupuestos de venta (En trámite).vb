Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class PanalVentasPresupuestosDeVentaEnTramite__2C
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of PanalVentasPresupuestosDeVentaEnTramite__2_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("80101638-3bfb-459a-946b-67861ace7801"))
              me.ID = new GUID("80101638-3bfb-459a-946b-67861ace7801")
              me.Titulo  = "Panal Ventas > Presupuestos de venta (En trámite)"
          End sub
          <ProtoContract>
          Public Class PanalVentasPresupuestosDeVentaEnTramite__2_FilaC
                <ProtoMember(100)>  Public Cliente As String
                <ProtoMember(101)>  Public Fecha As Date?
                <ProtoMember(102)>  Public Total As Decimal
                <ProtoMember(103)>  Public Vendibles As Decimal
                <ProtoMember(104)>  Public Vendidos As Decimal
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Cliente = o("Cliente").STR
              Me.Fecha = o("Fecha").ToDateTime_UTC
              Me.Total = o("Total").DEC
              Me.Vendibles = o("Vendibles").DEC
              Me.Vendidos = o("Vendidos").DEC
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of PanalVentasPresupuestosDeVentaEnTramite__2_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New PanalVentasPresupuestosDeVentaEnTramite__2_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
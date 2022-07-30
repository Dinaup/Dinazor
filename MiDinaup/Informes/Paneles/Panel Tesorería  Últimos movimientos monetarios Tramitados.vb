Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class PanelesD
      Public Class PanelTesoreriaUltimosMovimientosMonetariosTramitadosC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of PanelTesoreriaUltimosMovimientosMonetariosTramitados_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("13e215e6-5a85-4547-8758-452016ddc445"))
              me.ID = new GUID("13e215e6-5a85-4547-8758-452016ddc445")
              me.Titulo  = "Panel Tesorería > Últimos movimientos monetarios Tramitados"
          End sub
          <ProtoContract>
          Public Class PanelTesoreriaUltimosMovimientosMonetariosTramitados_FilaC
                <ProtoMember(100)>  Public SeccionOrigenID As Guid
                <ProtoMember(101)>  Public Deposito As String
                <ProtoMember(102)>  Public Empleado As String
                <ProtoMember(103)>  Public Importe As Decimal
                <ProtoMember(104)>  Public Estado As Integer
                <ProtoMember(105)>  Public Origen As String
                <ProtoMember(106)>  Public Tramitacion As Date?
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.SeccionOrigenID = o("SeccionOrigenID").ToGuid
              Me.Deposito = o("Deposito").STR
              Me.Empleado = o("Empleado").STR
              Me.Importe = o("Importe").DEC
              Me.Estado = ctype(o("Estado").INT(0), EnumTramitacionE)
              Me.Origen = o("Origen").STR
              Me.Tramitacion = o("Tramitacion").ToDateTime_UTC
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of PanelTesoreriaUltimosMovimientosMonetariosTramitados_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New PanelTesoreriaUltimosMovimientosMonetariosTramitados_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
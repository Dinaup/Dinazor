Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class PanelesD
      Public Class PanelTesoreriaUltimosMovimientosMonetariosEnTramiteC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of PanelTesoreriaUltimosMovimientosMonetariosEnTramite_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("590cf653-e263-43a7-bd77-e5c1ed26f9e0"))
              me.ID = new GUID("590cf653-e263-43a7-bd77-e5c1ed26f9e0")
              me.Titulo  = "Panel Tesorería > Últimos movimientos monetarios en trámite"
          End sub
          <ProtoContract>
          Public Class PanelTesoreriaUltimosMovimientosMonetariosEnTramite_FilaC
                <ProtoMember(100)>  Public Deposito As String
                <ProtoMember(101)>  Public Empleado As String
                <ProtoMember(102)>  Public Entidad As String
                <ProtoMember(103)>  Public Estado As Integer
                <ProtoMember(104)>  Public OrigenID As Guid
                <ProtoMember(105)>  Public Vencimiento As Date?
                <ProtoMember(106)>  Public Importe As Decimal
                <ProtoMember(107)>  Public Ubicacion As String
                <ProtoMember(108)>  Public Origen As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Deposito = o("Deposito").STR
              Me.Empleado = o("Empleado").STR
              Me.Entidad = o("Entidad").STR
              Me.Estado = ctype(o("Estado").INT(0), EnumTramitacionE)
              Me.OrigenID = o("OrigenID").ToGuid
              Me.Vencimiento = o("Vencimiento").ToDate
              Me.Importe = o("Importe").DEC
              Me.Ubicacion = o("Ubicacion").STR
              Me.Origen = o("Origen").STR
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of PanelTesoreriaUltimosMovimientosMonetariosEnTramite_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New PanelTesoreriaUltimosMovimientosMonetariosEnTramite_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
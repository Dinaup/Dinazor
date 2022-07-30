Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class PanelesD
      Public Class PanelTesoreriaUltimosMovimientosMonetariosC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of PanelTesoreriaUltimosMovimientosMonetarios_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("72160a39-6705-4cfa-b1a5-5569ffceb9af"))
              me.ID = new GUID("72160a39-6705-4cfa-b1a5-5569ffceb9af")
              me.Titulo  = "Panel Tesorería > Últimos movimientos monetarios"
          End sub
          <ProtoContract>
          Public Class PanelTesoreriaUltimosMovimientosMonetarios_FilaC
                <ProtoMember(100)>  Public Estado As Integer
                <ProtoMember(101)>  Public Deposito As String
                <ProtoMember(102)>  Public SeccionOrigenID As Guid
                <ProtoMember(103)>  Public Tramitado As Date?
                <ProtoMember(104)>  Public Empleado As String
                <ProtoMember(105)>  Public Origen As String
                <ProtoMember(106)>  Public Importe As Decimal
                <ProtoMember(107)>  Public Entidadrelacionada As String
                <ProtoMember(108)>  Public Ubicacion As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Estado = ctype(o("Estado").INT(0), EnumTramitacionE)
              Me.Deposito = o("Deposito").STR
              Me.SeccionOrigenID = o("SeccionOrigenID").ToGuid
              Me.Tramitado = o("Tramitado").ToDateTime_UTC
              Me.Empleado = o("Empleado").STR
              Me.Origen = o("Origen").STR
              Me.Importe = o("Importe").DEC
              Me.Entidadrelacionada = o("Entidadrelacionada").STR
              Me.Ubicacion = o("Ubicacion").STR
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of PanelTesoreriaUltimosMovimientosMonetarios_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New PanelTesoreriaUltimosMovimientosMonetarios_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
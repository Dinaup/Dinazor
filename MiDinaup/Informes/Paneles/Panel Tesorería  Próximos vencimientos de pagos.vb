Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class PanelesD
      Public Class PanelTesoreriaProximosVencimientosDePagosC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of PanelTesoreriaProximosVencimientosDePagos_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("f1f34b6d-bafc-4f9a-9b28-a98a43c0bf55"))
              me.ID = new GUID("f1f34b6d-bafc-4f9a-9b28-a98a43c0bf55")
              me.Titulo  = "Panel Tesorería > Próximos vencimientos de pagos"
          End sub
          <ProtoContract>
          Public Class PanelTesoreriaProximosVencimientosDePagos_FilaC
                <ProtoMember(100)>  Public Entidadrelacionada As String
                <ProtoMember(101)>  Public Vencimiento As Date?
                <ProtoMember(102)>  Public OrigenID As Guid
                <ProtoMember(103)>  Public Metododepago As String
                <ProtoMember(104)>  Public Ubicacion As String
                <ProtoMember(105)>  Public Empleado As String
                <ProtoMember(106)>  Public Importe As Decimal
                <ProtoMember(107)>  Public Origen As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Entidadrelacionada = o("Entidadrelacionada").STR
              Me.Vencimiento = o("Vencimiento").ToDate
              Me.OrigenID = o("OrigenID").ToGuid
              Me.Metododepago = o("Metododepago").STR
              Me.Ubicacion = o("Ubicacion").STR
              Me.Empleado = o("Empleado").STR
              Me.Importe = o("Importe").DEC
              Me.Origen = o("Origen").STR
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of PanelTesoreriaProximosVencimientosDePagos_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New PanelTesoreriaProximosVencimientosDePagos_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
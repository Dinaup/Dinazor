Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class PanelesD
      Public Class PanelReservasReservasProximasACaducarC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of PanelReservasReservasProximasACaducar_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("f4a007d7-2704-4f4f-a320-cfffd64373eb"))
              me.ID = new GUID("f4a007d7-2704-4f4f-a320-cfffd64373eb")
              me.Titulo  = "Panel Reservas > Reservas próximas a caducar"
          End sub
          <ProtoContract>
          Public Class PanelReservasReservasProximasACaducar_FilaC
                <ProtoMember(100)>  Public Cliente As String
                <ProtoMember(101)>  Public Reservas As Decimal
                <ProtoMember(102)>  Public UbicacionPrincipal As String
                <ProtoMember(103)>  Public Vencimiento As Date?
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Cliente = o("Cliente").STR
              Me.Reservas = o("Reservas").DEC
              Me.UbicacionPrincipal = o("UbicacionPrincipal").STR
              Me.Vencimiento = o("Vencimiento").ToDateTime_UTC
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of PanelReservasReservasProximasACaducar_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New PanelReservasReservasProximasACaducar_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
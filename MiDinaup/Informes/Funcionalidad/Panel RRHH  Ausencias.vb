Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class PanelRRHHAusenciasC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of PanelRRHHAusencias_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("7c7dc502-996e-493f-954d-932b924ee79d"))
              me.ID = new GUID("7c7dc502-996e-493f-954d-932b924ee79d")
              me.Titulo  = "Panel RRHH > Ausencias"
          End sub
          <ProtoBuf.ProtoContract>
          Public Class PanelRRHHAusencias_FilaC
                <ProtoBuf.ProtoMember(100)>  Public Fecha As Date?
                <ProtoBuf.ProtoMember(101)>  Public Empleado As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Fecha = o("Fecha").ToDateTime_UTC
              Me.Empleado = o("Empleado").STR
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of PanelRRHHAusencias_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New PanelRRHHAusencias_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class PanelRRHHAusenciasC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of PanelRRHHAusencias_FilaC)
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of PanelRRHHAusencias_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Creando_Filas.Add(New PanelRRHHAusencias_FilaC(Actual))
                    Next
                End If
                Me.Filas = Creando_Filas
            End Sub
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("7c7dc502-996e-493f-954d-932b924ee79d"))
              me.ID = new GUID("7c7dc502-996e-493f-954d-932b924ee79d")
              me.Titulo  = "Panel RRHH > Ausencias"
          End sub
          Public Class PanelRRHHAusencias_FilaC
              Public Fecha As Date?
              Public Empleado As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Fecha = o("Fecha").ToDateTime_UTC
              Me.Empleado = o("Empleado").STR
              End Sub
          End Class
      End Class
  End Class
End Class
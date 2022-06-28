Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class PanelControlDeHorariosTurnosEnCursoC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of PanelControlDeHorariosTurnosEnCurso_FilaC)
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of PanelControlDeHorariosTurnosEnCurso_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Creando_Filas.Add(New PanelControlDeHorariosTurnosEnCurso_FilaC(Actual))
                    Next
                End If
                Me.Filas = Creando_Filas
            End Sub
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("8d65220a-5f3b-4cec-9f40-ce926604dca9"))
              me.ID = new GUID("8d65220a-5f3b-4cec-9f40-ce926604dca9")
              me.Titulo  = "Panel Control de Horarios > Turnos en curso"
          End sub
          Public Class PanelControlDeHorariosTurnosEnCurso_FilaC
              Public Empleado As String
              Public EmpleadoIcono As Guid
              Public Estado As Integer
              Public Ubicacion As String
              Public Turno As String
              Public Inicio As Date?
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Empleado = o("Empleado").STR
              Me.EmpleadoIcono = o("EmpleadoIcono").ToGuid
              Me.Estado = o("Estado").INT
              Me.Ubicacion = o("Ubicacion").STR
              Me.Turno = o("Turno").STR
              Me.Inicio = o("Inicio").ToDateTime_UTC
              End Sub
          End Class
      End Class
  End Class
End Class
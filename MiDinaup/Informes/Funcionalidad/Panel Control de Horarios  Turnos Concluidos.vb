Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class PanelControlDeHorariosTurnosConcluidosC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of PanelControlDeHorariosTurnosConcluidos_FilaC)
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of PanelControlDeHorariosTurnosConcluidos_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Creando_Filas.Add(New PanelControlDeHorariosTurnosConcluidos_FilaC(Actual))
                    Next
                End If
                Me.Filas = Creando_Filas
            End Sub
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("91b61de7-ee0e-4c40-8a63-f01894ecfff1"))
              me.ID = new GUID("91b61de7-ee0e-4c40-8a63-f01894ecfff1")
              me.Titulo  = "Panel Control de Horarios > Turnos Concluidos"
          End sub
          Public Class PanelControlDeHorariosTurnosConcluidos_FilaC
              Public Empleado As String
              Public EmpleadoIcono As Guid
              Public Ubicacion As String
              Public Turno As String
              Public Estado As Integer
              Public Diferencia As Integer
              Public Inicio As Date?
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Empleado = o("Empleado").STR
              Me.EmpleadoIcono = o("EmpleadoIcono").ToGuid
              Me.Ubicacion = o("Ubicacion").STR
              Me.Turno = o("Turno").STR
              Me.Estado = o("Estado").INT
              Me.Diferencia = o("Diferencia").INT
              Me.Inicio = o("Inicio").ToDateTime_UTC
              End Sub
          End Class
      End Class
  End Class
End Class
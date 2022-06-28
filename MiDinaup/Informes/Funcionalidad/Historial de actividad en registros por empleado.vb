Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class HistorialDeActividadEnRegistrosPorEmpleadoC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of HistorialDeActividadEnRegistrosPorEmpleado_FilaC)
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of HistorialDeActividadEnRegistrosPorEmpleado_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Creando_Filas.Add(New HistorialDeActividadEnRegistrosPorEmpleado_FilaC(Actual))
                    Next
                End If
                Me.Filas = Creando_Filas
            End Sub
          Sub new(Empleado As Guid, Fecha_Desde As Date, Fecha_Hasta As Date)
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("454381c6-7ff6-49e5-b721-318a16828828"))
              me.ID = new GUID("454381c6-7ff6-49e5-b721-318a16828828")
              me.Titulo  = "Historial de actividad en registros por empleado"
              Agregar_Respuesta("Empleado",Empleado)
              Agregar_Respuesta("Fecha_Desde",Fecha_Desde)
              Agregar_Respuesta("Fecha_Hasta",Fecha_Hasta)
          End sub
          Public Class HistorialDeActividadEnRegistrosPorEmpleado_FilaC
              Public Empleado As String
              Public Fecha As Date?
              Public Ubicacion As String
              Public Dato As String
              Public DatoIcono As Guid
              Public Seccion As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Empleado = o("Empleado").STR
              Me.Fecha = o("Fecha").ToDateTime_UTC
              Me.Ubicacion = o("Ubicacion").STR
              Me.Dato = o("Dato").STR
              Me.DatoIcono = o("DatoIcono").ToGuid
              Me.Seccion = o("Seccion").STR
              End Sub
          End Class
      End Class
  End Class
End Class
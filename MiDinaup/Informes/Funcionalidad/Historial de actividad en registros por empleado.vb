Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class HistorialDeActividadEnRegistrosPorEmpleadoC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of HistorialDeActividadEnRegistrosPorEmpleado_FilaC)
          Public TokenCambios As Guid
          Sub new(Empleado As Guid, Fecha_Desde As Date, Fecha_Hasta As Date)
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("454381c6-7ff6-49e5-b721-318a16828828"))
              me.ID = new GUID("454381c6-7ff6-49e5-b721-318a16828828")
              me.Titulo  = "Historial de actividad en registros por empleado"
              Agregar_Respuesta("Empleado",Empleado)
              Agregar_Respuesta("Fecha_Desde",Fecha_Desde)
              Agregar_Respuesta("Fecha_Hasta",Fecha_Hasta)
          End sub
          <ProtoContract>
          Public Class HistorialDeActividadEnRegistrosPorEmpleado_FilaC
                <ProtoMember(100)>  Public Empleado As String
                <ProtoMember(101)>  Public Fecha As Date?
                <ProtoMember(102)>  Public Ubicacion As String
                <ProtoMember(103)>  Public Dato As String
                <ProtoMember(104)>  Public DatoIcono As Guid
                <ProtoMember(105)>  Public Seccion As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Empleado = o("Empleado").STR
              Me.Fecha = o("Fecha").ToDateTime_UTC
              Me.Ubicacion = o("Ubicacion").STR
              Me.Dato = o("Dato").STR
              Me.DatoIcono = o("DatoIcono").ToGuid
              Me.Seccion = o("Seccion").STR
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of HistorialDeActividadEnRegistrosPorEmpleado_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New HistorialDeActividadEnRegistrosPorEmpleado_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class HistorialDePapeleraDeRegistrosPorEmpleadoC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of HistorialDePapeleraDeRegistrosPorEmpleado_FilaC)
          Public TokenCambios As Guid
          Sub new(Empleado As Guid, Fecha_Desde As Date, Fecha_Hasta As Date)
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("b3467ee5-a275-4077-b9c4-204e09a0651b"))
              me.ID = new GUID("b3467ee5-a275-4077-b9c4-204e09a0651b")
              me.Titulo  = "Historial de papelera de registros por empleado"
              Agregar_Respuesta("Empleado",Empleado)
              Agregar_Respuesta("Fecha_Desde",Fecha_Desde)
              Agregar_Respuesta("Fecha_Hasta",Fecha_Hasta)
          End sub
          <ProtoContract>
          Public Class HistorialDePapeleraDeRegistrosPorEmpleado_FilaC
                <ProtoMember(100)>  Public Empleado As String
                <ProtoMember(101)>  Public Tipodeaccion As Integer
                <ProtoMember(102)>  Public Dato As String
                <ProtoMember(103)>  Public Fecha As Date?
                <ProtoMember(104)>  Public DatoIcono As Guid
                <ProtoMember(105)>  Public Seccion As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Empleado = o("Empleado").STR
              Me.Tipodeaccion = ctype(o("Tipodeaccion").INT(0), EnumRAAccionPapeleraE)
              Me.Dato = o("Dato").STR
              Me.Fecha = o("Fecha").ToDateTime_UTC
              Me.DatoIcono = o("DatoIcono").ToGuid
              Me.Seccion = o("Seccion").STR
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of HistorialDePapeleraDeRegistrosPorEmpleado_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New HistorialDePapeleraDeRegistrosPorEmpleado_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
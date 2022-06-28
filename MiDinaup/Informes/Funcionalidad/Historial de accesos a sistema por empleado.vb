Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class HistorialDeAccesosASistemaPorEmpleadoC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of HistorialDeAccesosASistemaPorEmpleado_FilaC)
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of HistorialDeAccesosASistemaPorEmpleado_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Creando_Filas.Add(New HistorialDeAccesosASistemaPorEmpleado_FilaC(Actual))
                    Next
                End If
                Me.Filas = Creando_Filas
            End Sub
          Sub new(Empleado As Guid, Fecha_Desde As Date, Fecha_Hasta As Date)
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("74e2ef22-00bb-4330-a03a-fa43cef5c755"))
              me.ID = new GUID("74e2ef22-00bb-4330-a03a-fa43cef5c755")
              me.Titulo  = "Historial de accesos a sistema por empleado"
              Agregar_Respuesta("Empleado",Empleado)
              Agregar_Respuesta("Fecha_Desde",Fecha_Desde)
              Agregar_Respuesta("Fecha_Hasta",Fecha_Hasta)
          End sub
          Public Class HistorialDeAccesosASistemaPorEmpleado_FilaC
              Public Empleado As String
              Public Fecha As Date?
              Public Tipo As Integer
              Public Ubicacion As String
              Public Equipo As String
              Public DireccionIP As String
              Public UsuariodeWindows As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Empleado = o("Empleado").STR
              Me.Fecha = o("Fecha").ToDateTime_UTC
              Me.Tipo = o("Tipo").INT
              Me.Ubicacion = o("Ubicacion").STR
              Me.Equipo = o("Equipo").STR
              Me.DireccionIP = o("DireccionIP").STR
              Me.UsuariodeWindows = o("UsuariodeWindows").STR
              End Sub
          End Class
      End Class
  End Class
End Class
Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class CalendariosDeEmpleadosTurnosRealizadosC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of CalendariosDeEmpleadosTurnosRealizados_FilaC)
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of CalendariosDeEmpleadosTurnosRealizados_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Creando_Filas.Add(New CalendariosDeEmpleadosTurnosRealizados_FilaC(Actual))
                    Next
                End If
                Me.Filas = Creando_Filas
            End Sub
          Sub new(Empleado As Guid, Fecha_Desde As Date, Fecha_Hasta As Date)
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("d51b72c9-3d6a-4647-879f-3b5ab8de36f1"))
              me.ID = new GUID("d51b72c9-3d6a-4647-879f-3b5ab8de36f1")
              me.Titulo  = "Calendarios de Empleados > Turnos realizados"
              Agregar_Respuesta("Empleado",Empleado)
              Agregar_Respuesta("Fecha_Desde",Fecha_Desde)
              Agregar_Respuesta("Fecha_Hasta",Fecha_Hasta)
          End sub
          Public Class CalendariosDeEmpleadosTurnosRealizados_FilaC
              Public Fecha As Date?
              Public Tipo As Integer
              Public Duracion As Integer
              Public Realizacion As Integer
              Public Estado As Integer
              Public Fuerzamayor As Boolean
              Public HExtraNomina As Decimal
              Public AusenciaNomina As Decimal
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Fecha = o("Fecha").ToDate
              Me.Tipo = o("Tipo").INT
              Me.Duracion = o("Duracion").INT
              Me.Realizacion = o("Realizacion").INT
              Me.Estado = o("Estado").INT
              Me.Fuerzamayor = o("Fuerzamayor").BOOL
              Me.HExtraNomina = o("HExtraNomina").DEC
              Me.AusenciaNomina = o("AusenciaNomina").DEC
              End Sub
          End Class
      End Class
  End Class
End Class
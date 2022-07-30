Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class CalendariosDeEmpleadosTurnosRealizadosC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of CalendariosDeEmpleadosTurnosRealizados_FilaC)
          Public TokenCambios As Guid
          Sub new(Empleado As Guid, Fecha_Desde As Date, Fecha_Hasta As Date)
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("d51b72c9-3d6a-4647-879f-3b5ab8de36f1"))
              me.ID = new GUID("d51b72c9-3d6a-4647-879f-3b5ab8de36f1")
              me.Titulo  = "Calendarios de Empleados > Turnos realizados"
              Agregar_Respuesta("Empleado",Empleado)
              Agregar_Respuesta("Fecha_Desde",Fecha_Desde)
              Agregar_Respuesta("Fecha_Hasta",Fecha_Hasta)
          End sub
          <ProtoContract>
          Public Class CalendariosDeEmpleadosTurnosRealizados_FilaC
                <ProtoMember(100)>  Public Fecha As Date?
                <ProtoMember(101)>  Public Tipo As Integer
                <ProtoMember(102)>  Public Duracion As Integer
                <ProtoMember(103)>  Public Realizacion As Integer
                <ProtoMember(104)>  Public Estado As Integer
                <ProtoMember(105)>  Public Fuerzamayor As Boolean
                <ProtoMember(106)>  Public HExtraNomina As Decimal
                <ProtoMember(107)>  Public AusenciaNomina As Decimal
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Fecha = o("Fecha").ToDate
              Me.Tipo = ctype(o("Tipo").INT(0), EnumTipoDeTurnoE)
              Me.Duracion = o("Duracion").INT
              Me.Realizacion = o("Realizacion").INT
              Me.Estado = ctype(o("Estado").INT(0), EnumTipoDeRealizacionDeTurnoE)
              Me.Fuerzamayor = o("Fuerzamayor").BOOL
              Me.HExtraNomina = o("HExtraNomina").DEC
              Me.AusenciaNomina = o("AusenciaNomina").DEC
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of CalendariosDeEmpleadosTurnosRealizados_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New CalendariosDeEmpleadosTurnosRealizados_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
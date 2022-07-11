Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class HistorialDeAccesosASistemaPorEmpleadoC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of HistorialDeAccesosASistemaPorEmpleado_FilaC)
          Public TokenCambios As Guid
          Sub new(Empleado As Guid, Fecha_Desde As Date, Fecha_Hasta As Date)
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("74e2ef22-00bb-4330-a03a-fa43cef5c755"))
              me.ID = new GUID("74e2ef22-00bb-4330-a03a-fa43cef5c755")
              me.Titulo  = "Historial de accesos a sistema por empleado"
              Agregar_Respuesta("Empleado",Empleado)
              Agregar_Respuesta("Fecha_Desde",Fecha_Desde)
              Agregar_Respuesta("Fecha_Hasta",Fecha_Hasta)
          End sub
          <ProtoBuf.ProtoContract>
          Public Class HistorialDeAccesosASistemaPorEmpleado_FilaC
                <ProtoBuf.ProtoMember(100)>  Public Empleado As String
                <ProtoBuf.ProtoMember(101)>  Public Fecha As Date?
                <ProtoBuf.ProtoMember(102)>  Public Tipo As Integer
                <ProtoBuf.ProtoMember(103)>  Public Ubicacion As String
                <ProtoBuf.ProtoMember(104)>  Public Equipo As String
                <ProtoBuf.ProtoMember(105)>  Public DireccionIP As String
                <ProtoBuf.ProtoMember(106)>  Public UsuariodeWindows As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Empleado = o("Empleado").STR
              Me.Fecha = o("Fecha").ToDateTime_UTC
              Me.Tipo = ctype(o("Tipo").INT(0), EnumALogAccesoE)
              Me.Ubicacion = o("Ubicacion").STR
              Me.Equipo = o("Equipo").STR
              Me.DireccionIP = o("DireccionIP").STR
              Me.UsuariodeWindows = o("UsuariodeWindows").STR
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of HistorialDeAccesosASistemaPorEmpleado_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New HistorialDeAccesosASistemaPorEmpleado_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class TurnosDeEmpleadoC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of TurnosDeEmpleado_FilaC)
          Public TokenCambios As Guid
          Sub new(Empleado As Guid)
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("1fe7861e-95a1-40f9-aaac-183064744913"))
              me.ID = new GUID("1fe7861e-95a1-40f9-aaac-183064744913")
              me.Titulo  = "Turnos de empleado"
              Agregar_Respuesta("Empleado",Empleado)
          End sub
          <ProtoContract>
          Public Class TurnosDeEmpleado_FilaC
                <ProtoMember(100)>  Public Duracion As Integer
                <ProtoMember(101)>  Public Estado As Integer
                <ProtoMember(102)>  Public Inicio As Date?
                <ProtoMember(103)>  Public Fin As Date?
                <ProtoMember(104)>  Public Realizacion As Integer
                <ProtoMember(105)>  Public Ubicacion As String
                <ProtoMember(106)>  Public Empleado As String
                <ProtoMember(107)>  Public Margeninicio As Date?
                <ProtoMember(108)>  Public Descripcioncorta As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Duracion = o("Duracion").INT
              Me.Estado = ctype(o("Estado").INT(0), EnumTipoDeRealizacionDeTurnoE)
              Me.Inicio = o("Inicio").ToDateTime_UTC
              Me.Fin = o("Fin").ToDateTime_UTC
              Me.Realizacion = o("Realizacion").INT
              Me.Ubicacion = o("Ubicacion").STR
              Me.Empleado = o("Empleado").STR
              Me.Margeninicio = o("Margeninicio").ToDateTime_UTC
              Me.Descripcioncorta = o("Descripcioncorta").STR
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of TurnosDeEmpleado_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New TurnosDeEmpleado_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
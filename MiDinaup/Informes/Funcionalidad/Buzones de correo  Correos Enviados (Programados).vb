Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class BuzonesDeCorreoCorreosEnviadosProgramadosC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of BuzonesDeCorreoCorreosEnviadosProgramados_FilaC)
          Public TokenCambios As Guid
          Sub new(Buzon As Guid)
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("539db313-557f-4896-a1d5-f2572cb55f57"))
              me.ID = new GUID("539db313-557f-4896-a1d5-f2572cb55f57")
              me.Titulo  = "Buzones de correo > Correos Enviados (Programados)"
              Agregar_Respuesta("Buzon",Buzon)
          End sub
          <ProtoContract>
          Public Class BuzonesDeCorreoCorreosEnviadosProgramados_FilaC
                <ProtoMember(100)>  Public Empresa As String
                <ProtoMember(101)>  Public Empleado As String
                <ProtoMember(102)>  Public Asunto As String
                <ProtoMember(103)>  Public Fecha As Date?
                <ProtoMember(104)>  Public Archivos As Integer
                <ProtoMember(105)>  Public Estado As Integer
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Empresa = o("Empresa").STR
              Me.Empleado = o("Empleado").STR
              Me.Asunto = o("Asunto").STR
              Me.Fecha = o("Fecha").ToDateTime_UTC
              Me.Archivos = o("Archivos").INT
              Me.Estado = ctype(o("Estado").INT(0), EnumTramitacionE)
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of BuzonesDeCorreoCorreosEnviadosProgramados_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New BuzonesDeCorreoCorreosEnviadosProgramados_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
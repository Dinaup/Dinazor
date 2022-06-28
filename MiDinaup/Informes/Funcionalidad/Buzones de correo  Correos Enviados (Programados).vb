Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class BuzonesDeCorreoCorreosEnviadosProgramadosC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of BuzonesDeCorreoCorreosEnviadosProgramados_FilaC)
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of BuzonesDeCorreoCorreosEnviadosProgramados_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Creando_Filas.Add(New BuzonesDeCorreoCorreosEnviadosProgramados_FilaC(Actual))
                    Next
                End If
                Me.Filas = Creando_Filas
            End Sub
          Sub new(Buzon As Guid)
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("539db313-557f-4896-a1d5-f2572cb55f57"))
              me.ID = new GUID("539db313-557f-4896-a1d5-f2572cb55f57")
              me.Titulo  = "Buzones de correo > Correos Enviados (Programados)"
              Agregar_Respuesta("Buzon",Buzon)
          End sub
          Public Class BuzonesDeCorreoCorreosEnviadosProgramados_FilaC
              Public Empresa As String
              Public Empleado As String
              Public Asunto As String
              Public Fecha As Date?
              Public Archivos As Integer
              Public Estado As Integer
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Empresa = o("Empresa").STR
              Me.Empleado = o("Empleado").STR
              Me.Asunto = o("Asunto").STR
              Me.Fecha = o("Fecha").ToDateTime_UTC
              Me.Archivos = o("Archivos").INT
              Me.Estado = o("Estado").INT
              End Sub
          End Class
      End Class
  End Class
End Class
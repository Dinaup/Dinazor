Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class BuzonesDeCorreoCorreosEnviadosC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of BuzonesDeCorreoCorreosEnviados_FilaC)
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of BuzonesDeCorreoCorreosEnviados_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Creando_Filas.Add(New BuzonesDeCorreoCorreosEnviados_FilaC(Actual))
                    Next
                End If
                Me.Filas = Creando_Filas
            End Sub
          Sub new(Buzon As Guid)
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("d70fec44-99d9-40bc-a0b2-d296d9aa545b"))
              me.ID = new GUID("d70fec44-99d9-40bc-a0b2-d296d9aa545b")
              me.Titulo  = "Buzones de correo > Correos Enviados"
              Agregar_Respuesta("Buzon",Buzon)
          End sub
          Public Class BuzonesDeCorreoCorreosEnviados_FilaC
              Public Asunto As String
              Public Correodestino As String
              Public AsuntoIcono As Integer
              Public Fecha As Date?
              Public Entidad As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Asunto = o("Asunto").STR
              Me.Correodestino = o("Correodestino").STR
              Me.AsuntoIcono = o("AsuntoIcono").INT
              Me.Fecha = o("Fecha").ToDateTime_UTC
              Me.Entidad = o("Entidad").STR
              End Sub
          End Class
      End Class
  End Class
End Class
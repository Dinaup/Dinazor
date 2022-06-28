Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class MisContadoresC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of MisContadores_FilaC)
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of MisContadores_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Creando_Filas.Add(New MisContadores_FilaC(Actual))
                    Next
                End If
                Me.Filas = Creando_Filas
            End Sub
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("66170b32-99eb-45cd-a19b-5493232963bb"))
              me.ID = new GUID("66170b32-99eb-45cd-a19b-5493232963bb")
              me.Titulo  = "Mis contadores"
          End sub
          Public Class MisContadores_FilaC
              Public Seccion As String
              Public Dato As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Seccion = o("Seccion").STR
              Me.Dato = o("Dato").STR
              End Sub
          End Class
      End Class
  End Class
End Class
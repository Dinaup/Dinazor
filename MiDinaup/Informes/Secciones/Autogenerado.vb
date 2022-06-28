Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class PrincipalesD
      Public Class DefinicionesDePacksC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of DefinicionesDePacks_FilaC)
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of DefinicionesDePacks_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Creando_Filas.Add(New DefinicionesDePacks_FilaC(Actual))
                    Next
                End If
                Me.Filas = Creando_Filas
            End Sub
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("ac5f4b04-dbdd-0162-2d18-b925bcc484ca"))
              me.ID = new GUID("ac5f4b04-dbdd-0162-2d18-b925bcc484ca")
              me.Titulo  = "Definiciones de pack"
          End sub
          Public Class DefinicionesDePacks_FilaC
              Public Contenido As String
              Public Fecha As Date?
              Public Unidadesenpack As Integer
              Public TextoPrincipal As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Contenido = o("Contenido").STR
              Me.Fecha = o("Fecha").ToDateTime_UTC
              Me.Unidadesenpack = o("Unidadesenpack").INT
              Me.TextoPrincipal = o("TextoPrincipal").STR
              End Sub
          End Class
      End Class
  End Class
End Class
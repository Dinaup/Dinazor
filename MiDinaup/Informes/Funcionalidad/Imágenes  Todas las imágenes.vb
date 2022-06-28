Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class ImagenesTodasLasImagenesC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of ImagenesTodasLasImagenes_FilaC)
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of ImagenesTodasLasImagenes_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Creando_Filas.Add(New ImagenesTodasLasImagenes_FilaC(Actual))
                    Next
                End If
                Me.Filas = Creando_Filas
            End Sub
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("955fc3dc-aa37-49bd-a358-1568a66c38d2"))
              me.ID = new GUID("955fc3dc-aa37-49bd-a358-1568a66c38d2")
              me.Titulo  = "Imágenes > Todas las imágenes"
          End sub
          Public Class ImagenesTodasLasImagenes_FilaC
              Public ComentariosArchivo As Decimal
              Public Demodulo As Boolean
              Public Alto As Decimal
              Public Version As Decimal
              Public ID As Guid
              Public Tamano As Decimal
              Public TextoPrincipal As String
              Public Ancho As Decimal
              Public Empleado As String
              Public FechaUltimaModificacion As Date?
              Public FechaAltaSistema As Date?
              Public Extension As String
              Public ComentariosVersion As Decimal
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.ComentariosArchivo = o("ComentariosArchivo").DEC
              Me.Demodulo = o("Demodulo").BOOL
              Me.Alto = o("Alto").DEC
              Me.Version = o("Version").DEC
              Me.ID = o("ID").ToGuid
              Me.Tamano = o("Tamano").DEC
              Me.TextoPrincipal = o("TextoPrincipal").STR
              Me.Ancho = o("Ancho").DEC
              Me.Empleado = o("Empleado").STR
              Me.FechaUltimaModificacion = o("FechaUltimaModificacion").ToDateTime_UTC
              Me.FechaAltaSistema = o("FechaAltaSistema").ToDateTime_UTC
              Me.Extension = o("Extension").STR
              Me.ComentariosVersion = o("ComentariosVersion").DEC
              End Sub
          End Class
      End Class
  End Class
End Class
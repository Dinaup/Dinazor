Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class InformesTodosLosInformesC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of InformesTodosLosInformes_FilaC)
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of InformesTodosLosInformes_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Creando_Filas.Add(New InformesTodosLosInformes_FilaC(Actual))
                    Next
                End If
                Me.Filas = Creando_Filas
            End Sub
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("eeb28c83-c158-4226-8496-1bb53b7aa671"))
              me.ID = new GUID("eeb28c83-c158-4226-8496-1bb53b7aa671")
              me.Titulo  = "Informes > Todos los informes"
          End sub
          Public Class InformesTodosLosInformes_FilaC
              Public Ambito As Boolean
              Public Categoria As String
              Public FechaSincronizacion As Date?
              Public Subcategoria As String
              Public FechaIA As Date?
              Public TextoPrincipal As String
              Public FechaUltimaModificacion As Date?
              Public Eliminado As Boolean
              Public FechaAltaSistema As Date?
              Public ID As Guid
              Public Seccion As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Ambito = o("Ambito").BOOL
              Me.Categoria = o("Categoria").STR
              Me.FechaSincronizacion = o("FechaSincronizacion").ToDateTime_UTC
              Me.Subcategoria = o("Subcategoria").STR
              Me.FechaIA = o("FechaIA").ToDateTime_UTC
              Me.TextoPrincipal = o("TextoPrincipal").STR
              Me.FechaUltimaModificacion = o("FechaUltimaModificacion").ToDateTime_UTC
              Me.Eliminado = o("Eliminado").BOOL
              Me.FechaAltaSistema = o("FechaAltaSistema").ToDateTime_UTC
              Me.ID = o("ID").ToGuid
              Me.Seccion = o("Seccion").STR
              End Sub
          End Class
      End Class
  End Class
End Class
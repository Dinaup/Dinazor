Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class PanelesTodosLosPanelesC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of PanelesTodosLosPaneles_FilaC)
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of PanelesTodosLosPaneles_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Creando_Filas.Add(New PanelesTodosLosPaneles_FilaC(Actual))
                    Next
                End If
                Me.Filas = Creando_Filas
            End Sub
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("1a409397-01d3-4e4c-afae-aa1809753daa"))
              me.ID = new GUID("1a409397-01d3-4e4c-afae-aa1809753daa")
              me.Titulo  = "Paneles > Todos los paneles"
          End sub
          Public Class PanelesTodosLosPaneles_FilaC
              Public Tipo As Boolean
              Public FechaUltimaModificacion As Date?
              Public TextoPrincipal As String
              Public ID As Guid
              Public FechaAltaSistema As Date?
              Public Eliminado As Boolean
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Tipo = o("Tipo").BOOL
              Me.FechaUltimaModificacion = o("FechaUltimaModificacion").ToDateTime_UTC
              Me.TextoPrincipal = o("TextoPrincipal").STR
              Me.ID = o("ID").ToGuid
              Me.FechaAltaSistema = o("FechaAltaSistema").ToDateTime_UTC
              Me.Eliminado = o("Eliminado").BOOL
              End Sub
          End Class
      End Class
  End Class
End Class
Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class CamposTodosLosCamposC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of CamposTodosLosCampos_FilaC)
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of CamposTodosLosCampos_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Creando_Filas.Add(New CamposTodosLosCampos_FilaC(Actual))
                    Next
                End If
                Me.Filas = Creando_Filas
            End Sub
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("3475cb8a-117d-4d10-bd6a-7a66e401000c"))
              me.ID = new GUID("3475cb8a-117d-4d10-bd6a-7a66e401000c")
              me.Titulo  = "Campos > Todos los campos"
          End sub
          Public Class CamposTodosLosCampos_FilaC
              Public SeccionAgrupada As String
              Public Formato As Decimal
              Public Titulo As String
              Public EtiquetaAbreviada As String
              Public FechaAltaSistema As Date?
              Public Rolespecialdefuncionalidad As Decimal
              Public Copiarnombrealagregarrelacion As Boolean
              Public SeccionrelacionadaID As Guid
              Public Eliminado As Boolean
              Public Indexado As Boolean
              Public EsBase As Boolean
              Public ID As Guid
              Public Etiqueta As String
              Public VisibleRI As Boolean
              Public Seccion As String
              Public FechaUltimaModificacion As Date?
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.SeccionAgrupada = o("SeccionAgrupada").STR
              Me.Formato = o("Formato").DEC
              Me.Titulo = o("Titulo").STR
              Me.EtiquetaAbreviada = o("EtiquetaAbreviada").STR
              Me.FechaAltaSistema = o("FechaAltaSistema").ToDateTime_UTC
              Me.Rolespecialdefuncionalidad = o("Rolespecialdefuncionalidad").DEC
              Me.Copiarnombrealagregarrelacion = o("Copiarnombrealagregarrelacion").BOOL
              Me.SeccionrelacionadaID = o("SeccionrelacionadaID").ToGuid
              Me.Eliminado = o("Eliminado").BOOL
              Me.Indexado = o("Indexado").BOOL
              Me.EsBase = o("EsBase").BOOL
              Me.ID = o("ID").ToGuid
              Me.Etiqueta = o("Etiqueta").STR
              Me.VisibleRI = o("VisibleRI").BOOL
              Me.Seccion = o("Seccion").STR
              Me.FechaUltimaModificacion = o("FechaUltimaModificacion").ToDateTime_UTC
              End Sub
          End Class
      End Class
  End Class
End Class
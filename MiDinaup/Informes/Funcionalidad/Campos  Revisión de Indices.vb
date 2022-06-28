Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class CamposRevisionDeIndicesC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of CamposRevisionDeIndices_FilaC)
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of CamposRevisionDeIndices_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Creando_Filas.Add(New CamposRevisionDeIndices_FilaC(Actual))
                    Next
                End If
                Me.Filas = Creando_Filas
            End Sub
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("66c1378a-ad58-4c3b-ac40-8e627cbbbdd2"))
              me.ID = new GUID("66c1378a-ad58-4c3b-ac40-8e627cbbbdd2")
              me.Titulo  = "Campos > Revisión de Indices"
          End sub
          Public Class CamposRevisionDeIndices_FilaC
              Public FechaAltaSistema As Date?
              Public Indexado As Boolean
              Public FechaUltimaModificacion As Date?
              Public Seccion As String
              Public Formato As Decimal
              Public CampoPR As String
              Public SeccionBase As String
              Public Etiqueta As String
              Public ID As Guid
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.FechaAltaSistema = o("FechaAltaSistema").ToDateTime_UTC
              Me.Indexado = o("Indexado").BOOL
              Me.FechaUltimaModificacion = o("FechaUltimaModificacion").ToDateTime_UTC
              Me.Seccion = o("Seccion").STR
              Me.Formato = o("Formato").DEC
              Me.CampoPR = o("CampoPR").STR
              Me.SeccionBase = o("SeccionBase").STR
              Me.Etiqueta = o("Etiqueta").STR
              Me.ID = o("ID").ToGuid
              End Sub
          End Class
      End Class
  End Class
End Class
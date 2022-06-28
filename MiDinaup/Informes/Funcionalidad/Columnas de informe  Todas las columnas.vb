Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class ColumnasDeInformeTodasLasColumnasC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of ColumnasDeInformeTodasLasColumnas_FilaC)
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of ColumnasDeInformeTodasLasColumnas_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Creando_Filas.Add(New ColumnasDeInformeTodasLasColumnas_FilaC(Actual))
                    Next
                End If
                Me.Filas = Creando_Filas
            End Sub
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("9eb722e7-11b4-4aa0-9195-b8422ec581f1"))
              me.ID = new GUID("9eb722e7-11b4-4aa0-9195-b8422ec581f1")
              me.Titulo  = "Columnas de informe > Todas las columnas"
          End sub
          Public Class ColumnasDeInformeTodasLasColumnas_FilaC
              Public Titulo As String
              Public FechaUltimaModificacion As Date?
              Public ID As Guid
              Public Seccion As String
              Public Eliminado As Boolean
              Public Informe As String
              Public FechaAltaSistema As Date?
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Titulo = o("Titulo").STR
              Me.FechaUltimaModificacion = o("FechaUltimaModificacion").ToDateTime_UTC
              Me.ID = o("ID").ToGuid
              Me.Seccion = o("Seccion").STR
              Me.Eliminado = o("Eliminado").BOOL
              Me.Informe = o("Informe").STR
              Me.FechaAltaSistema = o("FechaAltaSistema").ToDateTime_UTC
              End Sub
          End Class
      End Class
  End Class
End Class
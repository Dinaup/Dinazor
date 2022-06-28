Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class AlgoritmosTodosLosAlgoritmosC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of AlgoritmosTodosLosAlgoritmos_FilaC)
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of AlgoritmosTodosLosAlgoritmos_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Creando_Filas.Add(New AlgoritmosTodosLosAlgoritmos_FilaC(Actual))
                    Next
                End If
                Me.Filas = Creando_Filas
            End Sub
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("6289a491-c9fd-4682-8e97-91409988c5e7"))
              me.ID = new GUID("6289a491-c9fd-4682-8e97-91409988c5e7")
              me.Titulo  = "Algoritmos > Todos los Algoritmos"
          End sub
          Public Class AlgoritmosTodosLosAlgoritmos_FilaC
              Public Eliminado As Decimal
              Public FechaAltaSistema As Date?
              Public Seccion As String
              Public Tipodedato As Decimal
              Public DatosSecundariosRelacionID As Guid
              Public SeccionRelacion As String
              Public TextoPrincipal As String
              Public Publico As Boolean
              Public FechaUltimaModificacion As Date?
              Public SeccionID As Guid
              Public Categoria As String
              Public Tipodealgoritmo As Decimal
              Public Subcategoria As String
              Public NombreIcono As Guid
              Public Obsoleto As Boolean
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Eliminado = o("Eliminado").DEC
              Me.FechaAltaSistema = o("FechaAltaSistema").ToDateTime_UTC
              Me.Seccion = o("Seccion").STR
              Me.Tipodedato = o("Tipodedato").DEC
              Me.DatosSecundariosRelacionID = o("DatosSecundariosRelacionID").ToGuid
              Me.SeccionRelacion = o("SeccionRelacion").STR
              Me.TextoPrincipal = o("TextoPrincipal").STR
              Me.Publico = o("Publico").BOOL
              Me.FechaUltimaModificacion = o("FechaUltimaModificacion").ToDateTime_UTC
              Me.SeccionID = o("SeccionID").ToGuid
              Me.Categoria = o("Categoria").STR
              Me.Tipodealgoritmo = o("Tipodealgoritmo").DEC
              Me.Subcategoria = o("Subcategoria").STR
              Me.NombreIcono = o("NombreIcono").ToGuid
              Me.Obsoleto = o("Obsoleto").BOOL
              End Sub
          End Class
      End Class
  End Class
End Class
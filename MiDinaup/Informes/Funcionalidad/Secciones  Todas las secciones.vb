Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class SeccionesTodasLasSeccionesC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of SeccionesTodasLasSecciones_FilaC)
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of SeccionesTodasLasSecciones_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Creando_Filas.Add(New SeccionesTodasLasSecciones_FilaC(Actual))
                    Next
                End If
                Me.Filas = Creando_Filas
            End Sub
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("c0966773-c4b3-4474-b7a4-3c40c9614a83"))
              me.ID = new GUID("c0966773-c4b3-4474-b7a4-3c40c9614a83")
              me.Titulo  = "Secciones > Todas las secciones"
          End sub
          Public Class SeccionesTodasLasSecciones_FilaC
              Public EtiquetaTextoPrincipal As String
              Public Femenina As Boolean
              Public SeccionBase As String
              Public FechaAltaSistema As Date?
              Public IconocolorAlto As Decimal
              Public EtiquetaSingular As String
              Public Obsoleto As Boolean
              Public Iconoalto As Decimal
              Public Titulo As String
              Public IconoID As Guid
              Public Motordealmacenamiento As Decimal
              Public IconocolorID As Guid
              Public FechaUltimaModificacion As Date?
              Public Exportable As Boolean
              Public Etiquetaautomatica As Boolean
              Public Derivable As Boolean
              Public ID As Guid
              Public EtiquetaPlural As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.EtiquetaTextoPrincipal = o("EtiquetaTextoPrincipal").STR
              Me.Femenina = o("Femenina").BOOL
              Me.SeccionBase = o("SeccionBase").STR
              Me.FechaAltaSistema = o("FechaAltaSistema").ToDateTime_UTC
              Me.IconocolorAlto = o("IconocolorAlto").DEC
              Me.EtiquetaSingular = o("EtiquetaSingular").STR
              Me.Obsoleto = o("Obsoleto").BOOL
              Me.Iconoalto = o("Iconoalto").DEC
              Me.Titulo = o("Titulo").STR
              Me.IconoID = o("IconoID").ToGuid
              Me.Motordealmacenamiento = o("Motordealmacenamiento").DEC
              Me.IconocolorID = o("IconocolorID").ToGuid
              Me.FechaUltimaModificacion = o("FechaUltimaModificacion").ToDateTime_UTC
              Me.Exportable = o("Exportable").BOOL
              Me.Etiquetaautomatica = o("Etiquetaautomatica").BOOL
              Me.Derivable = o("Derivable").BOOL
              Me.ID = o("ID").ToGuid
              Me.EtiquetaPlural = o("EtiquetaPlural").STR
              End Sub
          End Class
      End Class
  End Class
End Class
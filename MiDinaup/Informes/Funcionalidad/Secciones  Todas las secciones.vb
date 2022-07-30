Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class SeccionesTodasLasSeccionesC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of SeccionesTodasLasSecciones_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("c0966773-c4b3-4474-b7a4-3c40c9614a83"))
              me.ID = new GUID("c0966773-c4b3-4474-b7a4-3c40c9614a83")
              me.Titulo  = "Secciones > Todas las secciones"
          End sub
          <ProtoContract>
          Public Class SeccionesTodasLasSecciones_FilaC
                <ProtoMember(100)>  Public EtiquetaTextoPrincipal As String
                <ProtoMember(101)>  Public Femenina As Boolean
                <ProtoMember(102)>  Public SeccionBase As String
                <ProtoMember(103)>  Public FechaAltaSistema As DateTime
                <ProtoMember(104)>  Public IconocolorAlto As Decimal
                <ProtoMember(105)>  Public EtiquetaSingular As String
                <ProtoMember(106)>  Public Obsoleto As Boolean
                <ProtoMember(107)>  Public Iconoalto As Decimal
                <ProtoMember(108)>  Public Titulo As String
                <ProtoMember(109)>  Public IconoID As Guid
                <ProtoMember(110)>  Public Motordealmacenamiento As Decimal
                <ProtoMember(111)>  Public IconocolorID As Guid
                <ProtoMember(112)>  Public FechaUltimaModificacion As DateTime
                <ProtoMember(113)>  Public Exportable As Boolean
                <ProtoMember(114)>  Public Etiquetaautomatica As Boolean
                <ProtoMember(115)>  Public Derivable As Boolean
                <ProtoMember(116)>  Public ID As Guid
                <ProtoMember(117)>  Public EtiquetaPlural As String
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
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of SeccionesTodasLasSecciones_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New SeccionesTodasLasSecciones_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
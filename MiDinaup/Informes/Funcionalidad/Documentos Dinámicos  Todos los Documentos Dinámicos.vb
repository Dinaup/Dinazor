Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class DocumentosDinamicosTodosLosDocumentosDinamicosC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of DocumentosDinamicosTodosLosDocumentosDinamicos_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("acd19d19-a4cc-4e0b-8235-3dd5cc0689d1"))
              me.ID = new GUID("acd19d19-a4cc-4e0b-8235-3dd5cc0689d1")
              me.Titulo  = "Documentos Dinámicos > Todos los Documentos Dinámicos"
          End sub
          <ProtoBuf.ProtoContract>
          Public Class DocumentosDinamicosTodosLosDocumentosDinamicos_FilaC
                <ProtoBuf.ProtoMember(100)>  Public FechaAltaSistema As DateTime
                <ProtoBuf.ProtoMember(101)>  Public TextoPrincipal As String
                <ProtoBuf.ProtoMember(102)>  Public Subcategoria As String
                <ProtoBuf.ProtoMember(103)>  Public ID As Guid
                <ProtoBuf.ProtoMember(104)>  Public FechaUltimaModificacion As DateTime
                <ProtoBuf.ProtoMember(105)>  Public Categoria As String
                <ProtoBuf.ProtoMember(106)>  Public Eliminado As Boolean
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.FechaAltaSistema = o("FechaAltaSistema").ToDateTime_UTC
              Me.TextoPrincipal = o("TextoPrincipal").STR
              Me.Subcategoria = o("Subcategoria").STR
              Me.ID = o("ID").ToGuid
              Me.FechaUltimaModificacion = o("FechaUltimaModificacion").ToDateTime_UTC
              Me.Categoria = o("Categoria").STR
              Me.Eliminado = o("Eliminado").BOOL
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of DocumentosDinamicosTodosLosDocumentosDinamicos_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New DocumentosDinamicosTodosLosDocumentosDinamicos_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
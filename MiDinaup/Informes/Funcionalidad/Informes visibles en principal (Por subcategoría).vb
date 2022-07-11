Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class InformesVisiblesEnPrincipalPorSubcategoriaC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of InformesVisiblesEnPrincipalPorSubcategoria_FilaC)
          Public TokenCambios As Guid
          Sub new(Categoria As String, Subcategoria As String)
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("476fda66-2190-4df0-8d29-dde2093ba728"))
              me.ID = new GUID("476fda66-2190-4df0-8d29-dde2093ba728")
              me.Titulo  = "Informes visibles en principal (Por subcategoría)"
              Agregar_Respuesta("Categoria",Categoria)
              Agregar_Respuesta("Subcategoria",Subcategoria)
          End sub
          <ProtoBuf.ProtoContract>
          Public Class InformesVisiblesEnPrincipalPorSubcategoria_FilaC
                <ProtoBuf.ProtoMember(100)>  Public TextoPrincipal As String
                <ProtoBuf.ProtoMember(101)>  Public InformeIcono As Guid
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.TextoPrincipal = o("TextoPrincipal").STR
              Me.InformeIcono = o("InformeIcono").ToGuid
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of InformesVisiblesEnPrincipalPorSubcategoria_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New InformesVisiblesEnPrincipalPorSubcategoria_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
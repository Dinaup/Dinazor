Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class InformesVisiblesEnPrincipalPorCategoriaC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of InformesVisiblesEnPrincipalPorCategoria_FilaC)
          Public TokenCambios As Guid
          Sub new(Categoria As String)
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("3e80a60e-e0f8-435f-b1b7-00920ac365e3"))
              me.ID = new GUID("3e80a60e-e0f8-435f-b1b7-00920ac365e3")
              me.Titulo  = "Informes visibles en principal (Por categoría)"
              Agregar_Respuesta("Categoria",Categoria)
          End sub
          <ProtoContract>
          Public Class InformesVisiblesEnPrincipalPorCategoria_FilaC
                <ProtoMember(100)>  Public TextoPrincipal As String
                <ProtoMember(101)>  Public InformeIcono As Guid
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.TextoPrincipal = o("TextoPrincipal").STR
              Me.InformeIcono = o("InformeIcono").ToGuid
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of InformesVisiblesEnPrincipalPorCategoria_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New InformesVisiblesEnPrincipalPorCategoria_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
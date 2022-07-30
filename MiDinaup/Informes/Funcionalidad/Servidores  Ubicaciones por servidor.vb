Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class ServidoresUbicacionesPorServidorC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of ServidoresUbicacionesPorServidor_FilaC)
          Public TokenCambios As Guid
          Sub new(Servidor As Guid)
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("94e091dc-bbf7-481e-bd47-605f6876189e"))
              me.ID = new GUID("94e091dc-bbf7-481e-bd47-605f6876189e")
              me.Titulo  = "Servidores > Ubicaciones por servidor"
              Agregar_Respuesta("Servidor",Servidor)
          End sub
          <ProtoContract>
          Public Class ServidoresUbicacionesPorServidor_FilaC
                <ProtoMember(100)>  Public TextoPrincipal As String
                <ProtoMember(101)>  Public Telefono As String
                <ProtoMember(102)>  Public Direccion As String
                <ProtoMember(103)>  Public CodigoPostal As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.TextoPrincipal = o("TextoPrincipal").STR
              Me.Telefono = o("Telefono").STR
              Me.Direccion = o("Direccion").STR
              Me.CodigoPostal = o("CodigoPostal").STR
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of ServidoresUbicacionesPorServidor_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New ServidoresUbicacionesPorServidor_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
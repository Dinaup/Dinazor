Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class ServidoresUbicacionesPorServidorC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of ServidoresUbicacionesPorServidor_FilaC)
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of ServidoresUbicacionesPorServidor_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Creando_Filas.Add(New ServidoresUbicacionesPorServidor_FilaC(Actual))
                    Next
                End If
                Me.Filas = Creando_Filas
            End Sub
          Sub new(Servidor As Guid)
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("94e091dc-bbf7-481e-bd47-605f6876189e"))
              me.ID = new GUID("94e091dc-bbf7-481e-bd47-605f6876189e")
              me.Titulo  = "Servidores > Ubicaciones por servidor"
              Agregar_Respuesta("Servidor",Servidor)
          End sub
          Public Class ServidoresUbicacionesPorServidor_FilaC
              Public TextoPrincipal As String
              Public Telefono As String
              Public Direccion As String
              Public CodigoPostal As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.TextoPrincipal = o("TextoPrincipal").STR
              Me.Telefono = o("Telefono").STR
              Me.Direccion = o("Direccion").STR
              Me.CodigoPostal = o("CodigoPostal").STR
              End Sub
          End Class
      End Class
  End Class
End Class
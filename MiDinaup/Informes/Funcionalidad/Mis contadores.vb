Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class MisContadoresC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of MisContadores_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("66170b32-99eb-45cd-a19b-5493232963bb"))
              me.ID = new GUID("66170b32-99eb-45cd-a19b-5493232963bb")
              me.Titulo  = "Mis contadores"
          End sub
          <ProtoContract>
          Public Class MisContadores_FilaC
                <ProtoMember(100)>  Public Seccion As String
                <ProtoMember(101)>  Public Dato As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Seccion = o("Seccion").STR
              Me.Dato = o("Dato").STR
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of MisContadores_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New MisContadores_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
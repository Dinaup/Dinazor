Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class APIVentas__4C
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of APIVentas__4_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("2b33317c-9865-414e-9a94-ad14955d7a22"))
              me.ID = new GUID("2b33317c-9865-414e-9a94-ad14955d7a22")
              me.Titulo  = "API - Ventas"
          End sub
          <ProtoContract>
          Public Class APIVentas__4_FilaC
                <ProtoMember(100)>  Public TextoPrincipal As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.TextoPrincipal = o("TextoPrincipal").STR
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of APIVentas__4_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New APIVentas__4_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
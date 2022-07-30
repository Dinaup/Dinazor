Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class PanelInmovilizadosInmovilizadosC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of PanelInmovilizadosInmovilizados_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("1f8644a2-c5f6-4d10-b793-86c04ff28a05"))
              me.ID = new GUID("1f8644a2-c5f6-4d10-b793-86c04ff28a05")
              me.Titulo  = "Panel Inmovilizados > Inmovilizados"
          End sub
          <ProtoContract>
          Public Class PanelInmovilizadosInmovilizados_FilaC
                <ProtoMember(100)>  Public TextoPrincipal As String
                <ProtoMember(101)>  Public Amortizacion As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.TextoPrincipal = o("TextoPrincipal").STR
              Me.Amortizacion = o("Amortizacion").STR
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of PanelInmovilizadosInmovilizados_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New PanelInmovilizadosInmovilizados_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
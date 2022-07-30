Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class PanelesD
      Public Class PanelTesoreriaTopEntidadesQueMasDebenAEmpresaC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of PanelTesoreriaTopEntidadesQueMasDebenAEmpresa_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("4e8b6e8b-94fd-4b57-83c5-af3370f1eecf"))
              me.ID = new GUID("4e8b6e8b-94fd-4b57-83c5-af3370f1eecf")
              me.Titulo  = "Panel Tesorería > Top Entidades que más deben a empresa"
          End sub
          <ProtoContract>
          Public Class PanelTesoreriaTopEntidadesQueMasDebenAEmpresa_FilaC
                <ProtoMember(100)>  Public TextoPrincipal As String
                <ProtoMember(101)>  Public DebeaEmpresa As Decimal
                <ProtoMember(102)>  Public FotoID As Guid
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.TextoPrincipal = o("TextoPrincipal").STR
              Me.DebeaEmpresa = o("DebeaEmpresa").DEC
              Me.FotoID = o("FotoID").ToGuid
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of PanelTesoreriaTopEntidadesQueMasDebenAEmpresa_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New PanelTesoreriaTopEntidadesQueMasDebenAEmpresa_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
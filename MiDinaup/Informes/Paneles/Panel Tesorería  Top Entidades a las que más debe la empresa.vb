Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class PanelesD
      Public Class PanelTesoreriaTopEntidadesALasQueMasDebeLaEmpresaC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of PanelTesoreriaTopEntidadesALasQueMasDebeLaEmpresa_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("17ebaef1-76e6-451f-9658-3accd7f9f0d5"))
              me.ID = new GUID("17ebaef1-76e6-451f-9658-3accd7f9f0d5")
              me.Titulo  = "Panel Tesorería > Top Entidades a las que más debe la empresa"
          End sub
          <ProtoContract>
          Public Class PanelTesoreriaTopEntidadesALasQueMasDebeLaEmpresa_FilaC
                <ProtoMember(100)>  Public TextoPrincipal As String
                <ProtoMember(101)>  Public Empresaledebe As Decimal
                <ProtoMember(102)>  Public FotoID As Guid
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.TextoPrincipal = o("TextoPrincipal").STR
              Me.Empresaledebe = o("Empresaledebe").DEC
              Me.FotoID = o("FotoID").ToGuid
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of PanelTesoreriaTopEntidadesALasQueMasDebeLaEmpresa_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New PanelTesoreriaTopEntidadesALasQueMasDebeLaEmpresa_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class IncrustadosD
      Public Class DetallesDeVehiculosDetallesDeRecambiosC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of DetallesDeVehiculosDetallesDeRecambios_FilaC)
          Public TokenCambios As Guid
          Sub new(DetalleDeVehiculo As Guid)
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("612e5be9-a32a-462d-b676-8d84f0806702"))
              me.ID = new GUID("612e5be9-a32a-462d-b676-8d84f0806702")
              me.Titulo  = "Detalles de Vehículos > Detalles de Recambios"
              Agregar_Respuesta("DetalleDeVehiculo",DetalleDeVehiculo)
          End sub
          <ProtoContract>
          Public Class DetallesDeVehiculosDetallesDeRecambios_FilaC
                <ProtoMember(100)>  Public Foto As Guid
                <ProtoMember(101)>  Public TextoPrincipal As String
                <ProtoMember(102)>  Public UnidadesporVehiculo As Integer
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Foto = o("Foto").ToGuid
              Me.TextoPrincipal = o("TextoPrincipal").STR
              Me.UnidadesporVehiculo = o("UnidadesporVehiculo").INT
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of DetallesDeVehiculosDetallesDeRecambios_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New DetallesDeVehiculosDetallesDeRecambios_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class VehiculosParaDesguaceRecambiosC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of VehiculosParaDesguaceRecambios_FilaC)
          Public TokenCambios As Guid
          Sub new(Vehiculo As Guid)
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("9476184e-07f8-4006-9f2e-b866ab79eaed"))
              me.ID = new GUID("9476184e-07f8-4006-9f2e-b866ab79eaed")
              me.Titulo  = "Vehículos para desguace > Recambios"
              Agregar_Respuesta("Vehiculo",Vehiculo)
          End sub
          <ProtoContract>
          Public Class VehiculosParaDesguaceRecambios_FilaC
                <ProtoMember(100)>  Public TextoPrincipal As String
                <ProtoMember(101)>  Public Estado As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.TextoPrincipal = o("TextoPrincipal").STR
              Me.Estado = o("Estado").STR
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of VehiculosParaDesguaceRecambios_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New VehiculosParaDesguaceRecambios_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
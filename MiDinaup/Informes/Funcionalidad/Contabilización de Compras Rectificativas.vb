Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class ContabilizacionDeComprasRectificativasC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of ContabilizacionDeComprasRectificativas_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("ab4b6ccc-1940-4288-a8b8-6ab97752a8fa"))
              me.ID = new GUID("ab4b6ccc-1940-4288-a8b8-6ab97752a8fa")
              me.Titulo  = "Contabilización de Compras Rectificativas"
          End sub
          <ProtoContract>
          Public Class ContabilizacionDeComprasRectificativas_FilaC
                <ProtoMember(100)>  Public TextoPrincipal As String
                <ProtoMember(101)>  Public Proveedor As String
                <ProtoMember(102)>  Public Numero As String
                <ProtoMember(103)>  Public Fecha As Date?
                <ProtoMember(104)>  Public Asiento As String
                <ProtoMember(105)>  Public AsientoImporte As Decimal
                <ProtoMember(106)>  Public Ubicacion As String
                <ProtoMember(107)>  Public Retencion As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.TextoPrincipal = o("TextoPrincipal").STR
              Me.Proveedor = o("Proveedor").STR
              Me.Numero = o("Numero").STR
              Me.Fecha = o("Fecha").ToDate
              Me.Asiento = o("Asiento").STR
              Me.AsientoImporte = o("AsientoImporte").DEC
              Me.Ubicacion = o("Ubicacion").STR
              Me.Retencion = o("Retencion").STR
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of ContabilizacionDeComprasRectificativas_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New ContabilizacionDeComprasRectificativas_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class ContabilizacionVentasRectificativasC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of ContabilizacionVentasRectificativas_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("ec6ddf39-097a-40eb-8599-fa7754cf3c87"))
              me.ID = new GUID("ec6ddf39-097a-40eb-8599-fa7754cf3c87")
              me.Titulo  = "Contabilización Ventas Rectificativas"
          End sub
          <ProtoContract>
          Public Class ContabilizacionVentasRectificativas_FilaC
                <ProtoMember(100)>  Public TextoPrincipal As String
                <ProtoMember(101)>  Public Cliente As String
                <ProtoMember(102)>  Public Total As Decimal
                <ProtoMember(103)>  Public Fecha As Date?
                <ProtoMember(104)>  Public Asiento As String
                <ProtoMember(105)>  Public AsientoImporte As Decimal
                <ProtoMember(106)>  Public Ubicacion As String
                <ProtoMember(107)>  Public Tipo As String
                <ProtoMember(108)>  Public Retencion As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.TextoPrincipal = o("TextoPrincipal").STR
              Me.Cliente = o("Cliente").STR
              Me.Total = o("Total").DEC
              Me.Fecha = o("Fecha").ToDate
              Me.Asiento = o("Asiento").STR
              Me.AsientoImporte = o("AsientoImporte").DEC
              Me.Ubicacion = o("Ubicacion").STR
              Me.Tipo = o("Tipo").STR
              Me.Retencion = o("Retencion").STR
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of ContabilizacionVentasRectificativas_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New ContabilizacionVentasRectificativas_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class ContabilizacionCobrosDeVentasC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of ContabilizacionCobrosDeVentas_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("fefbfc5b-dde9-4ea0-ab75-82d630963f2d"))
              me.ID = new GUID("fefbfc5b-dde9-4ea0-ab75-82d630963f2d")
              me.Titulo  = "Contabilización Cobros de Ventas"
          End sub
          <ProtoContract>
          Public Class ContabilizacionCobrosDeVentas_FilaC
                <ProtoMember(100)>  Public TextoPrincipal As String
                <ProtoMember(101)>  Public Cliente As String
                <ProtoMember(102)>  Public Total As Decimal
                <ProtoMember(103)>  Public Fecha As Date?
                <ProtoMember(104)>  Public AsientoImporte As Decimal
                <ProtoMember(105)>  Public Asiento As String
                <ProtoMember(106)>  Public UbicacionPrincipal As String
                <ProtoMember(107)>  Public Metododepago As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.TextoPrincipal = o("TextoPrincipal").STR
              Me.Cliente = o("Cliente").STR
              Me.Total = o("Total").DEC
              Me.Fecha = o("Fecha").ToDate
              Me.AsientoImporte = o("AsientoImporte").DEC
              Me.Asiento = o("Asiento").STR
              Me.UbicacionPrincipal = o("UbicacionPrincipal").STR
              Me.Metododepago = o("Metododepago").STR
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of ContabilizacionCobrosDeVentas_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New ContabilizacionCobrosDeVentas_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
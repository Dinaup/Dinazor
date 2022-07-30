Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class PanalVentasVentasOrdinariasEnTramiteC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of PanalVentasVentasOrdinariasEnTramite_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("63d56b2f-b232-4c21-b546-a39e9087bf2b"))
              me.ID = new GUID("63d56b2f-b232-4c21-b546-a39e9087bf2b")
              me.Titulo  = "Panal Ventas > Ventas Ordinarias (En trámite)"
          End sub
          <ProtoContract>
          Public Class PanalVentasVentasOrdinariasEnTramite_FilaC
                <ProtoMember(100)>  Public Cliente As String
                <ProtoMember(101)>  Public Fecha As Date?
                <ProtoMember(102)>  Public Total As Decimal
                <ProtoMember(103)>  Public ACobrar As Decimal
                <ProtoMember(104)>  Public Asalir As Decimal
                <ProtoMember(105)>  Public Cobrado As Decimal
                <ProtoMember(106)>  Public Salidos As Decimal
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Cliente = o("Cliente").STR
              Me.Fecha = o("Fecha").ToDateTime_UTC
              Me.Total = o("Total").DEC
              Me.ACobrar = o("ACobrar").DEC
              Me.Asalir = o("Asalir").DEC
              Me.Cobrado = o("Cobrado").DEC
              Me.Salidos = o("Salidos").DEC
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of PanalVentasVentasOrdinariasEnTramite_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New PanalVentasVentasOrdinariasEnTramite_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
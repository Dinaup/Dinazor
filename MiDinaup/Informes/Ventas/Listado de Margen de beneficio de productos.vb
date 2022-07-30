Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class VentasD
      Public Class ListadoDeMargenDeBeneficioDeProductosC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of ListadoDeMargenDeBeneficioDeProductos_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("4b390901-dc36-4959-8df8-39bd11b74fd1"))
              me.ID = new GUID("4b390901-dc36-4959-8df8-39bd11b74fd1")
              me.Titulo  = "Listado de Margen de beneficio de productos"
          End sub
          <ProtoContract>
          Public Class ListadoDeMargenDeBeneficioDeProductos_FilaC
                <ProtoMember(100)>  Public Nombredelproducto As String
                <ProtoMember(101)>  Public Beneficiossindescuentos As Decimal
                <ProtoMember(102)>  Public Beneficiocondescuentos As Decimal
                <ProtoMember(103)>  Public Fabricante As String
                <ProtoMember(104)>  Public Proveedor As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Nombredelproducto = o("Nombredelproducto").STR
              Me.Beneficiossindescuentos = o("Beneficiossindescuentos").DEC
              Me.Beneficiocondescuentos = o("Beneficiocondescuentos").DEC
              Me.Fabricante = o("Fabricante").STR
              Me.Proveedor = o("Proveedor").STR
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of ListadoDeMargenDeBeneficioDeProductos_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New ListadoDeMargenDeBeneficioDeProductos_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
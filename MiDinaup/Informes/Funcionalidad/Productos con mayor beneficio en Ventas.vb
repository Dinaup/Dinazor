Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class ProductosConMayorBeneficioEnVentasC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of ProductosConMayorBeneficioEnVentas_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("b7c535dd-d247-451e-87de-1a7427bac218"))
              me.ID = new GUID("b7c535dd-d247-451e-87de-1a7427bac218")
              me.Titulo  = "Productos con mayor beneficio en Ventas"
          End sub
          <ProtoContract>
          Public Class ProductosConMayorBeneficioEnVentas_FilaC
                <ProtoMember(100)>  Public Nombreproducto As String
                <ProtoMember(101)>  Public Imagen As Guid
                <ProtoMember(102)>  Public Beneficio As Decimal
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Nombreproducto = o("Nombreproducto").STR
              Me.Imagen = o("Imagen").ToGuid
              Me.Beneficio = o("Beneficio").DEC
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of ProductosConMayorBeneficioEnVentas_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New ProductosConMayorBeneficioEnVentas_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
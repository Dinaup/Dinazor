Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class VentasD
      Public Class BeneficioDeProductosC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of BeneficioDeProductos_FilaC)
          Public TokenCambios As Guid
          Sub new(Fecha_Desde As Date, Fecha_Hasta As Date)
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("c93c626f-ac78-478e-9950-adb6f6de65c2"))
              me.ID = new GUID("c93c626f-ac78-478e-9950-adb6f6de65c2")
              me.Titulo  = "Beneficio de productos"
              Agregar_Respuesta("Fecha_Desde",Fecha_Desde)
              Agregar_Respuesta("Fecha_Hasta",Fecha_Hasta)
          End sub
          <ProtoContract>
          Public Class BeneficioDeProductos_FilaC
                <ProtoMember(100)>  Public Producto As String
                <ProtoMember(101)>  Public Totalvendidos As Decimal
                <ProtoMember(102)>  Public BeneficioDespuesdedescuentos As Decimal
                <ProtoMember(103)>  Public Beneficioperdidopordescuentos As Decimal
                <ProtoMember(104)>  Public Clientes As Guid
                <ProtoMember(105)>  Public BeneficioAntesdedescuentos As Decimal
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Producto = o("Producto").STR
              Me.Totalvendidos = o("Totalvendidos").DEC
              Me.BeneficioDespuesdedescuentos = o("BeneficioDespuesdedescuentos").DEC
              Me.Beneficioperdidopordescuentos = o("Beneficioperdidopordescuentos").DEC
              Me.Clientes = o("Clientes").ToGuid
              Me.BeneficioAntesdedescuentos = o("BeneficioAntesdedescuentos").DEC
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of BeneficioDeProductos_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New BeneficioDeProductos_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
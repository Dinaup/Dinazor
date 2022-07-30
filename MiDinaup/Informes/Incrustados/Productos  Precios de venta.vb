Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class IncrustadosD
      Public Class ProductosPreciosDeVentaC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of ProductosPreciosDeVenta_FilaC)
          Public TokenCambios As Guid
          Sub new(Producto As Guid)
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("ed418a62-7d5d-433a-9948-db9be986f9e7"))
              me.ID = new GUID("ed418a62-7d5d-433a-9948-db9be986f9e7")
              me.Titulo  = "Productos > Precios de venta"
              Agregar_Respuesta("Producto",Producto)
          End sub
          <ProtoContract>
          Public Class ProductosPreciosDeVenta_FilaC
                <ProtoMember(100)>  Public Pedidomaximo As Decimal
                <ProtoMember(101)>  Public Pedidominimo As Decimal
                <ProtoMember(102)>  Public Impuesto As String
                <ProtoMember(103)>  Public Descuento As Decimal
                <ProtoMember(104)>  Public Saldopromocional As Decimal
                <ProtoMember(105)>  Public Catalogo As String
                <ProtoMember(106)>  Public Preciofinal As Decimal
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Pedidomaximo = o("Pedidomaximo").DEC
              Me.Pedidominimo = o("Pedidominimo").DEC
              Me.Impuesto = o("Impuesto").STR
              Me.Descuento = o("Descuento").DEC
              Me.Saldopromocional = o("Saldopromocional").DEC
              Me.Catalogo = o("Catalogo").STR
              Me.Preciofinal = o("Preciofinal").DEC
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of ProductosPreciosDeVenta_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New ProductosPreciosDeVenta_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
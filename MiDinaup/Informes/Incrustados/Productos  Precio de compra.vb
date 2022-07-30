Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class IncrustadosD
      Public Class ProductosPrecioDeCompraC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of ProductosPrecioDeCompra_FilaC)
          Public TokenCambios As Guid
          Sub new(Producto As Guid)
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("aa86396b-1822-4db5-8780-f362b6e2861e"))
              me.ID = new GUID("aa86396b-1822-4db5-8780-f362b6e2861e")
              me.Titulo  = "Productos > Precio de compra"
              Agregar_Respuesta("Producto",Producto)
          End sub
          <ProtoContract>
          Public Class ProductosPrecioDeCompra_FilaC
                <ProtoMember(100)>  Public Precio As Decimal
                <ProtoMember(101)>  Public Preciofinal As Decimal
                <ProtoMember(102)>  Public Pedidomaximo As Decimal
                <ProtoMember(103)>  Public Pedidominimo As Decimal
                <ProtoMember(104)>  Public Impuestosincluidos As Boolean
                <ProtoMember(105)>  Public Preciofinal2 As Decimal
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Precio = o("Precio").DEC
              Me.Preciofinal = o("Preciofinal").DEC
              Me.Pedidomaximo = o("Pedidomaximo").DEC
              Me.Pedidominimo = o("Pedidominimo").DEC
              Me.Impuestosincluidos = o("Impuestosincluidos").BOOL
              Me.Preciofinal2 = o("Preciofinal2").DEC
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of ProductosPrecioDeCompra_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New ProductosPrecioDeCompra_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
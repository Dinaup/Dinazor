Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class ProductosD
      Public Class CaducidadDeLotesC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of CaducidadDeLotes_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("466318e1-4c29-489f-908e-f30a8b8bcdd6"))
              me.ID = new GUID("466318e1-4c29-489f-908e-f30a8b8bcdd6")
              me.Titulo  = "Caducidad de lotes"
          End sub
          <ProtoContract>
          Public Class CaducidadDeLotes_FilaC
                <ProtoMember(100)>  Public Producto As String
                <ProtoMember(101)>  Public Limitedevolucion As Date?
                <ProtoMember(102)>  Public Ubicacion As String
                <ProtoMember(103)>  Public Disponible As Decimal
                <ProtoMember(104)>  Public Inventario As Decimal
                <ProtoMember(105)>  Public LimitedisponibilidadCaducidad As Date?
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Producto = o("Producto").STR
              Me.Limitedevolucion = o("Limitedevolucion").ToDateTime_UTC
              Me.Ubicacion = o("Ubicacion").STR
              Me.Disponible = o("Disponible").DEC
              Me.Inventario = o("Inventario").DEC
              Me.LimitedisponibilidadCaducidad = o("LimitedisponibilidadCaducidad").ToDateTime_UTC
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of CaducidadDeLotes_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New CaducidadDeLotes_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
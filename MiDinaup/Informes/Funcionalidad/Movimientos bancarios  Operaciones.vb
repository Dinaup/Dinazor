Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class MovimientosBancariosOperacionesC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of MovimientosBancariosOperaciones_FilaC)
          Public TokenCambios As Guid
          Sub new(MovimientoBancario As Guid)
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("5c957b19-e044-4cba-8ffa-473a0ffbee36"))
              me.ID = new GUID("5c957b19-e044-4cba-8ffa-473a0ffbee36")
              me.Titulo  = "Movimientos bancarios > Operaciones"
              Agregar_Respuesta("MovimientoBancario",MovimientoBancario)
          End sub
          <ProtoContract>
          Public Class MovimientosBancariosOperaciones_FilaC
                <ProtoMember(100)>  Public Seccion As String
                <ProtoMember(101)>  Public Importe As Decimal
                <ProtoMember(102)>  Public Entidadrelacionada As String
                <ProtoMember(103)>  Public Empleado As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Seccion = o("Seccion").STR
              Me.Importe = o("Importe").DEC
              Me.Entidadrelacionada = o("Entidadrelacionada").STR
              Me.Empleado = o("Empleado").STR
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of MovimientosBancariosOperaciones_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New MovimientosBancariosOperaciones_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
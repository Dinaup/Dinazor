Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class ImportacionD
      Public Class ImportarVariosMovimientosBancariosC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of ImportarVariosMovimientosBancarios_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("0c7dad56-89ee-44a6-801f-7aa2c692a2f3"))
              me.ID = new GUID("0c7dad56-89ee-44a6-801f-7aa2c692a2f3")
              me.Titulo  = "Importar varios Movimientos bancarios"
          End sub
          <ProtoContract>
          Public Class ImportarVariosMovimientosBancarios_FilaC
                <ProtoMember(100)>  Public Fecha As Date?
                <ProtoMember(101)>  Public Cuenta As String
                <ProtoMember(102)>  Public Concepto As String
                <ProtoMember(103)>  Public Importe As Decimal
                <ProtoMember(104)>  Public Empleado As String
                <ProtoMember(105)>  Public TextoPrincipal As String
                <ProtoMember(106)>  Public Archivo As Guid
                <ProtoMember(107)>  Public ArchivoTitulo As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Fecha = o("Fecha").ToDateTime_UTC
              Me.Cuenta = o("Cuenta").STR
              Me.Concepto = o("Concepto").STR
              Me.Importe = o("Importe").DEC
              Me.Empleado = o("Empleado").STR
              Me.TextoPrincipal = o("TextoPrincipal").STR
              Me.Archivo = o("Archivo").ToGuid
              Me.ArchivoTitulo = o("ArchivoTitulo").STR
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of ImportarVariosMovimientosBancarios_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New ImportarVariosMovimientosBancarios_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
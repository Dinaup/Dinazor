Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class ContabilizacionAjustesDeDepositosMonetariosC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of ContabilizacionAjustesDeDepositosMonetarios_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("e90a8a4b-d3cc-4cac-88cc-0b0572606e00"))
              me.ID = new GUID("e90a8a4b-d3cc-4cac-88cc-0b0572606e00")
              me.Titulo  = "Contabilización Ajustes de depósitos monetarios"
          End sub
          <ProtoContract>
          Public Class ContabilizacionAjustesDeDepositosMonetarios_FilaC
                <ProtoMember(100)>  Public TextoPrincipal As String
                <ProtoMember(101)>  Public Asiento As String
                <ProtoMember(102)>  Public Fecha As Date?
                <ProtoMember(103)>  Public Total As Decimal
                <ProtoMember(104)>  Public AsientoImporte As Decimal
                <ProtoMember(105)>  Public Ubicacion As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.TextoPrincipal = o("TextoPrincipal").STR
              Me.Asiento = o("Asiento").STR
              Me.Fecha = o("Fecha").ToDate
              Me.Total = o("Total").DEC
              Me.AsientoImporte = o("AsientoImporte").DEC
              Me.Ubicacion = o("Ubicacion").STR
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of ContabilizacionAjustesDeDepositosMonetarios_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New ContabilizacionAjustesDeDepositosMonetarios_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
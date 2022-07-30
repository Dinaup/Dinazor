Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class ImportacionDeAsientosContablesC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of ImportacionDeAsientosContables_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("2a15f353-2fb8-452a-b979-12ed92b19eb6"))
              me.ID = new GUID("2a15f353-2fb8-452a-b979-12ed92b19eb6")
              me.Titulo  = "Importación de Asientos Contables"
          End sub
          <ProtoContract>
          Public Class ImportacionDeAsientosContables_FilaC
                <ProtoMember(100)>  Public Fecha As Date?
                <ProtoMember(101)>  Public AsientoConcepto As String
                <ProtoMember(102)>  Public Subcuenta As String
                <ProtoMember(103)>  Public ApunteConcepto As String
                <ProtoMember(104)>  Public Debe As Decimal
                <ProtoMember(105)>  Public Haber As Decimal
                <ProtoMember(106)>  Public NAsiento As Integer
                <ProtoMember(107)>  Public Ejercicio As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Fecha = o("Fecha").ToDate
              Me.AsientoConcepto = o("AsientoConcepto").STR
              Me.Subcuenta = o("Subcuenta").STR
              Me.ApunteConcepto = o("ApunteConcepto").STR
              Me.Debe = o("Debe").DEC
              Me.Haber = o("Haber").DEC
              Me.NAsiento = o("NAsiento").INT
              Me.Ejercicio = o("Ejercicio").STR
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of ImportacionDeAsientosContables_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New ImportacionDeAsientosContables_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
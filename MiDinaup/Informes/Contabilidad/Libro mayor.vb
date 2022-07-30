Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class ContabilidadD
      Public Class LibroMayorC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of LibroMayor_FilaC)
          Public TokenCambios As Guid
          Sub new(Ejercicio As Guid, Cuenta As Guid)
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("e2449f8f-b819-4645-9d88-8b0eb37370de"))
              me.ID = new GUID("e2449f8f-b819-4645-9d88-8b0eb37370de")
              me.Titulo  = "Libro mayor"
              Agregar_Respuesta("Ejercicio",Ejercicio)
              Agregar_Respuesta("Cuenta",Cuenta)
          End sub
          <ProtoContract>
          Public Class LibroMayor_FilaC
                <ProtoMember(100)>  Public Fechaasiento As Date?
                <ProtoMember(101)>  Public NAsiento As String
                <ProtoMember(102)>  Public CodigoCuenta As String
                <ProtoMember(103)>  Public Cuenta As String
                <ProtoMember(104)>  Public Debe As Decimal
                <ProtoMember(105)>  Public Haber As Decimal
                <ProtoMember(106)>  Public Concepto As String
                <ProtoMember(107)>  Public Ubicacion As String
                <ProtoMember(108)>  Public Saldo As Decimal
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Fechaasiento = o("Fechaasiento").ToDate
              Me.NAsiento = o("NAsiento").STR
              Me.CodigoCuenta = o("CodigoCuenta").STR
              Me.Cuenta = o("Cuenta").STR
              Me.Debe = o("Debe").DEC
              Me.Haber = o("Haber").DEC
              Me.Concepto = o("Concepto").STR
              Me.Ubicacion = o("Ubicacion").STR
              Me.Saldo = o("Saldo").DEC
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of LibroMayor_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New LibroMayor_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
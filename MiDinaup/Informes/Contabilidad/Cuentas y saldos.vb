Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class ContabilidadD
      Public Class CuentasYSaldosC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of CuentasYSaldos_FilaC)
          Public TokenCambios As Guid
          Sub new(Ejercicio As Guid)
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("b8850fc6-37e0-4c04-9b9c-452f982ab531"))
              me.ID = new GUID("b8850fc6-37e0-4c04-9b9c-452f982ab531")
              me.Titulo  = "Cuentas y saldos"
              Agregar_Respuesta("Ejercicio",Ejercicio)
          End sub
          <ProtoContract>
          Public Class CuentasYSaldos_FilaC
                <ProtoMember(100)>  Public TextoPrincipal As String
                <ProtoMember(101)>  Public SumaDebe As Decimal
                <ProtoMember(102)>  Public SumaHaber As Decimal
                <ProtoMember(103)>  Public Codigo As String
                <ProtoMember(104)>  Public Nivel As Integer
                <ProtoMember(105)>  Public Saldoacreedor As Decimal
                <ProtoMember(106)>  Public Saldodeudor As Decimal
                <ProtoMember(107)>  Public Saldo As Decimal
                <ProtoMember(108)>  Public Niveles As Integer
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.TextoPrincipal = o("TextoPrincipal").STR
              Me.SumaDebe = o("SumaDebe").DEC
              Me.SumaHaber = o("SumaHaber").DEC
              Me.Codigo = o("Codigo").STR
              Me.Nivel = ctype(o("Nivel").INT(0), EnumNivelCuentaContableE)
              Me.Saldoacreedor = o("Saldoacreedor").DEC
              Me.Saldodeudor = o("Saldodeudor").DEC
              Me.Saldo = o("Saldo").DEC
              Me.Niveles = o("Niveles").INT
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of CuentasYSaldos_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New CuentasYSaldos_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
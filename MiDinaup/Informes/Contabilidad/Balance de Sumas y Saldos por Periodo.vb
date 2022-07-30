Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class ContabilidadD
      Public Class BalanceDeSumasYSaldosPorPeriodoC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of BalanceDeSumasYSaldosPorPeriodo_FilaC)
          Public TokenCambios As Guid
          Sub new(Ejercicio As Guid, Fecha_Desde As Date, Fecha_Hasta As Date)
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("bd3e1bf5-5778-439a-aa77-5efad969c35e"))
              me.ID = new GUID("bd3e1bf5-5778-439a-aa77-5efad969c35e")
              me.Titulo  = "Balance de Sumas y Saldos por Periodo"
              Agregar_Respuesta("Ejercicio",Ejercicio)
              Agregar_Respuesta("Fecha_Desde",Fecha_Desde)
              Agregar_Respuesta("Fecha_Hasta",Fecha_Hasta)
          End sub
          <ProtoContract>
          Public Class BalanceDeSumasYSaldosPorPeriodo_FilaC
                <ProtoMember(100)>  Public Nivel As Integer
                <ProtoMember(101)>  Public TextoPrincipal As String
                <ProtoMember(102)>  Public Codigo As String
                <ProtoMember(103)>  Public TotalDebeEnperiodo As Decimal
                <ProtoMember(104)>  Public TotalhaberEnperiodo As Decimal
                <ProtoMember(105)>  Public SaldofinalDeperiodo As Decimal
                <ProtoMember(106)>  Public SaldoAnteriorAlperiodo As Decimal
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Nivel = ctype(o("Nivel").INT(0), EnumNivelCuentaContableE)
              Me.TextoPrincipal = o("TextoPrincipal").STR
              Me.Codigo = o("Codigo").STR
              Me.TotalDebeEnperiodo = o("TotalDebeEnperiodo").DEC
              Me.TotalhaberEnperiodo = o("TotalhaberEnperiodo").DEC
              Me.SaldofinalDeperiodo = o("SaldofinalDeperiodo").DEC
              Me.SaldoAnteriorAlperiodo = o("SaldoAnteriorAlperiodo").DEC
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of BalanceDeSumasYSaldosPorPeriodo_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New BalanceDeSumasYSaldosPorPeriodo_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
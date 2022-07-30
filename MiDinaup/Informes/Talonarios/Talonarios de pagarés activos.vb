Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class TalonariosD
      Public Class TalonariosDePagaresActivosC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of TalonariosDePagaresActivos_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("096f046b-df28-4cdf-81be-c40ecc0f7d18"))
              me.ID = new GUID("096f046b-df28-4cdf-81be-c40ecc0f7d18")
              me.Titulo  = "Talonarios de pagarés activos"
          End sub
          <ProtoContract>
          Public Class TalonariosDePagaresActivos_FilaC
                <ProtoMember(100)>  Public Banco As String
                <ProtoMember(101)>  Public Activo As Boolean
                <ProtoMember(102)>  Public FechaUltimaModificacion As DateTime
                <ProtoMember(103)>  Public Cuenta As String
                <ProtoMember(104)>  Public TextoPrincipal As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Banco = o("Banco").STR
              Me.Activo = o("Activo").BOOL
              Me.FechaUltimaModificacion = o("FechaUltimaModificacion").ToDateTime_UTC
              Me.Cuenta = o("Cuenta").STR
              Me.TextoPrincipal = o("TextoPrincipal").STR
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of TalonariosDePagaresActivos_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New TalonariosDePagaresActivos_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
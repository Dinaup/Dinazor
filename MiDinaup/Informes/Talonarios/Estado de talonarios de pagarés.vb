Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class TalonariosD
      Public Class EstadoDeTalonariosDePagaresC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of EstadoDeTalonariosDePagares_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("305b6e3e-a949-4fc2-9d81-9e5929beee95"))
              me.ID = new GUID("305b6e3e-a949-4fc2-9d81-9e5929beee95")
              me.Titulo  = "Estado de talonarios de pagarés"
          End sub
          <ProtoContract>
          Public Class EstadoDeTalonariosDePagares_FilaC
                <ProtoMember(100)>  Public Activo As Boolean
                <ProtoMember(101)>  Public Cuenta As String
                <ProtoMember(102)>  Public TextoPrincipal As String
                <ProtoMember(103)>  Public Banco As String
                <ProtoMember(104)>  Public Eliminado As Boolean
                <ProtoMember(105)>  Public Fecharegistro As Date?
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Activo = o("Activo").BOOL
              Me.Cuenta = o("Cuenta").STR
              Me.TextoPrincipal = o("TextoPrincipal").STR
              Me.Banco = o("Banco").STR
              Me.Eliminado = o("Eliminado").BOOL
              Me.Fecharegistro = o("Fecharegistro").ToDate
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of EstadoDeTalonariosDePagares_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New EstadoDeTalonariosDePagares_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
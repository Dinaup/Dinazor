Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class TalonariaD
      Public Class TalonarioDeChequesActivosC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of TalonarioDeChequesActivos_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("885a15aa-2a1a-42a2-ae79-bb4da511e470"))
              me.ID = new GUID("885a15aa-2a1a-42a2-ae79-bb4da511e470")
              me.Titulo  = "Talonario de cheques activos"
          End sub
          <ProtoContract>
          Public Class TalonarioDeChequesActivos_FilaC
                <ProtoMember(100)>  Public Activo As Boolean
                <ProtoMember(101)>  Public Fecharegistro As Date?
                <ProtoMember(102)>  Public Cuenta As String
                <ProtoMember(103)>  Public Banco As String
                <ProtoMember(104)>  Public TextoPrincipal As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Activo = o("Activo").BOOL
              Me.Fecharegistro = o("Fecharegistro").ToDate
              Me.Cuenta = o("Cuenta").STR
              Me.Banco = o("Banco").STR
              Me.TextoPrincipal = o("TextoPrincipal").STR
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of TalonarioDeChequesActivos_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New TalonarioDeChequesActivos_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
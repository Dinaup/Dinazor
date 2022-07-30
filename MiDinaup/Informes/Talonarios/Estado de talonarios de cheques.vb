Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class TalonariosD
      Public Class EstadoDeTalonariosDeChequesC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of EstadoDeTalonariosDeCheques_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("6a6deab0-c31f-452c-bd5e-43eb48ddda98"))
              me.ID = new GUID("6a6deab0-c31f-452c-bd5e-43eb48ddda98")
              me.Titulo  = "Estado de talonarios de cheques"
          End sub
          <ProtoContract>
          Public Class EstadoDeTalonariosDeCheques_FilaC
                <ProtoMember(100)>  Public Banco As String
                <ProtoMember(101)>  Public Eliminado As Boolean
                <ProtoMember(102)>  Public Activo As Boolean
                <ProtoMember(103)>  Public Responsable As String
                <ProtoMember(104)>  Public Cuenta As String
                <ProtoMember(105)>  Public Fecharegistro As Date?
                <ProtoMember(106)>  Public TextoPrincipal As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Banco = o("Banco").STR
              Me.Eliminado = o("Eliminado").BOOL
              Me.Activo = o("Activo").BOOL
              Me.Responsable = o("Responsable").STR
              Me.Cuenta = o("Cuenta").STR
              Me.Fecharegistro = o("Fecharegistro").ToDate
              Me.TextoPrincipal = o("TextoPrincipal").STR
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of EstadoDeTalonariosDeCheques_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New EstadoDeTalonariosDeCheques_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
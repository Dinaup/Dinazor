Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class TesoreriaD
      Public Class EstadoDeCuentasParaLaConciliacionBancariaC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of EstadoDeCuentasParaLaConciliacionBancaria_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("930b2535-9c38-4b55-a907-9bda3e28bf9c"))
              me.ID = new GUID("930b2535-9c38-4b55-a907-9bda3e28bf9c")
              me.Titulo  = "Estado de cuentas para la conciliación bancaria"
          End sub
          <ProtoContract>
          Public Class EstadoDeCuentasParaLaConciliacionBancaria_FilaC
                <ProtoMember(100)>  Public TextoPrincipal As String
                <ProtoMember(101)>  Public TituloIcono As Guid
                <ProtoMember(102)>  Public NPendientes As Integer
                <ProtoMember(103)>  Public Banco As String
                <ProtoMember(104)>  Public Ultimoapuntebancario As Date?
                <ProtoMember(105)>  Public Importependiente As Decimal
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.TextoPrincipal = o("TextoPrincipal").STR
              Me.TituloIcono = o("TituloIcono").ToGuid
              Me.NPendientes = o("NPendientes").INT
              Me.Banco = o("Banco").STR
              Me.Ultimoapuntebancario = o("Ultimoapuntebancario").ToDate
              Me.Importependiente = o("Importependiente").DEC
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of EstadoDeCuentasParaLaConciliacionBancaria_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New EstadoDeCuentasParaLaConciliacionBancaria_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class ImportacionDeCobrosDeFEmitidasC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of ImportacionDeCobrosDeFEmitidas_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("c7716da7-6e73-4546-ae91-243cbe85723a"))
              me.ID = new GUID("c7716da7-6e73-4546-ae91-243cbe85723a")
              me.Titulo  = "Importación de Cobros de F. Emitidas"
          End sub
          <ProtoContract>
          Public Class ImportacionDeCobrosDeFEmitidas_FilaC
                <ProtoMember(100)>  Public Cliente As String
                <ProtoMember(101)>  Public Metododepago As String
                <ProtoMember(102)>  Public Importe As Decimal
                <ProtoMember(103)>  Public FEmitida As String
                <ProtoMember(104)>  Public Destinador As String
                <ProtoMember(105)>  Public Deposito As String
                <ProtoMember(106)>  Public Estado As Integer
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Cliente = o("Cliente").STR
              Me.Metododepago = o("Metododepago").STR
              Me.Importe = o("Importe").DEC
              Me.FEmitida = o("FEmitida").STR
              Me.Destinador = o("Destinador").STR
              Me.Deposito = o("Deposito").STR
              Me.Estado = ctype(o("Estado").INT(0), EnumTramitacionE)
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of ImportacionDeCobrosDeFEmitidas_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New ImportacionDeCobrosDeFEmitidas_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
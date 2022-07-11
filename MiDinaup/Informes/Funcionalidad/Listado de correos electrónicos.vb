Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class ListadoDeCorreosElectronicosC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of ListadoDeCorreosElectronicos_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("d8586be4-74b1-4750-9b5a-ea00079cbc35"))
              me.ID = new GUID("d8586be4-74b1-4750-9b5a-ea00079cbc35")
              me.Titulo  = "Listado de correos electrónicos"
          End sub
          <ProtoBuf.ProtoContract>
          Public Class ListadoDeCorreosElectronicos_FilaC
                <ProtoBuf.ProtoMember(100)>  Public Asunto As String
                <ProtoBuf.ProtoMember(101)>  Public Autor As String
                <ProtoBuf.ProtoMember(102)>  Public Fecha As Date?
                <ProtoBuf.ProtoMember(103)>  Public De As String
                <ProtoBuf.ProtoMember(104)>  Public Para As String
                <ProtoBuf.ProtoMember(105)>  Public Adjuntos As Integer
                <ProtoBuf.ProtoMember(106)>  Public Estado As String
                <ProtoBuf.ProtoMember(107)>  Public EstadoIcono As Integer
                <ProtoBuf.ProtoMember(108)>  Public Tipodeestado As Integer
                <ProtoBuf.ProtoMember(109)>  Public Buzon As String
                <ProtoBuf.ProtoMember(110)>  Public Empresa As String
                <ProtoBuf.ProtoMember(111)>  Public Tipo As Integer
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Asunto = o("Asunto").STR
              Me.Autor = o("Autor").STR
              Me.Fecha = o("Fecha").ToDateTime_UTC
              Me.De = o("De").STR
              Me.Para = o("Para").STR
              Me.Adjuntos = o("Adjuntos").INT
              Me.Estado = o("Estado").STR
              Me.EstadoIcono = ctype(o("EstadoIcono").INT(0), EnumEstadoDeTramiteE)
              Me.Tipodeestado = ctype(o("Tipodeestado").INT(0), EnumEstadoDeTramiteE)
              Me.Buzon = o("Buzon").STR
              Me.Empresa = o("Empresa").STR
              Me.Tipo = ctype(o("Tipo").INT(0), EnumCorreoEntranteSalienteE)
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of ListadoDeCorreosElectronicos_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New ListadoDeCorreosElectronicos_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
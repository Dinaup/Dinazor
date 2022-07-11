Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class BuzonesDeCorreoCorreosEnviadosC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of BuzonesDeCorreoCorreosEnviados_FilaC)
          Public TokenCambios As Guid
          Sub new(Buzon As Guid)
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("d70fec44-99d9-40bc-a0b2-d296d9aa545b"))
              me.ID = new GUID("d70fec44-99d9-40bc-a0b2-d296d9aa545b")
              me.Titulo  = "Buzones de correo > Correos Enviados"
              Agregar_Respuesta("Buzon",Buzon)
          End sub
          <ProtoBuf.ProtoContract>
          Public Class BuzonesDeCorreoCorreosEnviados_FilaC
                <ProtoBuf.ProtoMember(100)>  Public Asunto As String
                <ProtoBuf.ProtoMember(101)>  Public Correodestino As String
                <ProtoBuf.ProtoMember(102)>  Public AsuntoIcono As Integer
                <ProtoBuf.ProtoMember(103)>  Public Fecha As Date?
                <ProtoBuf.ProtoMember(104)>  Public Entidad As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Asunto = o("Asunto").STR
              Me.Correodestino = o("Correodestino").STR
              Me.AsuntoIcono = ctype(o("AsuntoIcono").INT(0), EnumCorreoEntranteSalienteE)
              Me.Fecha = o("Fecha").ToDateTime_UTC
              Me.Entidad = o("Entidad").STR
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of BuzonesDeCorreoCorreosEnviados_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New BuzonesDeCorreoCorreosEnviados_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
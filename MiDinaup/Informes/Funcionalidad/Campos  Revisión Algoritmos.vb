Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class CamposRevisionAlgoritmosC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of CamposRevisionAlgoritmos_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("03b570c5-06e6-4faa-b39e-c6eb444bf210"))
              me.ID = new GUID("03b570c5-06e6-4faa-b39e-c6eb444bf210")
              me.Titulo  = "Campos > Revisión Algoritmos"
          End sub
          <ProtoBuf.ProtoContract>
          Public Class CamposRevisionAlgoritmos_FilaC
                <ProtoBuf.ProtoMember(100)>  Public Etiqueta As String
                <ProtoBuf.ProtoMember(101)>  Public FechaAltaSistema As DateTime
                <ProtoBuf.ProtoMember(102)>  Public Algoritmo As String
                <ProtoBuf.ProtoMember(103)>  Public FechaUltimaModificacion As DateTime
                <ProtoBuf.ProtoMember(104)>  Public Formato As Decimal
                <ProtoBuf.ProtoMember(105)>  Public ID As Guid
                <ProtoBuf.ProtoMember(106)>  Public SeccionID As Guid
                <ProtoBuf.ProtoMember(107)>  Public Seccion As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Etiqueta = o("Etiqueta").STR
              Me.FechaAltaSistema = o("FechaAltaSistema").ToDateTime_UTC
              Me.Algoritmo = o("Algoritmo").STR
              Me.FechaUltimaModificacion = o("FechaUltimaModificacion").ToDateTime_UTC
              Me.Formato = o("Formato").DEC
              Me.ID = o("ID").ToGuid
              Me.SeccionID = o("SeccionID").ToGuid
              Me.Seccion = o("Seccion").STR
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of CamposRevisionAlgoritmos_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New CamposRevisionAlgoritmos_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
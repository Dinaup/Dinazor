Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class CamposRevisionDeIndicesC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of CamposRevisionDeIndices_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("66c1378a-ad58-4c3b-ac40-8e627cbbbdd2"))
              me.ID = new GUID("66c1378a-ad58-4c3b-ac40-8e627cbbbdd2")
              me.Titulo  = "Campos > Revisión de Indices"
          End sub
          <ProtoBuf.ProtoContract>
          Public Class CamposRevisionDeIndices_FilaC
                <ProtoBuf.ProtoMember(100)>  Public FechaAltaSistema As DateTime
                <ProtoBuf.ProtoMember(101)>  Public Indexado As Boolean
                <ProtoBuf.ProtoMember(102)>  Public FechaUltimaModificacion As DateTime
                <ProtoBuf.ProtoMember(103)>  Public Seccion As String
                <ProtoBuf.ProtoMember(104)>  Public Formato As Decimal
                <ProtoBuf.ProtoMember(105)>  Public CampoPR As String
                <ProtoBuf.ProtoMember(106)>  Public SeccionBase As String
                <ProtoBuf.ProtoMember(107)>  Public Etiqueta As String
                <ProtoBuf.ProtoMember(108)>  Public ID As Guid
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.FechaAltaSistema = o("FechaAltaSistema").ToDateTime_UTC
              Me.Indexado = o("Indexado").BOOL
              Me.FechaUltimaModificacion = o("FechaUltimaModificacion").ToDateTime_UTC
              Me.Seccion = o("Seccion").STR
              Me.Formato = o("Formato").DEC
              Me.CampoPR = o("CampoPR").STR
              Me.SeccionBase = o("SeccionBase").STR
              Me.Etiqueta = o("Etiqueta").STR
              Me.ID = o("ID").ToGuid
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of CamposRevisionDeIndices_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New CamposRevisionDeIndices_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
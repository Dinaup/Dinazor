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
          <ProtoContract>
          Public Class CamposRevisionDeIndices_FilaC
                <ProtoMember(100)>  Public FechaAltaSistema As DateTime
                <ProtoMember(101)>  Public Indexado As Boolean
                <ProtoMember(102)>  Public FechaUltimaModificacion As DateTime
                <ProtoMember(103)>  Public Seccion As String
                <ProtoMember(104)>  Public Formato As Decimal
                <ProtoMember(105)>  Public CampoPR As String
                <ProtoMember(106)>  Public SeccionBase As String
                <ProtoMember(107)>  Public Etiqueta As String
                <ProtoMember(108)>  Public ID As Guid
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
Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class ScriptsDeSeccionesC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of ScriptsDeSecciones_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("50f00cd4-cb75-47ff-af10-4105a68f5e92"))
              me.ID = new GUID("50f00cd4-cb75-47ff-af10-4105a68f5e92")
              me.Titulo  = "Scripts > De Secciones"
          End sub
          <ProtoBuf.ProtoContract>
          Public Class ScriptsDeSecciones_FilaC
                <ProtoBuf.ProtoMember(100)>  Public SeccionID As Guid
                <ProtoBuf.ProtoMember(101)>  Public Eliminado As Decimal
                <ProtoBuf.ProtoMember(102)>  Public ID As Guid
                <ProtoBuf.ProtoMember(103)>  Public TextoPrincipal As String
                <ProtoBuf.ProtoMember(104)>  Public FechaUltimaModificacion As DateTime
                <ProtoBuf.ProtoMember(105)>  Public Script As String
                <ProtoBuf.ProtoMember(106)>  Public FechaAltaSistema As DateTime
                <ProtoBuf.ProtoMember(107)>  Public Seccion As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.SeccionID = o("SeccionID").ToGuid
              Me.Eliminado = o("Eliminado").DEC
              Me.ID = o("ID").ToGuid
              Me.TextoPrincipal = o("TextoPrincipal").STR
              Me.FechaUltimaModificacion = o("FechaUltimaModificacion").ToDateTime_UTC
              Me.Script = o("Script").STR
              Me.FechaAltaSistema = o("FechaAltaSistema").ToDateTime_UTC
              Me.Seccion = o("Seccion").STR
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of ScriptsDeSecciones_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New ScriptsDeSecciones_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
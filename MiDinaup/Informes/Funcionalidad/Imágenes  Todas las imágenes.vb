Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class ImagenesTodasLasImagenesC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of ImagenesTodasLasImagenes_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("955fc3dc-aa37-49bd-a358-1568a66c38d2"))
              me.ID = new GUID("955fc3dc-aa37-49bd-a358-1568a66c38d2")
              me.Titulo  = "Imágenes > Todas las imágenes"
          End sub
          <ProtoBuf.ProtoContract>
          Public Class ImagenesTodasLasImagenes_FilaC
                <ProtoBuf.ProtoMember(100)>  Public ComentariosArchivo As Decimal
                <ProtoBuf.ProtoMember(101)>  Public Demodulo As Boolean
                <ProtoBuf.ProtoMember(102)>  Public Alto As Decimal
                <ProtoBuf.ProtoMember(103)>  Public Version As Decimal
                <ProtoBuf.ProtoMember(104)>  Public ID As Guid
                <ProtoBuf.ProtoMember(105)>  Public Tamano As Decimal
                <ProtoBuf.ProtoMember(106)>  Public TextoPrincipal As String
                <ProtoBuf.ProtoMember(107)>  Public Ancho As Decimal
                <ProtoBuf.ProtoMember(108)>  Public Empleado As String
                <ProtoBuf.ProtoMember(109)>  Public FechaUltimaModificacion As DateTime
                <ProtoBuf.ProtoMember(110)>  Public FechaAltaSistema As DateTime
                <ProtoBuf.ProtoMember(111)>  Public Extension As String
                <ProtoBuf.ProtoMember(112)>  Public ComentariosVersion As Decimal
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.ComentariosArchivo = o("ComentariosArchivo").DEC
              Me.Demodulo = o("Demodulo").BOOL
              Me.Alto = o("Alto").DEC
              Me.Version = o("Version").DEC
              Me.ID = o("ID").ToGuid
              Me.Tamano = o("Tamano").DEC
              Me.TextoPrincipal = o("TextoPrincipal").STR
              Me.Ancho = o("Ancho").DEC
              Me.Empleado = o("Empleado").STR
              Me.FechaUltimaModificacion = o("FechaUltimaModificacion").ToDateTime_UTC
              Me.FechaAltaSistema = o("FechaAltaSistema").ToDateTime_UTC
              Me.Extension = o("Extension").STR
              Me.ComentariosVersion = o("ComentariosVersion").DEC
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of ImagenesTodasLasImagenes_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New ImagenesTodasLasImagenes_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
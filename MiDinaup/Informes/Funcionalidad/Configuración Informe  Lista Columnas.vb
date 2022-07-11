Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class ConfiguracionInformeListaColumnasC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of ConfiguracionInformeListaColumnas_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("447d7dbb-efa6-4f76-af52-910a1ade836e"))
              me.ID = new GUID("447d7dbb-efa6-4f76-af52-910a1ade836e")
              me.Titulo  = "Configuración Informe > Lista Columnas"
          End sub
          <ProtoBuf.ProtoContract>
          Public Class ConfiguracionInformeListaColumnas_FilaC
                <ProtoBuf.ProtoMember(100)>  Public PosicionOrden As Decimal
                <ProtoBuf.ProtoMember(101)>  Public ID As Guid
                <ProtoBuf.ProtoMember(102)>  Public IconoID As Guid
                <ProtoBuf.ProtoMember(103)>  Public FechaUltimaModificacion As DateTime
                <ProtoBuf.ProtoMember(104)>  Public FechaAltaSistema As DateTime
                <ProtoBuf.ProtoMember(105)>  Public Titulo As String
                <ProtoBuf.ProtoMember(106)>  Public Eliminado As Boolean
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.PosicionOrden = o("PosicionOrden").DEC
              Me.ID = o("ID").ToGuid
              Me.IconoID = o("IconoID").ToGuid
              Me.FechaUltimaModificacion = o("FechaUltimaModificacion").ToDateTime_UTC
              Me.FechaAltaSistema = o("FechaAltaSistema").ToDateTime_UTC
              Me.Titulo = o("Titulo").STR
              Me.Eliminado = o("Eliminado").BOOL
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of ConfiguracionInformeListaColumnas_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New ConfiguracionInformeListaColumnas_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
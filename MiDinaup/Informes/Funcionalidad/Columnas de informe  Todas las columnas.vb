Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class ColumnasDeInformeTodasLasColumnasC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of ColumnasDeInformeTodasLasColumnas_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("9eb722e7-11b4-4aa0-9195-b8422ec581f1"))
              me.ID = new GUID("9eb722e7-11b4-4aa0-9195-b8422ec581f1")
              me.Titulo  = "Columnas de informe > Todas las columnas"
          End sub
          <ProtoBuf.ProtoContract>
          Public Class ColumnasDeInformeTodasLasColumnas_FilaC
                <ProtoBuf.ProtoMember(100)>  Public Titulo As String
                <ProtoBuf.ProtoMember(101)>  Public FechaUltimaModificacion As DateTime
                <ProtoBuf.ProtoMember(102)>  Public ID As Guid
                <ProtoBuf.ProtoMember(103)>  Public Seccion As String
                <ProtoBuf.ProtoMember(104)>  Public Eliminado As Boolean
                <ProtoBuf.ProtoMember(105)>  Public Informe As String
                <ProtoBuf.ProtoMember(106)>  Public FechaAltaSistema As DateTime
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Titulo = o("Titulo").STR
              Me.FechaUltimaModificacion = o("FechaUltimaModificacion").ToDateTime_UTC
              Me.ID = o("ID").ToGuid
              Me.Seccion = o("Seccion").STR
              Me.Eliminado = o("Eliminado").BOOL
              Me.Informe = o("Informe").STR
              Me.FechaAltaSistema = o("FechaAltaSistema").ToDateTime_UTC
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of ColumnasDeInformeTodasLasColumnas_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New ColumnasDeInformeTodasLasColumnas_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
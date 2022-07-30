Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class InformesRevisarAlgoritmosDeFiltradoC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of InformesRevisarAlgoritmosDeFiltrado_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("da22e1f1-2143-49a5-a089-7af47da79016"))
              me.ID = new GUID("da22e1f1-2143-49a5-a089-7af47da79016")
              me.Titulo  = "Informes > Revisar algoritmos de filtrado"
          End sub
          <ProtoContract>
          Public Class InformesRevisarAlgoritmosDeFiltrado_FilaC
                <ProtoMember(100)>  Public Campodesplegable As String
                <ProtoMember(101)>  Public FechaAltaSistema As DateTime
                <ProtoMember(102)>  Public Filtrado As String
                <ProtoMember(103)>  Public FechaUltimaModificacion As DateTime
                <ProtoMember(104)>  Public ID As Guid
                <ProtoMember(105)>  Public SeccionDesplegable As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Campodesplegable = o("Campodesplegable").STR
              Me.FechaAltaSistema = o("FechaAltaSistema").ToDateTime_UTC
              Me.Filtrado = o("Filtrado").STR
              Me.FechaUltimaModificacion = o("FechaUltimaModificacion").ToDateTime_UTC
              Me.ID = o("ID").ToGuid
              Me.SeccionDesplegable = o("SeccionDesplegable").STR
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of InformesRevisarAlgoritmosDeFiltrado_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New InformesRevisarAlgoritmosDeFiltrado_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
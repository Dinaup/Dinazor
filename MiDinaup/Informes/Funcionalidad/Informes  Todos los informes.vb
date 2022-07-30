Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class InformesTodosLosInformesC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of InformesTodosLosInformes_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("eeb28c83-c158-4226-8496-1bb53b7aa671"))
              me.ID = new GUID("eeb28c83-c158-4226-8496-1bb53b7aa671")
              me.Titulo  = "Informes > Todos los informes"
          End sub
          <ProtoContract>
          Public Class InformesTodosLosInformes_FilaC
                <ProtoMember(100)>  Public Ambito As Boolean
                <ProtoMember(101)>  Public Categoria As String
                <ProtoMember(102)>  Public FechaSincronizacion As DateTime
                <ProtoMember(103)>  Public Subcategoria As String
                <ProtoMember(104)>  Public FechaIA As DateTime
                <ProtoMember(105)>  Public TextoPrincipal As String
                <ProtoMember(106)>  Public FechaUltimaModificacion As DateTime
                <ProtoMember(107)>  Public Eliminado As Boolean
                <ProtoMember(108)>  Public FechaAltaSistema As DateTime
                <ProtoMember(109)>  Public ID As Guid
                <ProtoMember(110)>  Public Seccion As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Ambito = o("Ambito").BOOL
              Me.Categoria = o("Categoria").STR
              Me.FechaSincronizacion = o("FechaSincronizacion").ToDateTime_UTC
              Me.Subcategoria = o("Subcategoria").STR
              Me.FechaIA = o("FechaIA").ToDateTime_UTC
              Me.TextoPrincipal = o("TextoPrincipal").STR
              Me.FechaUltimaModificacion = o("FechaUltimaModificacion").ToDateTime_UTC
              Me.Eliminado = o("Eliminado").BOOL
              Me.FechaAltaSistema = o("FechaAltaSistema").ToDateTime_UTC
              Me.ID = o("ID").ToGuid
              Me.Seccion = o("Seccion").STR
              End Sub
              Sub new()
              End Sub
          End Class
              Partial Public Class InformesTodosLosInformes_FilaC
                  Implements IDatoCacheable
                  Private ReadOnly Property IDatoCacheable_ID As Guid Implements IDatoCacheable.ID
                      Get
                          Return ID
                      End Get
                  End Property
                  Private ReadOnly Property IDatoCacheable_FechaIA As Date Implements IDatoCacheable.FechaIA
                      Get
                          Return FechaIA
                      End Get
                  End Property
              End Class
          Public MaxFechaIA As Date 
          Public FilasPorID As New Dic(Of Guid, InformesTodosLosInformes_FilaC)
          Public Overrides Sub CargarRespuesta()
                Dim Creando_MaxFechaIA As Date 
                Dim Creando_FilasPorID As New Dic(Of Guid, InformesTodosLosInformes_FilaC) 
                Dim Creando_Filas As New List(Of InformesTodosLosInformes_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New InformesTodosLosInformes_FilaC(Actual)
                    Creando_MaxFechaIA = Max(Creando_MaxFechaIA, N.FechaIA) 
                    Creando_FilasPorID.AddSiNoExiste(N.ID, N)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                Me.MaxFechaIA = Creando_MaxFechaIA
                Me.FilasPorID = Creando_FilasPorID
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
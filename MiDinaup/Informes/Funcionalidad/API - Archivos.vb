Imports DinaNETCore
Partial Public Class InformesD
    Partial Public Class FuncionalidadD
        Public Class APIArchivosC
            Inherits DinaNETCore.APID.APID_InformeC
            Public Filas As New List(Of APIArchivos_FilaC)
            Public TokenCambios As Guid
            Sub New()
                Parametros = New APID.Funcion_Informe_Consultar_ParametrosC(("23039356-c15f-499c-98f1-c91dbd467ab7"))
                Me.ID = New Guid("23039356-c15f-499c-98f1-c91dbd467ab7")
                Me.Titulo = "API - Archivos"
            End Sub
            <ProtoContract>
            Public Class APIArchivos_FilaC
                <ProtoMember(100)> Public ID As Guid
                <ProtoMember(101)> Public TextoPrincipal As String
                <ProtoMember(102)> Public Filename As String
                <ProtoMember(103)> Public Tamano As Decimal
                <ProtoMember(104)> Public FechaIA As DateTime
                Sub New(O As Newtonsoft.Json.Linq.JToken)
                    Me.ID = O("ID").ToGUID
                    Me.TextoPrincipal = O("TextoPrincipal").STR
                    Me.Filename = O("Filename").STR
                    Me.Tamano = O("Tamano").DEC
                    Me.FechaIA = O("FechaIA").ToDateTime_UTC
                End Sub
                Sub New()
                End Sub
            End Class
            Partial Public Class APIArchivos_FilaC
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
            Public FilasPorID As New Dic(Of Guid, APIArchivos_FilaC)
            Public Overrides Sub CargarRespuesta()
                Dim Creando_MaxFechaIA As Date
                Dim Creando_FilasPorID As New Dic(Of Guid, APIArchivos_FilaC)
                Dim Creando_Filas As New List(Of APIArchivos_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New APIArchivos_FilaC(Actual)
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
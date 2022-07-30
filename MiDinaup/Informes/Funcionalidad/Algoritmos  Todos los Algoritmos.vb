Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class AlgoritmosTodosLosAlgoritmosC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of AlgoritmosTodosLosAlgoritmos_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("6289a491-c9fd-4682-8e97-91409988c5e7"))
              me.ID = new GUID("6289a491-c9fd-4682-8e97-91409988c5e7")
              me.Titulo  = "Algoritmos > Todos los Algoritmos"
          End sub
          <ProtoContract>
          Public Class AlgoritmosTodosLosAlgoritmos_FilaC
                <ProtoMember(100)>  Public Eliminado As Decimal
                <ProtoMember(101)>  Public FechaAltaSistema As DateTime
                <ProtoMember(102)>  Public Seccion As String
                <ProtoMember(103)>  Public Tipodedato As Decimal
                <ProtoMember(104)>  Public DatosSecundariosRelacionID As Guid
                <ProtoMember(105)>  Public SeccionRelacion As String
                <ProtoMember(106)>  Public TextoPrincipal As String
                <ProtoMember(107)>  Public Publico As Boolean
                <ProtoMember(108)>  Public FechaUltimaModificacion As DateTime
                <ProtoMember(109)>  Public SeccionID As Guid
                <ProtoMember(110)>  Public Categoria As String
                <ProtoMember(111)>  Public Tipodealgoritmo As Decimal
                <ProtoMember(112)>  Public Subcategoria As String
                <ProtoMember(113)>  Public NombreIcono As Guid
                <ProtoMember(114)>  Public Obsoleto As Boolean
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Eliminado = o("Eliminado").DEC
              Me.FechaAltaSistema = o("FechaAltaSistema").ToDateTime_UTC
              Me.Seccion = o("Seccion").STR
              Me.Tipodedato = o("Tipodedato").DEC
              Me.DatosSecundariosRelacionID = o("DatosSecundariosRelacionID").ToGuid
              Me.SeccionRelacion = o("SeccionRelacion").STR
              Me.TextoPrincipal = o("TextoPrincipal").STR
              Me.Publico = o("Publico").BOOL
              Me.FechaUltimaModificacion = o("FechaUltimaModificacion").ToDateTime_UTC
              Me.SeccionID = o("SeccionID").ToGuid
              Me.Categoria = o("Categoria").STR
              Me.Tipodealgoritmo = o("Tipodealgoritmo").DEC
              Me.Subcategoria = o("Subcategoria").STR
              Me.NombreIcono = o("NombreIcono").ToGuid
              Me.Obsoleto = o("Obsoleto").BOOL
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of AlgoritmosTodosLosAlgoritmos_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New AlgoritmosTodosLosAlgoritmos_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
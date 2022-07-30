Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class ProductosMasVendidosC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of ProductosMasVendidos_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("e75d4991-998c-4d9e-8dbd-a7c6cedc815d"))
              me.ID = new GUID("e75d4991-998c-4d9e-8dbd-a7c6cedc815d")
              me.Titulo  = "Productos más vendidos"
          End sub
          <ProtoContract>
          Public Class ProductosMasVendidos_FilaC
                <ProtoMember(100)>  Public Nombreproducto As String
                <ProtoMember(101)>  Public Totalproductos As Guid
                <ProtoMember(102)>  Public Imagen As Guid
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Nombreproducto = o("Nombreproducto").STR
              Me.Totalproductos = o("Totalproductos").ToGuid
              Me.Imagen = o("Imagen").ToGuid
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of ProductosMasVendidos_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New ProductosMasVendidos_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
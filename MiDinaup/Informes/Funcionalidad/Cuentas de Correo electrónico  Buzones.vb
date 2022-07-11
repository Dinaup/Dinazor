Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class CuentasDeCorreoElectronicoBuzonesC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of CuentasDeCorreoElectronicoBuzones_FilaC)
          Public TokenCambios As Guid
          Sub new(Correo As Guid)
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("0be2d77d-c285-41c4-bf65-5ff26e693fac"))
              me.ID = new GUID("0be2d77d-c285-41c4-bf65-5ff26e693fac")
              me.Titulo  = "Cuentas de Correo electrónico > Buzones"
              Agregar_Respuesta("Correo",Correo)
          End sub
          <ProtoBuf.ProtoContract>
          Public Class CuentasDeCorreoElectronicoBuzones_FilaC
                <ProtoBuf.ProtoMember(100)>  Public TextoPrincipal As String
                <ProtoBuf.ProtoMember(101)>  Public Etiqueta As String
                <ProtoBuf.ProtoMember(102)>  Public Correo As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.TextoPrincipal = o("TextoPrincipal").STR
              Me.Etiqueta = o("Etiqueta").STR
              Me.Correo = o("Correo").STR
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of CuentasDeCorreoElectronicoBuzones_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New CuentasDeCorreoElectronicoBuzones_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
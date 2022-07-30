Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class ContabilidadD
      Public Class ListaDeCuentasOficialesImportadasC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of ListaDeCuentasOficialesImportadas_FilaC)
          Public TokenCambios As Guid
          Sub new(Empres As Guid)
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("9de1f5e8-8188-4399-b95e-19b34e1be161"))
              me.ID = new GUID("9de1f5e8-8188-4399-b95e-19b34e1be161")
              me.Titulo  = "Lista de Cuentas Oficiales importadas"
              Agregar_Respuesta("Empres",Empres)
          End sub
          <ProtoContract>
          Public Class ListaDeCuentasOficialesImportadas_FilaC
                <ProtoMember(100)>  Public Codigo As String
                <ProtoMember(101)>  Public Titulo As String
                <ProtoMember(102)>  Public Nivel As Integer
                <ProtoMember(103)>  Public Asientos As Boolean
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Codigo = o("Codigo").STR
              Me.Titulo = o("Titulo").STR
              Me.Nivel = ctype(o("Nivel").INT(0), EnumNivelCuentaContableE)
              Me.Asientos = o("Asientos").BOOL
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of ListaDeCuentasOficialesImportadas_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New ListaDeCuentasOficialesImportadas_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
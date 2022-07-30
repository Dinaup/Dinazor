Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class ContabilizacionDeAmortizacionesDeInmovilizadosC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of ContabilizacionDeAmortizacionesDeInmovilizados_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("56286851-f305-4837-b5e9-11e15e060642"))
              me.ID = new GUID("56286851-f305-4837-b5e9-11e15e060642")
              me.Titulo  = "Contabilización de amortizaciones de inmovilizados"
          End sub
          <ProtoContract>
          Public Class ContabilizacionDeAmortizacionesDeInmovilizados_FilaC
                <ProtoMember(100)>  Public Asiento As String
                <ProtoMember(101)>  Public TextoPrincipal As String
                <ProtoMember(102)>  Public ImporteAmortizacion As Decimal
                <ProtoMember(103)>  Public Fechadecontabilizacion As Date?
                <ProtoMember(104)>  Public Inmovilizado2 As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Asiento = o("Asiento").STR
              Me.TextoPrincipal = o("TextoPrincipal").STR
              Me.ImporteAmortizacion = o("ImporteAmortizacion").DEC
              Me.Fechadecontabilizacion = o("Fechadecontabilizacion").ToDate
              Me.Inmovilizado2 = o("Inmovilizado2").STR
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of ContabilizacionDeAmortizacionesDeInmovilizados_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New ContabilizacionDeAmortizacionesDeInmovilizados_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class
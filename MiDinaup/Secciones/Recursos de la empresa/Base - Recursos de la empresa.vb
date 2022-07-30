   Imports System.ComponentModel
   Imports DinaNETCore
   Imports DinaNETCore.APID
Partial Public Class SeccionesD
  Public Class RecursosDeLaEmpresaBaseD
      Public Class RecursosDeLaEmpresaBase_ConListaC
      Public Listador as RecursosDeLaEmpresaBaseC
      Public Lista As New List(of RecursosDeLaEmpresaBaseListaD.RecursosDeLaEmpresaBaseListaC)
        sub new(_listador  as RecursosDeLaEmpresaBaseC, _lista as List(of RecursosDeLaEmpresaBaseListaD.RecursosDeLaEmpresaBaseListaC))
           me.Listador =_listador 
           me.Lista =_lista 
        End sub
      End Class
      Public Shared _SeccionID As String = "3b921d2c-89b7-4cfd-8999-6e44ddabeb72"
      Public Shared _SeccionIDGUID As New Guid("3b921d2c-89b7-4cfd-8999-6e44ddabeb72")
      Public Shared Async Function ConsultarDatos_Async(Parametros As SeccionConsultaParametrosC) As Task(Of List(Of RecursosDeLaEmpresaBaseC )) 
          Dim R As New List(Of RecursosDeLaEmpresaBaseC )  
          Dim d = Await Parametros.DinaupSesion.ConexionServidor.Funcion_Datos_Recibir_Async(RecursosDeLaEmpresaBaseES._SeccionID, False, Parametros) 
          If d.Datos.TieneDatos Then 
              For Each Actual In d.Datos 
                  Dim Valores_Listador = Actual.Value.Item1
                  Dim Obj_Listador As New RecursosDeLaEmpresaBaseC 
                  Obj_Listador.CargarDatos(Valores_Listador) 
                  Obj_Listador.CargaInterna(Actual.Value)
                  R.Add(Obj_Listador) 
              Next 
          End If 
          Return R 
      End Function 
      Public Shared Async Function ConsultarDatos_ConLista_Async(  Parametros As SeccionConsultaParametrosC ) As Task(Of List(Of  RecursosDeLaEmpresaBase_ConListaC)) 
          Dim R As New List(Of RecursosDeLaEmpresaBase_ConListaC )  
          Dim d =  Await Parametros.DinaupSesion.ConexionServidor.Funcion_Datos_Recibir_Async(RecursosDeLaEmpresaBaseES._SeccionID, True, Parametros) 
          If d.Datos.TieneDatos Then 
              For Each Actual In d.Datos 
                  Dim Valores_Listador = Actual.Value.Item1
                  Dim Valores_Lista = Actual.Value.Item2
                  Dim Obj_Listador As New RecursosDeLaEmpresaBaseC 
                  Obj_Listador.CargarDatos(Valores_Listador) 
                  Obj_Listador.CargaInterna(Actual.Value)
                  Dim Objs_Listas As New List(Of RecursosDeLaEmpresaBaseListaD.RecursosDeLaEmpresaBaseListaC) 
                  If Valores_Lista.TieneDatos Then  
                      For Each ValoresLista In Valores_Lista 
                         Dim nItem As New RecursosDeLaEmpresaBaseListaD.RecursosDeLaEmpresaBaseListaC 
                         nItem.CargarDatos(ValoresLista)   
                         Objs_Listas.Add(nItem)         
                      Next   
                  End If   
                  R.Add(New RecursosDeLaEmpresaBase_ConListaC(Obj_Listador, Objs_Listas))
              Next 
          End If 
          Return R 
      End Function 
      Public Class RecursosDeLaEmpresaBaseES
          Public shared _SeccionID as Guid = New Guid("3b921d2c-89b7-4cfd-8999-6e44ddabeb72")
          Public shared _Tabla$ = "tpr_60010421301"
      Public Shared ReferenciaMarca$ = "pr_60010421345"
      Public Shared ReferenciaModelo$ = "pr_60010421346"
      Public Shared ReferenciaLocalizacionActual$ = "pr_30040441061"
      Public Shared ImporteFacturacionPotencial$ = "pr_10010421341"
      Public Shared ImporteBeneficioPotencial$ = "pr_10010421342"
      Public Shared ImporteNoFacturable$ = "pr_10010421345"
      Public Shared Matricula$ = "pr_20010421353"
      Public Shared ReferenciaFoto$ = "pr_500104215614"
      Public Shared ReferenciaPrecioDeVentaImpuestosObsoleto$ = "pr_500104215615"
      Public Shared ImporteCosteConImpuestosObsoleto$ = "pr_500104215616"
      Public Shared CantidadPorVehiculoObsoleto$ = "pr_30010421571"
      Public Shared ImportePrecioDeVentaSinImpuestos$ = "pr_30010421572"
      Public Shared ImportePrecioDeVentaConImpuestos$ = "pr_30010421574"
      Public Shared ReferenciaRecambioEquivalenciaObsoleto$ = "pr_30010421576"
      Public Shared Kilometraje$ = "pr_60040473183"
      Public Shared Año$ = "pr_60040473184"
      Public Shared Bastidor$ = "pr_60040473182"
      Public Shared ReferenciaColor$ = "pr_30040473192"
      Public Shared RefsMotor$ = "pr_40040473191"
      Public Shared ExportarEnModulos$ = "pr_600104213010"
      Public Shared FechaAlta_UTC$ = "pr_600104213011"
      Public Shared HoraLocal$ = "pr_60010421309"
      Public Shared ReferenciaAutorDelAlta$ = "pr_60010421307"
      Public Shared ReferenciaDestinador$ = "pr_600104213012"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_600104213022"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_600104213023"
      Public Shared ReferenciaCompra$ = "pr_60010421333"
      Public Shared ReferenciaDetalles$ = "pr_60010421331"
      Public Shared ImporteCosteSinImpuestos$ = "pr_60010421335"
      Public Shared ReferenciaTipo$ = "pr_20010421771"
      Public Shared ReferenciaImpuestos$ = "pr_60040440031"
      Public Shared ImporteCosteConImpuestos$ = "pr_50040440033"
      Public Shared ReferenciaEstado$ = "pr_10040440041"
      Public Shared ReferenciaVenta$ = "pr_50040440042"
      Public Shared ReferenciaElementoDeCompra$ = "pr_10040440527"
      Public Shared ReferenciaElementoDeVenta$ = "pr_10040440528"
      Public Shared ReferenciaRecursoDeOrigen$ = "pr_10040440531"
      Public Shared ReferenciaLocalizacionInicial$ = "pr_40040441071"
      Public Shared ReferenciaLocalizacionDeUltimoTransporte$ = "pr_10040441162"
      Public Shared PartesExtraidasDivision$ = "pr_40040441671"
      Public Shared IDExterna$ = "pr_50040475821"
      Public Shared FechaModificacionExterna_UTC$ = "pr_50040475822"
      Public Shared ID$ = "id"
      Public Shared TextoPrincipal$ = "nombre"
      Public Shared FechaAltaDato_UTC$ = "fecha"
      Public Shared FechaUltimaModificacion_UTC$ = "fecham"
      Public Shared Eliminado$ = "eliminado"
      Public Shared UsuarioCreadorDelDAto$ = "usuarioid"
      Public Shared Seccion$ = "plantillapid"
      Public Shared Posicion$ = "posicion"
      Public Shared Empresa$ = "ubicacion"
      Public Shared Modificado$ = "modificado"
      Public Shared FechaIndiceActividad_UTC$ = "fechaia"
      Public Shared Fechadesincronizacion_UTC$ = "fechasyn"
      End Class
      Public Class RecursosDeLaEmpresaBaseC
      Inherits Base_DatoC
          <DisplayName("Marca")>
          Public Property ReferenciaMarca As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaMarca As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaMarca"",""etiqueta"": ""Marca"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""fa425ef0-9001-4a0b-8795-93e4dba8719f"",""titulo"": ""Base - Marcas comerciales"",""iconoid"": ""46bff251-7bbe-4c8d-adb2-7605e6393ab2"",""etiquetasingular"": ""Marca comercial"",""etiquetaplural"": ""Marcas comerciales"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""fa425ef0-9001-4a0b-8795-93e4dba8719f"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Marca"",""descripcion"": """",""keyword"": ""ReferenciaMarca"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaMarca As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaMarca
          <DisplayName("Modelo")>
          Public Property ReferenciaModelo As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaModelo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaModelo"",""etiqueta"": ""Modelo"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""327b63e9-1c53-4562-88d7-687499b785b9"",""titulo"": ""Base - Modelos de vehículos"",""iconoid"": ""0d7ac9ca-39ec-4ae9-a8ea-ea7d3d45405e"",""etiquetasingular"": ""Modelo de vehículo"",""etiquetaplural"": ""Modelos de vehículos"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""327b63e9-1c53-4562-88d7-687499b785b9"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Modelo"",""descripcion"": """",""keyword"": ""ReferenciaModelo"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaModelo As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaModelo
          <DisplayName("Localización actual")>
          Public Property ReferenciaLocalizacionActual As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaLocalizacionActual As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaLocalizacionActual"",""etiqueta"": ""Localización actual"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""a5d262f3-e3ea-4a8c-926a-465798454b94"",""titulo"": ""Base - Ubicaciones en mapa"",""iconoid"": ""08f5af90-aca8-4d1d-8b4a-601044b4ff9a"",""etiquetasingular"": ""Ubicación en mapa"",""etiquetaplural"": ""Ubicaciones en mapa"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""a5d262f3-e3ea-4a8c-926a-465798454b94"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Localización actual"",""descripcion"": """",""keyword"": ""ReferenciaLocalizacionActual"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaLocalizacionActual As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaLocalizacionActual
          <DisplayName("Facturación Potencial")>
          Public Property ImporteFacturacionPotencial As Decimal
          Public Shared ___ImporteFacturacionPotencial As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteFacturacionPotencial"",""etiqueta"": ""Facturación Potencial"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Facturación Potencial"",""descripcion"": """",""keyword"": ""ImporteFacturacionPotencial"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteFacturacionPotencial As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteFacturacionPotencial
          <DisplayName("Beneficio potencial")>
          Public Property ImporteBeneficioPotencial As Decimal
          Public Shared ___ImporteBeneficioPotencial As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteBeneficioPotencial"",""etiqueta"": ""Beneficio potencial"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Beneficio potencial"",""descripcion"": """",""keyword"": ""ImporteBeneficioPotencial"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteBeneficioPotencial As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteBeneficioPotencial
          <DisplayName("No facturable")>
          Public Property ImporteNoFacturable As Decimal
          Public Shared ___ImporteNoFacturable As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteNoFacturable"",""etiqueta"": ""No facturable"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""No facturable"",""descripcion"": """",""keyword"": ""ImporteNoFacturable"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteNoFacturable As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteNoFacturable
          <DisplayName("Matrícula")>
          Public Property Matricula As String
          Public Shared ___Matricula As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Matricula"",""etiqueta"": ""Matrícula"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Matrícula"",""descripcion"": """",""keyword"": ""Matricula"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Matricula As DinaNETCore.APID.DinaupAPI_CampoC = ___Matricula
          <DisplayName("Foto")>
          Public Property ReferenciaFoto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaFoto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaFoto"",""etiqueta"": ""Foto"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""imagenes"",""rol"": 17,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Foto"",""descripcion"": """",""keyword"": ""ReferenciaFoto"",""formato"": 9,""rol"": 17,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaFoto As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaFoto
          <DisplayName("Precio de venta (Impuestos) (Obsoleto)")>
          Public Property ReferenciaPrecioDeVentaImpuestosObsoleto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaPrecioDeVentaImpuestosObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaPrecioDeVentaImpuestosObsoleto"",""etiqueta"": ""Precio de venta (Impuestos) (Obsoleto)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""f3199ee0-dc83-4667-a9c1-f3b04e97a8a4"",""titulo"": ""Base - Impuestos"",""iconoid"": ""ff4a7189-6426-43b9-bdc4-070314999e81"",""etiquetasingular"": ""Impuesto"",""etiquetaplural"": ""Impuestos"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""f3199ee0-dc83-4667-a9c1-f3b04e97a8a4"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Precio de venta (Impuestos) (Obsoleto)"",""descripcion"": """",""keyword"": ""ReferenciaPrecioDeVentaImpuestosObsoleto"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaPrecioDeVentaImpuestosObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaPrecioDeVentaImpuestosObsoleto
          <DisplayName("Coste (Con impuestos) (Obsoleto)")>
          Public Property ImporteCosteConImpuestosObsoleto As Decimal
          Public Shared ___ImporteCosteConImpuestosObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteCosteConImpuestosObsoleto"",""etiqueta"": ""Coste (Con impuestos) (Obsoleto)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Coste (Con impuestos) (Obsoleto)"",""descripcion"": """",""keyword"": ""ImporteCosteConImpuestosObsoleto"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteCosteConImpuestosObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteCosteConImpuestosObsoleto
          <DisplayName("Cantidad por vehículo (Obsoleto)")>
          Public Property CantidadPorVehiculoObsoleto As Integer
          Public Shared ___CantidadPorVehiculoObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CantidadPorVehiculoObsoleto"",""etiqueta"": ""Cantidad por vehículo (Obsoleto)"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cantidad por vehículo (Obsoleto)"",""descripcion"": """",""keyword"": ""CantidadPorVehiculoObsoleto"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CantidadPorVehiculoObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___CantidadPorVehiculoObsoleto
          <DisplayName("Precio de venta (Sin impuestos)")>
          Public Property ImportePrecioDeVentaSinImpuestos As Decimal
          Public Shared ___ImportePrecioDeVentaSinImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImportePrecioDeVentaSinImpuestos"",""etiqueta"": ""Precio de venta (Sin impuestos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Precio de venta (Sin impuestos)"",""descripcion"": """",""keyword"": ""ImportePrecioDeVentaSinImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImportePrecioDeVentaSinImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImportePrecioDeVentaSinImpuestos
          <DisplayName("Precio de venta (Con impuestos)")>
          Public Property ImportePrecioDeVentaConImpuestos As Decimal
          Public Shared ___ImportePrecioDeVentaConImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImportePrecioDeVentaConImpuestos"",""etiqueta"": ""Precio de venta (Con impuestos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Precio de venta (Con impuestos)"",""descripcion"": """",""keyword"": ""ImportePrecioDeVentaConImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImportePrecioDeVentaConImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImportePrecioDeVentaConImpuestos
          <DisplayName("Recambio (Equivalencia) (Obsoleto)")>
          Public Property ReferenciaRecambioEquivalenciaObsoleto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaRecambioEquivalenciaObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaRecambioEquivalenciaObsoleto"",""etiqueta"": ""Recambio (Equivalencia) (Obsoleto)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""7fdfe2d7-084d-431e-8196-17ecd437711d"",""titulo"": ""Base - Recambios (Equivalencia)"",""iconoid"": ""4f80146d-d60c-44a8-b20f-8a975d7c8014"",""etiquetasingular"": ""Recambio (Equivalencia)"",""etiquetaplural"": ""Recambios (Equivalencia)"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""7fdfe2d7-084d-431e-8196-17ecd437711d"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Recambio (Equivalencia) (Obsoleto)"",""descripcion"": """",""keyword"": ""ReferenciaRecambioEquivalenciaObsoleto"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaRecambioEquivalenciaObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaRecambioEquivalenciaObsoleto
          <DisplayName("Kilometraje")>
          Public Property Kilometraje As Integer
          Public Shared ___Kilometraje As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Kilometraje"",""etiqueta"": ""Kilometraje"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Kilometraje"",""descripcion"": """",""keyword"": ""Kilometraje"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Kilometraje As DinaNETCore.APID.DinaupAPI_CampoC = ___Kilometraje
          <DisplayName("Año")>
          Public Property Año As Integer
          Public Shared ___Año As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Año"",""etiqueta"": ""Año"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Año"",""descripcion"": """",""keyword"": ""Año"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Año As DinaNETCore.APID.DinaupAPI_CampoC = ___Año
          <DisplayName("Bastidor")>
          Public Property Bastidor As String
          Public Shared ___Bastidor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Bastidor"",""etiqueta"": ""Bastidor"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Bastidor"",""descripcion"": """",""keyword"": ""Bastidor"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Bastidor As DinaNETCore.APID.DinaupAPI_CampoC = ___Bastidor
          <DisplayName("Color")>
          Public Property ReferenciaColor As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaColor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaColor"",""etiqueta"": ""Color"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""48c07c3b-672d-4beb-8dbf-d2a7a4b225bf"",""titulo"": ""Base - Colores"",""iconoid"": ""913548b2-4498-49d3-9044-6b1f4103877c"",""etiquetasingular"": ""Color"",""etiquetaplural"": ""Colores"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""48c07c3b-672d-4beb-8dbf-d2a7a4b225bf"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Color"",""descripcion"": """",""keyword"": ""ReferenciaColor"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaColor As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaColor
          <DisplayName("Refs. Motor")>
          Public Property RefsMotor As String
          Public Shared ___RefsMotor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""RefsMotor"",""etiqueta"": ""Refs. Motor"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Refs. Motor"",""descripcion"": """",""keyword"": ""RefsMotor"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __RefsMotor As DinaNETCore.APID.DinaupAPI_CampoC = ___RefsMotor
          <DisplayName("Fecha Alta del registro")>
          Public Property FechaAlta_UTC As Date?
          Public Shared ___FechaAlta_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaAlta_UTC"",""etiqueta"": ""Fecha Alta del registro"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha Alta del registro"",""descripcion"": """",""keyword"": ""FechaAlta_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaAlta_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaAlta_UTC
          <DisplayName("Hora local")>
          Public Property HoraLocal As DateTime?
          Public Shared ___HoraLocal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""HoraLocal"",""etiqueta"": ""Hora local"",""oculta"": false,""formato"": 8,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Hora local"",""descripcion"": """",""keyword"": ""HoraLocal"",""formato"": 8,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __HoraLocal As DinaNETCore.APID.DinaupAPI_CampoC = ___HoraLocal
          <DisplayName("Autor del alta")>
          Public Property ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaAutorDelAlta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaAutorDelAlta"",""etiqueta"": ""Autor del alta"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta"",""descripcion"": """",""keyword"": ""ReferenciaAutorDelAlta"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaAutorDelAlta
          <DisplayName("Destinador")>
          Public Property ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaDestinador As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaDestinador"",""etiqueta"": ""Destinador"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""relacionesindirectas"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Destinador"",""descripcion"": """",""keyword"": ""ReferenciaDestinador"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaDestinador
          <DisplayName("Autor del alta Tiene Acceso web")>
          Public Property AutorDelAltaTieneAccesoWeb As Boolean
          Public Shared ___AutorDelAltaTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AutorDelAltaTieneAccesoWeb"",""etiqueta"": ""Autor del alta Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta Tiene Acceso web"",""descripcion"": """",""keyword"": ""AutorDelAltaTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AutorDelAltaTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___AutorDelAltaTieneAccesoWeb
          <DisplayName("Empleado Tiene Acceso web")>
          Public Property EmpleadoTieneAccesoWeb As Boolean
          Public Shared ___EmpleadoTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EmpleadoTieneAccesoWeb"",""etiqueta"": ""Empleado Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Empleado Tiene Acceso web"",""descripcion"": """",""keyword"": ""EmpleadoTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EmpleadoTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___EmpleadoTieneAccesoWeb
          <DisplayName("Compra")>
          Public Property ReferenciaCompra As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaCompra As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaCompra"",""etiqueta"": ""Compra"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""340bde1f-cdc9-4471-b55e-44b9c96dd508"",""titulo"": ""Base - Compras y Gastos"",""iconoid"": ""5686dc42-beaf-4bc5-a068-97126541fa55"",""etiquetasingular"": ""Compra / Gasto"",""etiquetaplural"": ""Compras / Gastos"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""340bde1f-cdc9-4471-b55e-44b9c96dd508"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Compra"",""descripcion"": """",""keyword"": ""ReferenciaCompra"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaCompra As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaCompra
          <DisplayName("Detalles")>
          Public Property ReferenciaDetalles As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaDetalles As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaDetalles"",""etiqueta"": ""Detalles"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""05cd3d1a-f021-4a3d-abe6-5306a8c4f113"",""titulo"": ""Base - Detalles de Recursos de la Empresa"",""iconoid"": ""4fc52c67-3886-4a4b-ba71-016c05b62aa0"",""etiquetasingular"": ""Detalles de Recurso de la Empresa"",""etiquetaplural"": ""Detalles de Recursos de la Empresa"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""05cd3d1a-f021-4a3d-abe6-5306a8c4f113"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Detalles"",""descripcion"": """",""keyword"": ""ReferenciaDetalles"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaDetalles As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaDetalles
          <DisplayName("Coste (Sin impuestos)")>
          Public Property ImporteCosteSinImpuestos As Decimal
          Public Shared ___ImporteCosteSinImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteCosteSinImpuestos"",""etiqueta"": ""Coste (Sin impuestos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Coste (Sin impuestos)"",""descripcion"": """",""keyword"": ""ImporteCosteSinImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteCosteSinImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteCosteSinImpuestos
          <DisplayName("Tipo")>
          Public Property ReferenciaTipo As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaTipo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaTipo"",""etiqueta"": ""Tipo"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""826db6ec-4e59-4b54-93aa-6b0021f67714"",""titulo"": ""Base - Tipos de Recursos de la empresa"",""iconoid"": ""22ebc812-3dec-498b-b23a-4c3b46c0fcb9"",""etiquetasingular"": ""Tipo de recurso de la empresa"",""etiquetaplural"": ""Tiposs de recursos de la empresa"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""826db6ec-4e59-4b54-93aa-6b0021f67714"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Tipo"",""descripcion"": """",""keyword"": ""ReferenciaTipo"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaTipo As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaTipo
          <DisplayName("Impuestos")>
          Public Property ReferenciaImpuestos As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaImpuestos"",""etiqueta"": ""Impuestos"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""f3199ee0-dc83-4667-a9c1-f3b04e97a8a4"",""titulo"": ""Base - Impuestos"",""iconoid"": ""ff4a7189-6426-43b9-bdc4-070314999e81"",""etiquetasingular"": ""Impuesto"",""etiquetaplural"": ""Impuestos"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""f3199ee0-dc83-4667-a9c1-f3b04e97a8a4"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Impuestos"",""descripcion"": """",""keyword"": ""ReferenciaImpuestos"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaImpuestos
          <DisplayName("Coste (Con impuestos)")>
          Public Property ImporteCosteConImpuestos As Decimal
          Public Shared ___ImporteCosteConImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteCosteConImpuestos"",""etiqueta"": ""Coste (Con impuestos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Coste (Con impuestos)"",""descripcion"": """",""keyword"": ""ImporteCosteConImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteCosteConImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteCosteConImpuestos
          <DisplayName("Estado")>
          Public Property ReferenciaEstado As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaEstado As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaEstado"",""etiqueta"": ""Estado"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""4b3df6f0-abb7-4957-976a-ff3809d6afb5"",""titulo"": ""Base - Estados de recursos de la empresa"",""iconoid"": ""7a33f990-85ca-4f29-89fd-28545187a22d"",""etiquetasingular"": ""Estado de recurso de la empresa"",""etiquetaplural"": ""Estados de recursos de la empresa"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""4b3df6f0-abb7-4957-976a-ff3809d6afb5"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Estado"",""descripcion"": """",""keyword"": ""ReferenciaEstado"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaEstado As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaEstado
          <DisplayName("Venta")>
          Public Property ReferenciaVenta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaVenta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaVenta"",""etiqueta"": ""Venta"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""bf52e82e-a46a-4161-86cf-4b70c9abc2b6"",""titulo"": ""Base - Facturas"",""iconoid"": ""93c17f06-6e22-4f57-84f7-03d0cdd316a0"",""etiquetasingular"": ""Factura"",""etiquetaplural"": ""Facturas"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""bf52e82e-a46a-4161-86cf-4b70c9abc2b6"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Venta"",""descripcion"": """",""keyword"": ""ReferenciaVenta"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaVenta As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaVenta
          <DisplayName("Elemento de Compra")>
          Public Property ReferenciaElementoDeCompra As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaElementoDeCompra As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaElementoDeCompra"",""etiqueta"": ""Elemento de Compra"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""0447cca1-0bca-4c0e-921a-0d848f088a98"",""titulo"": ""Base Lista - Compras y Gastos"",""iconoid"": """",""etiquetasingular"": ""Elemento de Compra / Gasto"",""etiquetaplural"": ""Elementos de Compra / Gasto"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": true,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""0447cca1-0bca-4c0e-921a-0d848f088a98"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Elemento de Compra"",""descripcion"": """",""keyword"": ""ReferenciaElementoDeCompra"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaElementoDeCompra As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaElementoDeCompra
          <DisplayName("Elemento de Venta")>
          Public Property ReferenciaElementoDeVenta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaElementoDeVenta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaElementoDeVenta"",""etiqueta"": ""Elemento de Venta"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""e0a2b422-8962-4680-89af-a4952e4f5f13"",""titulo"": ""Base Lista - Ventas"",""iconoid"": """",""etiquetasingular"": ""Elemento de Venta"",""etiquetaplural"": ""Elementos de Ventas"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": true,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""e0a2b422-8962-4680-89af-a4952e4f5f13"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Elemento de Venta"",""descripcion"": """",""keyword"": ""ReferenciaElementoDeVenta"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaElementoDeVenta As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaElementoDeVenta
          <DisplayName("Recurso de Origen")>
          Public Property ReferenciaRecursoDeOrigen As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaRecursoDeOrigen As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaRecursoDeOrigen"",""etiqueta"": ""Recurso de Origen"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""3b921d2c-89b7-4cfd-8999-6e44ddabeb72"",""titulo"": ""Base - Recursos de la empresa"",""iconoid"": ""424f5d43-6ae2-43f9-bbea-dacf5868d2aa"",""etiquetasingular"": ""Recurso de la empresa"",""etiquetaplural"": ""Recursos de la empresa"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""3b921d2c-89b7-4cfd-8999-6e44ddabeb72"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Recurso de Origen"",""descripcion"": """",""keyword"": ""ReferenciaRecursoDeOrigen"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaRecursoDeOrigen As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaRecursoDeOrigen
          <DisplayName("Localización Inicial")>
          Public Property ReferenciaLocalizacionInicial As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaLocalizacionInicial As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaLocalizacionInicial"",""etiqueta"": ""Localización Inicial"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""a5d262f3-e3ea-4a8c-926a-465798454b94"",""titulo"": ""Base - Ubicaciones en mapa"",""iconoid"": ""08f5af90-aca8-4d1d-8b4a-601044b4ff9a"",""etiquetasingular"": ""Ubicación en mapa"",""etiquetaplural"": ""Ubicaciones en mapa"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""a5d262f3-e3ea-4a8c-926a-465798454b94"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Localización Inicial"",""descripcion"": """",""keyword"": ""ReferenciaLocalizacionInicial"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaLocalizacionInicial As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaLocalizacionInicial
          <DisplayName("Localización de último Transporte")>
          Public Property ReferenciaLocalizacionDeUltimoTransporte As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaLocalizacionDeUltimoTransporte As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaLocalizacionDeUltimoTransporte"",""etiqueta"": ""Localización de último Transporte"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""a5d262f3-e3ea-4a8c-926a-465798454b94"",""titulo"": ""Base - Ubicaciones en mapa"",""iconoid"": ""08f5af90-aca8-4d1d-8b4a-601044b4ff9a"",""etiquetasingular"": ""Ubicación en mapa"",""etiquetaplural"": ""Ubicaciones en mapa"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""a5d262f3-e3ea-4a8c-926a-465798454b94"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Localización de último Transporte"",""descripcion"": """",""keyword"": ""ReferenciaLocalizacionDeUltimoTransporte"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaLocalizacionDeUltimoTransporte As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaLocalizacionDeUltimoTransporte
          <DisplayName("Partes extraídas (División)")>
          Public Property PartesExtraidasDivision As Integer
          Public Shared ___PartesExtraidasDivision As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""PartesExtraidasDivision"",""etiqueta"": ""Partes extraídas (División)"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Partes extraídas (División)"",""descripcion"": """",""keyword"": ""PartesExtraidasDivision"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __PartesExtraidasDivision As DinaNETCore.APID.DinaupAPI_CampoC = ___PartesExtraidasDivision
          <DisplayName("ID Externa")>
          Public Property IDExterna As String
          Public Shared ___IDExterna As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""IDExterna"",""etiqueta"": ""ID Externa"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""ID Externa"",""descripcion"": """",""keyword"": ""IDExterna"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __IDExterna As DinaNETCore.APID.DinaupAPI_CampoC = ___IDExterna
          <DisplayName("Fecha modificación (Externa)")>
          Public Property FechaModificacionExterna_UTC As Date?
          Public Shared ___FechaModificacionExterna_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaModificacionExterna_UTC"",""etiqueta"": ""Fecha modificación (Externa)"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha modificación (Externa)"",""descripcion"": """",""keyword"": ""FechaModificacionExterna_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaModificacionExterna_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaModificacionExterna_UTC
          <ReadOnlyAttribute(True)>
          <DisplayName("ID")>
          Public Property ID As Guid
          Public Shared ___ID As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": true,""eseliminado"": false,""keyword"": ""ID"",""etiqueta"": ""ID"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""3b921d2c-89b7-4cfd-8999-6e44ddabeb72"",""titulo"": ""Base - Recursos de la empresa"",""iconoid"": ""424f5d43-6ae2-43f9-bbea-dacf5868d2aa"",""etiquetasingular"": ""Recurso de la empresa"",""etiquetaplural"": ""Recursos de la empresa"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""3b921d2c-89b7-4cfd-8999-6e44ddabeb72"",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""ID"",""descripcion"": """",""keyword"": ""ID"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ID As DinaNETCore.APID.DinaupAPI_CampoC = ___ID
          <DisplayName("Nombre")>
          Public Property TextoPrincipal As String
          Public Shared ___TextoPrincipal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""TextoPrincipal"",""etiqueta"": ""Nombre"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Nombre"",""descripcion"": """",""keyword"": ""TextoPrincipal"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __TextoPrincipal As DinaNETCore.APID.DinaupAPI_CampoC = ___TextoPrincipal
          <ReadOnlyAttribute(True)>
          <DisplayName("Fecha Alta Dato")>
          Public Property FechaAltaDato_UTC As Date
          Public Shared ___FechaAltaDato_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaAltaDato_UTC"",""etiqueta"": ""Fecha Alta Dato"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha Alta Dato"",""descripcion"": """",""keyword"": ""FechaAltaDato_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaAltaDato_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaAltaDato_UTC
          <ReadOnlyAttribute(True)>
          <DisplayName("Editado")>
          Public Property FechaUltimaModificacion_UTC As Date
          Public Shared ___FechaUltimaModificacion_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaUltimaModificacion_UTC"",""etiqueta"": ""Editado"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Editado"",""descripcion"": """",""keyword"": ""FechaUltimaModificacion_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaUltimaModificacion_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaUltimaModificacion_UTC
          <ReadOnlyAttribute(True)>
          <DisplayName("Eliminado")>
          Public Property Eliminado As Boolean
          Public Shared ___Eliminado As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": true,""keyword"": ""Eliminado"",""etiqueta"": ""Eliminado"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Eliminado"",""descripcion"": """",""keyword"": ""Eliminado"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Eliminado As DinaNETCore.APID.DinaupAPI_CampoC = ___Eliminado
          <ReadOnlyAttribute(True)>
          <DisplayName("Usuario Creador del dato")>
          Public Property UsuarioCreadorDelDAto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___UsuarioCreadorDelDAto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""UsuarioCreadorDelDAto"",""etiqueta"": ""Usuario Creador del dato"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Usuario Creador del dato"",""descripcion"": """",""keyword"": ""UsuarioCreadorDelDAto"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __UsuarioCreadorDelDAto As DinaNETCore.APID.DinaupAPI_CampoC = ___UsuarioCreadorDelDAto
          <DisplayName("Sección (Relación Sistema)")>
          Public Property Seccion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___Seccion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Seccion"",""etiqueta"": ""Sección (Relación Sistema)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""plantillasp"",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Sección (Relación Sistema)"",""descripcion"": """",""keyword"": ""Seccion"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Seccion As DinaNETCore.APID.DinaupAPI_CampoC = ___Seccion
          <DisplayName("Posición (Orden)")>
          Public Property Posicion As Decimal
          Public Shared ___Posicion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Posicion"",""etiqueta"": ""Posición (Orden)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Posición (Orden)"",""descripcion"": """",""keyword"": ""Posicion"",""formato"": 3,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Posicion As DinaNETCore.APID.DinaupAPI_CampoC = ___Posicion
          <ReadOnlyAttribute(True)>
          <DisplayName("Empresa")>
          Public Property Empresa As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___Empresa As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Empresa"",""etiqueta"": ""Empresa"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""8bcba7c2-11b2-4f81-a7a7-35f65de8aa51"",""titulo"": ""Empresas administradas"",""iconoid"": ""b788149e-1c15-4807-9a25-72adf3333e5b"",""etiquetasingular"": ""Empresa administrada"",""etiquetaplural"": ""Empresas administradas"",""etiquetaesfemenino"": true,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""8bcba7c2-11b2-4f81-a7a7-35f65de8aa51"",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Empresa"",""descripcion"": """",""keyword"": ""Empresa"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Empresa As DinaNETCore.APID.DinaupAPI_CampoC = ___Empresa
          <ReadOnlyAttribute(True)>
          <DisplayName("Modificado")>
          Public Property Modificado As Boolean
          Public Shared ___Modificado As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Modificado"",""etiqueta"": ""Modificado"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Modificado"",""descripcion"": """",""keyword"": ""Modificado"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Modificado As DinaNETCore.APID.DinaupAPI_CampoC = ___Modificado
          <ReadOnlyAttribute(True)>
          <DisplayName("Fecha Indice Actividad")>
          Public Property FechaIndiceActividad_UTC As Date
          Public Shared ___FechaIndiceActividad_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaIndiceActividad_UTC"",""etiqueta"": ""Fecha Indice Actividad"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha Indice Actividad"",""descripcion"": """",""keyword"": ""FechaIndiceActividad_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaIndiceActividad_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaIndiceActividad_UTC
          <ReadOnlyAttribute(True)>
          <DisplayName("Fecha de Sincronización")>
          Public Property Fechadesincronizacion_UTC As Date
          Public Shared ___Fechadesincronizacion_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Fechadesincronizacion_UTC"",""etiqueta"": ""Fecha de Sincronización"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha de Sincronización"",""descripcion"": """",""keyword"": ""Fechadesincronizacion_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __Fechadesincronizacion_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___Fechadesincronizacion_UTC
          Overrides Sub CargarDatos(_Datos as Dic(of string,string))
          me.ReferenciaMarca = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_60010421345"), _Datos.Leer_String("pr_60010421345.nombre"))
          me.ReferenciaModelo = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_60010421346"), _Datos.Leer_String("pr_60010421346.nombre"))
          me.ReferenciaLocalizacionActual = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_30040441061"), _Datos.Leer_String("pr_30040441061.nombre"))
          me.ImporteFacturacionPotencial = _Datos.Leer_Decimal("pr_10010421341")
          me.ImporteBeneficioPotencial = _Datos.Leer_Decimal("pr_10010421342")
          me.ImporteNoFacturable = _Datos.Leer_Decimal("pr_10010421345")
          me.Matricula = _Datos.Leer_String("pr_20010421353")
          me.ReferenciaFoto = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_500104215614"), _Datos.Leer_String("pr_500104215614.nombre"))
          me.ReferenciaPrecioDeVentaImpuestosObsoleto = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_500104215615"), _Datos.Leer_String("pr_500104215615.nombre"))
          me.ImporteCosteConImpuestosObsoleto = _Datos.Leer_Decimal("pr_500104215616")
          me.CantidadPorVehiculoObsoleto = _Datos.Leer_Integer("pr_30010421571")
          me.ImportePrecioDeVentaSinImpuestos = _Datos.Leer_Decimal("pr_30010421572")
          me.ImportePrecioDeVentaConImpuestos = _Datos.Leer_Decimal("pr_30010421574")
          me.ReferenciaRecambioEquivalenciaObsoleto = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_30010421576"), _Datos.Leer_String("pr_30010421576.nombre"))
          me.Kilometraje = _Datos.Leer_Integer("pr_60040473183")
          me.Año = _Datos.Leer_Integer("pr_60040473184")
          me.Bastidor = _Datos.Leer_String("pr_60040473182")
          me.ReferenciaColor = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_30040473192"), _Datos.Leer_String("pr_30040473192.nombre"))
          me.RefsMotor = _Datos.Leer_String("pr_40040473191")
          me.FechaAlta_UTC = _Datos.Leer_DateTime_Nulable("pr_600104213011")
          me.HoraLocal = _Datos.Leer_Time_Nulable("pr_60010421309")
          me.ReferenciaAutorDelAlta = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_60010421307"), _Datos.Leer_String("pr_60010421307.nombre"))
          me.ReferenciaDestinador = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_600104213012"), _Datos.Leer_String("pr_600104213012.nombre"))
          me.AutorDelAltaTieneAccesoWeb = _Datos.Leer_Boolean("pr_600104213022")
          me.EmpleadoTieneAccesoWeb = _Datos.Leer_Boolean("pr_600104213023")
          me.ReferenciaCompra = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_60010421333"), _Datos.Leer_String("pr_60010421333.nombre"))
          me.ReferenciaDetalles = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_60010421331"), _Datos.Leer_String("pr_60010421331.nombre"))
          me.ImporteCosteSinImpuestos = _Datos.Leer_Decimal("pr_60010421335")
          me.ReferenciaTipo = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_20010421771"), _Datos.Leer_String("pr_20010421771.nombre"))
          me.ReferenciaImpuestos = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_60040440031"), _Datos.Leer_String("pr_60040440031.nombre"))
          me.ImporteCosteConImpuestos = _Datos.Leer_Decimal("pr_50040440033")
          me.ReferenciaEstado = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_10040440041"), _Datos.Leer_String("pr_10040440041.nombre"))
          me.ReferenciaVenta = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_50040440042"), _Datos.Leer_String("pr_50040440042.nombre"))
          me.ReferenciaElementoDeCompra = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_10040440527"), _Datos.Leer_String("pr_10040440527.nombre"))
          me.ReferenciaElementoDeVenta = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_10040440528"), _Datos.Leer_String("pr_10040440528.nombre"))
          me.ReferenciaRecursoDeOrigen = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_10040440531"), _Datos.Leer_String("pr_10040440531.nombre"))
          me.ReferenciaLocalizacionInicial = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_40040441071"), _Datos.Leer_String("pr_40040441071.nombre"))
          me.ReferenciaLocalizacionDeUltimoTransporte = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_10040441162"), _Datos.Leer_String("pr_10040441162.nombre"))
          me.PartesExtraidasDivision = _Datos.Leer_Integer("pr_40040441671")
          me.IDExterna = _Datos.Leer_String("pr_50040475821")
          me.FechaModificacionExterna_UTC = _Datos.Leer_DateTime_Nulable("pr_50040475822")
          me.ID = _Datos.Leer_Guid("id")
          me.TextoPrincipal = _Datos.Leer_String("nombre")
          me.FechaAltaDato_UTC = _Datos.Leer_DateTime("fecha")
          me.FechaUltimaModificacion_UTC = _Datos.Leer_DateTime("fecham")
          me.Eliminado = _Datos.Leer_Boolean("eliminado")
          me.UsuarioCreadorDelDAto = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("usuarioid"), _Datos.Leer_String("usuarioid.nombre"))
          me.Seccion = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("plantillapid"), _Datos.Leer_String("plantillapid.nombre"))
          me.Posicion = _Datos.Leer_Decimal("posicion")
          me.Empresa = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("ubicacion"), _Datos.Leer_String("ubicacion.nombre"))
          me.Modificado = _Datos.Leer_Boolean("modificado")
          me.FechaIndiceActividad_UTC = _Datos.Leer_DateTime("fechaia")
          me.Fechadesincronizacion_UTC = _Datos.Leer_DateTime("fechasyn")
          End Sub
          Overrides Function ToDic() as Dic(of String,String)
           dim R as new Dic(of String,String)
         If Me.ReferenciaMarca IsNot nothing then
           R.add("pr_60010421345",me.ReferenciaMarca.ID.STR())
         Else
           R.add("pr_60010421345","")
         End if
         If Me.ReferenciaModelo IsNot nothing then
           R.add("pr_60010421346",me.ReferenciaModelo.ID.STR())
         Else
           R.add("pr_60010421346","")
         End if
         If Me.ReferenciaLocalizacionActual IsNot nothing then
           R.add("pr_30040441061",me.ReferenciaLocalizacionActual.ID.STR())
         Else
           R.add("pr_30040441061","")
         End if
         R.add("pr_10010421341", me.ImporteFacturacionPotencial.AdaptarMySQL_Decimal())
         R.add("pr_10010421342", me.ImporteBeneficioPotencial.AdaptarMySQL_Decimal())
         R.add("pr_10010421345", me.ImporteNoFacturable.AdaptarMySQL_Decimal())
         R.add("pr_20010421353", me.Matricula.AdaptarMySQL_String())
         If Me.ReferenciaFoto IsNot nothing then
           R.add("pr_500104215614",me.ReferenciaFoto.ID.STR())
         Else
           R.add("pr_500104215614","")
         End if
         If Me.ReferenciaPrecioDeVentaImpuestosObsoleto IsNot nothing then
           R.add("pr_500104215615",me.ReferenciaPrecioDeVentaImpuestosObsoleto.ID.STR())
         Else
           R.add("pr_500104215615","")
         End if
         R.add("pr_500104215616", me.ImporteCosteConImpuestosObsoleto.AdaptarMySQL_Decimal())
         R.add("pr_30010421571", me.CantidadPorVehiculoObsoleto.AdaptarMySQL_Integer())
         R.add("pr_30010421572", me.ImportePrecioDeVentaSinImpuestos.AdaptarMySQL_Decimal())
         R.add("pr_30010421574", me.ImportePrecioDeVentaConImpuestos.AdaptarMySQL_Decimal())
         If Me.ReferenciaRecambioEquivalenciaObsoleto IsNot nothing then
           R.add("pr_30010421576",me.ReferenciaRecambioEquivalenciaObsoleto.ID.STR())
         Else
           R.add("pr_30010421576","")
         End if
         R.add("pr_60040473183", me.Kilometraje.AdaptarMySQL_Integer())
         R.add("pr_60040473184", me.Año.AdaptarMySQL_Integer())
         R.add("pr_60040473182", me.Bastidor.AdaptarMySQL_String())
         If Me.ReferenciaColor IsNot nothing then
           R.add("pr_30040473192",me.ReferenciaColor.ID.STR())
         Else
           R.add("pr_30040473192","")
         End if
         R.add("pr_40040473191", me.RefsMotor.AdaptarMySQL_String())
         R.add("pr_600104213011", me.FechaAlta_UTC.AdaptarMySQL_DateTime_Nulable())
         R.add("pr_60010421309", me.HoraLocal.AdaptarMySQL_Time_Nulable())
         If Me.ReferenciaAutorDelAlta IsNot nothing then
           R.add("pr_60010421307",me.ReferenciaAutorDelAlta.ID.STR())
         Else
           R.add("pr_60010421307","")
         End if
         If Me.ReferenciaDestinador IsNot nothing then
           R.add("pr_600104213012",me.ReferenciaDestinador.ID.STR())
         Else
           R.add("pr_600104213012","")
         End if
         R.add("pr_600104213022", me.AutorDelAltaTieneAccesoWeb.AdaptarMySQL_Boolean())
         R.add("pr_600104213023", me.EmpleadoTieneAccesoWeb.AdaptarMySQL_Boolean())
         If Me.ReferenciaCompra IsNot nothing then
           R.add("pr_60010421333",me.ReferenciaCompra.ID.STR())
         Else
           R.add("pr_60010421333","")
         End if
         If Me.ReferenciaDetalles IsNot nothing then
           R.add("pr_60010421331",me.ReferenciaDetalles.ID.STR())
         Else
           R.add("pr_60010421331","")
         End if
         R.add("pr_60010421335", me.ImporteCosteSinImpuestos.AdaptarMySQL_Decimal())
         If Me.ReferenciaTipo IsNot nothing then
           R.add("pr_20010421771",me.ReferenciaTipo.ID.STR())
         Else
           R.add("pr_20010421771","")
         End if
         If Me.ReferenciaImpuestos IsNot nothing then
           R.add("pr_60040440031",me.ReferenciaImpuestos.ID.STR())
         Else
           R.add("pr_60040440031","")
         End if
         R.add("pr_50040440033", me.ImporteCosteConImpuestos.AdaptarMySQL_Decimal())
         If Me.ReferenciaEstado IsNot nothing then
           R.add("pr_10040440041",me.ReferenciaEstado.ID.STR())
         Else
           R.add("pr_10040440041","")
         End if
         If Me.ReferenciaVenta IsNot nothing then
           R.add("pr_50040440042",me.ReferenciaVenta.ID.STR())
         Else
           R.add("pr_50040440042","")
         End if
         If Me.ReferenciaElementoDeCompra IsNot nothing then
           R.add("pr_10040440527",me.ReferenciaElementoDeCompra.ID.STR())
         Else
           R.add("pr_10040440527","")
         End if
         If Me.ReferenciaElementoDeVenta IsNot nothing then
           R.add("pr_10040440528",me.ReferenciaElementoDeVenta.ID.STR())
         Else
           R.add("pr_10040440528","")
         End if
         If Me.ReferenciaRecursoDeOrigen IsNot nothing then
           R.add("pr_10040440531",me.ReferenciaRecursoDeOrigen.ID.STR())
         Else
           R.add("pr_10040440531","")
         End if
         If Me.ReferenciaLocalizacionInicial IsNot nothing then
           R.add("pr_40040441071",me.ReferenciaLocalizacionInicial.ID.STR())
         Else
           R.add("pr_40040441071","")
         End if
         If Me.ReferenciaLocalizacionDeUltimoTransporte IsNot nothing then
           R.add("pr_10040441162",me.ReferenciaLocalizacionDeUltimoTransporte.ID.STR())
         Else
           R.add("pr_10040441162","")
         End if
         R.add("pr_40040441671", me.PartesExtraidasDivision.AdaptarMySQL_Integer())
         R.add("pr_50040475821", me.IDExterna.AdaptarMySQL_String())
         R.add("pr_50040475822", me.FechaModificacionExterna_UTC.AdaptarMySQL_DateTime_Nulable())
         R.add("id", me.ID.AdaptarMySQL_Guid())
         R.add("nombre", me.TextoPrincipal.AdaptarMySQL_String())
         R.add("fecha", me.FechaAltaDato_UTC.AdaptarMySQL_DateTime())
         R.add("fecham", me.FechaUltimaModificacion_UTC.AdaptarMySQL_DateTime())
         R.add("eliminado", me.Eliminado.AdaptarMySQL_Boolean())
         If Me.UsuarioCreadorDelDAto IsNot nothing then
           R.add("usuarioid",me.UsuarioCreadorDelDAto.ID.STR())
         Else
           R.add("usuarioid","")
         End if
         If Me.Seccion IsNot nothing then
           R.add("plantillapid",me.Seccion.ID.STR())
         Else
           R.add("plantillapid","")
         End if
         R.add("posicion", me.Posicion.AdaptarMySQL_Decimal())
         If Me.Empresa IsNot nothing then
           R.add("ubicacion",me.Empresa.ID.STR())
         Else
           R.add("ubicacion","")
         End if
         R.add("modificado", me.Modificado.AdaptarMySQL_Boolean())
         R.add("fechaia", me.FechaIndiceActividad_UTC.AdaptarMySQL_DateTime())
         R.add("fechasyn", me.Fechadesincronizacion_UTC.AdaptarMySQL_DateTime())
            Return R
          End Function
          Sub new()
          End Sub
      End Class
  End Class
End Class

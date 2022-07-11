



Para visualizar correctamente este archivo. 
Instale en visual studio la extensión https://marketplace.visualstudio.com/items?itemName=MadsKristensen.MarkdownEditor2



# DiaupCont 

`MiDinaup` proporciona una interfaza para leer/editar/agregar los datos de la empresa en Dinaup.
No obstante, los métodos que proprociona `MiDinaup` no siempre son ideales.
Por ejemplo, si queremos crear un método que cambie el estado de una tarea a "Completada".
Lo deberemos agregar  en `DinaupCont`.
De este modo la vista queda lo más limpia posible.

---

Esta carpeta está reserveda para las funciones que llaman a `MiDinaup`. \
El nombre del archvivo debe seguir la regla de  `NombreSeccion` + `D`. \
Ejemplo:
1. TareasD
1. VentasD
1. VehiculosD




## Orden
Las definiciones de los métodos, funciones y constantes deben tener un orden.
1. Constantes, variables...
1. **Lectura**: Deben empezar por `Leer_`. Ejemplo `Leer_MisTareas`, `Leer_TodasLasTareas`
1. **Agregar**: Deben empezar por `Agregar_`. Ejemplo `Agregar_Tarea`
1. **Modificar**:  Deben empezar por `Editar_`. Ejemplo `Editar_Tarea`,  `Editar_MarcarTareaComoCompletada`
1. **Helpers**: Deben empezar por `H_` y deben estar al final del documento.

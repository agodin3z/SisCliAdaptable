SISCLIAD
===========

Sistema Clínico Adaptable  
Gestiona Expedientes Médicos de Pacientes y Citas de Clínicas de Medicina General y Clínicas Veterinarias

## Pre-Requisitos para el desarrollo del Sistema

Antes que nada, debemos tener instalado lo siguiente:

* [Git](https://git-scm.com/downloads)
* [Microsoft .NET Framework 4.5](https://www.microsoft.com/es-es/download/details.aspx?id=30653)
* [Visual Studio +2012](https://www.visualstudio.com/es/)
* [Microsoft SQL Server 2012](https://www.microsoft.com/es-es/download/details.aspx?id=29062)
* [Microsoft SQL Server Management Studio 2012](https://www.microsoft.com/es-es/download/details.aspx?id=29062)

## Estructura del proyecto  
Este proyecto esta formado por la siguiente estructura de archivos:  

```
.
|-- .gitignore				# Archivos ignorados por git
|-- Documentacion/			# Toda la documentación del sistema
|-- LICENSE				# Licencia
|-- README.md 				# Archivo README
`-- Source/				# Codigo fuente del Sistema
    |-- SisCliAdaptable.sln 		# Archivo solución de Visual Studio 
    |-- SisCliMed/			# Código fuente Sistema Clínico de Medicina General
    |   |-- App.config 			# Archivo de configuración de la aplicación
    |   |-- My Project/			# Configuracion del proyecto
    |   |-- SisCliMed.vbproj 		# Contiene información sobre todos los elementos que forman parte del proyecto
    |   |-- bin/			# Archivos compilados
    |   `-- obj/			# Archivos temporales de depuración
    |-- SisCliVet/			# Código fuente Sistema Clínico Veterinario
    |   |-- App.config 			# Archivo de configuración de la aplicación
    |   |-- My Project/			# Configuracion del proyecto
    |   |-- Resources/			# Recursos del proyecto
    |   |-- SisCliVet.vbproj 		# Contiene información sobre todos los elementos que forman parte del proyecto
    |   |-- bin/			# Archivos compilados
    |   `-- obj/			# Archivos temporales de depuración
    |-- script_SisCliMed.sql 		# Script SQL de la Base de Datos para SisCliMed
    `-- script_SisCliVet.sql 		# Script SQL de la Base de Datos para SisCliVet
```

## Flujo de Trabajo

Antes de trabajar en este proyecto, primero debes de hacerle **`Fork`** y hacer todos los cambios en tu copia, luego enviarlos a este repositorio como un **`Pull Request`** a la rama testing.
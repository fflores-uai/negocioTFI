# Rpositorio Negocio TFI
Negocio TFI Cursada 2016


## Configurar Proyecto en IIS Local:

1. Agregar dentro del IIS local el sitio:
	Sitios > Agregar Sitio Web...

2. Configuración:
	- Nombre de sitio: `tfiNegocio`.
	- Ruta Física: `D:\WorkGit\UAI\negocioTFI\NegocioTFI\Presentation.WebSite`.
		- (Ruta en donde se encuntra el proyecto web de Visual Studio).
	- Nombre de Host: `dev.tfisystem.com`.
	- Todo lo demas va por default.

3.  Ir a grupos de aplicaciones.
	Buscar tfiNegocio > boton derecho > Configuracion Basica...
	Version NET: (Seleccionar) NET V4.0

4. 	Ir a C:\Windows\system32\drivers\etc\
	Abrir archivo `host`
    Agregar dentro de las paginas:
    `127.0.0.1 dev.tfisystem.com`

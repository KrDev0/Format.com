# Format.com

**Format.com** es una aplicación diseñada para facilitar el formateo de unidades USB, ofreciendo una experiencia de usuario mejorada y una interfaz más intuitiva en comparación con la herramienta nativa de Windows. Además, proporciona información detallada sobre la unidad USB, como su capacidad, sistema de archivos y estado de salud.

---

## Características Principales

- **Interfaz amigable**: Diseño moderno y fácil de usar.
- **Información detallada**: Muestra datos relevantes sobre la unidad USB.
- **Formateo rápido y seguro**: Permite formatear unidades USB con diferentes sistemas de archivos (FAT32, NTFS, exFAT).
- **Compatibilidad**: Funciona en sistemas Windows.

---

## Captura de Pantalla

![Interfaz de Format.com](https://github.com/KrDev0/Format.com/blob/master/Format.com/PIC/soft.png)  
*Interfaz principal de Format.com, mostrando opciones de formateo e información de la USB.*

---

## Uso

1. **Descarga**: Clona el repositorio o descarga el ejecutable desde [Releases](https://github.com/KrDev0/Format.com/releases).
2. **Instala**: Abre la aplicación `DriveFormat.exe`.
3. **Selecciona la unidad**: Elige la unidad USB que deseas formatear.
4. **Configura**: Selecciona el sistema de archivos y el nombre de la unidad.
5. **Formatea**: Haz clic en "Formatear" y espera a que el proceso termine.

---

## Requisitos

- Sistema operativo Windows 10 o superior.
- .NET Framework 4.8.1 o superior.
- Una unidad USB conectada al equipo.

---

## Instalación

1. Clona el repositorio:
   ```bash
   git clone https://github.com/KrDev0/Format.com.git
2. Abre la solución en Visual Studio.

3. Compila el proyecto.

4. Una vez compilado es necesario crear y ejecutar la siguiente clave de registro para poder utilizar el software desde el menu contextual de Windows
Windows Registry Editor Version 5.00

[HKEY_CLASSES_ROOT\Drive\shell\format]
@="Formatear..."

[HKEY_CLASSES_ROOT\Drive\shell\format\command]
@="\"D:\\KrDev\\Escritorio\\Format.com\\Format.com\\bin\\Debug\\df.exe\" \"%1\""


Contribuciones
¡Las contribuciones son bienvenidas! Si deseas mejorar este proyecto, sigue estos pasos:

1. Haz un fork del repositorio.

2. Crea una rama para tu contribución (git checkout -b feature/nueva-funcionalidad).

3. Realiza tus cambios y haz commit (git commit -m 'Añade nueva funcionalidad').

4. Haz push a la rama (git push origin feature/nueva-funcionalidad).

5. Abre un Pull Request en GitHub.

Licencia
Este proyecto está bajo la Licencia MIT.
Consulta el archivo [LICENSE](license/) para más detalles.

Enlace al Repositorio
El código fuente de Format.com está disponible en GitHub:
[GitHub](https://github.com/KrDev0/Format.com)

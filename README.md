# 🛒 EPE1 - Inventario Supermercado

[![GitHub - jonaaxsic](https://img.shields.io/badge/GitHub-jonaaxsic-black?logo=github)](https://github.com/jonaaxsic)
[![GitHub - WolfDs21](https://img.shields.io/badge/GitHub-WolfDs21-black?logo=github)](https://github.com/WolfDs21)
![VB.NET](https://img.shields.io/badge/VB.NET-512BD4?logo=.net&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91?logo=visualstudio&logoColor=white)

## 📋 Descripción del Proyecto

Este proyecto consiste en una aplicación de escritorio desarrollada en **VB.NET** que permite gestionar el inventario de productos de un supermercado mediante la lectura de un archivo Excel (`Lista.xls`).

### ✨ Funcionalidades

#### ✅ Cargar Datos desde un Archivo Excel
- Al hacer clic en el botón **"Cargar datos al combo"**, se lee el archivo `Lista.xls`.
- Se llenan los elementos del `ComboBox` con los códigos de productos de la **columna A** del Excel.

#### ✅ Mostrar Detalles del Producto
- Cuando se selecciona un producto desde el `ComboBox`, se muestran automáticamente:
  - **Nombre del producto**
  - **Precio**
  - **Stock**
  - **Descripción**
- Estos datos se muestran en `TextBox` correspondientes, como se ve en la imagen de ejemplo.

#### ✅ Configuraciones del Formulario
- El formulario **no puede redimensionarse**.
- Los botones de **maximizar y minimizar están deshabilitados**.
- El botón de carga se **bloquea** luego de haber cargado los códigos exitosamente.

#### ✅ Validación de Datos
- Se maneja adecuadamente la ausencia del archivo Excel o si el archivo está vacío.
- Cualquier error no manejado es documentado con comentarios en el código para futuras referencias.

---



---

## 🛠 Requisitos

- Visual Studio con soporte para VB.NET
- Microsoft Excel instalado (o librería de interoperabilidad para leer archivos `.xls`)
- Archivo `Lista.xls` ubicado correctamente para su lectura

---

## 🚀 Instrucciones para Ejecutar

1. Clona este repositorio o descarga los archivos fuente.
2. Abre el proyecto en **Visual Studio**.
3. Asegúrate de que el archivo `Lista.xls` esté en el lugar correcto.
4. Ejecuta el formulario (`F5`).
5. Haz clic en el botón **"Cargar datos al combo"** para cargar los códigos.
6. Selecciona un código para ver los detalles del producto.

---

## 🧑‍💻 Autores

- [jonaaxsic](https://github.com/jonaaxsic)
- [WolfDs21](https://github.com/WolfDs21)

---

## 📝 Notas

- Este proyecto fue desarrollado como parte de una evaluación práctica (**EPE1**) de un módulo académico.
- Puedes modificar y extender el proyecto para nuevas funcionalidades como: agregar productos, eliminar, editar, guardar en Excel, etc.

---


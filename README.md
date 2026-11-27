# Sistema de Turnos para Pacientes (Clínica)
**Proyecto 08 — Estructuras de Datos (C# / Windows Forms)**

Aplicación de escritorio para gestionar la fila de espera de una clínica. La cual permite registrar pacientes por orden de llegada, meter urgencias o turnos preferentes en medio de la fila, cancelar turnos y revisar el historial hacia atrás.

La lógica principal está hecha implementando nuestra propia **Lista Doblemente Enlazada** desde cero, y además incluye una comparativa de rendimiento (benchmark) contra el `LinkedList<T>` nativo de .NET.

## Equipo
* Gadi Jeani Del Carmen Memije
* Erick Jair Hernández Pacheco
* Francisco Javier Martínez Muñoz

## Herramientas utilizadas
* C# (.NET 8)
* Windows Forms
* Visual Studio 2022

## Organización de carpetas
* **`Dominio`** — Clases de los pacientes y tipos de turno (general, urgencia, preferente).
* **`Estructuras`** — Implementación manual de la lista doblemente enlazada y el adaptador para `LinkedList<T>`.
* **`Interfaces`** — Interfaces para conectar las estructuras con los servicios.
* **`Servicios`** — Lógica de control de la sala de espera y pruebas de rendimiento.
* **`UI`** — Pantallas y diseño visual en Windows Forms.
* **`docs`** — Documentación, análisis de complejidad y capturas del programa.

## ¿Cómo correr el proyecto?
1. Clona este repositorio en tu computadora o descárgalo en ZIP.
2. Abre el archivo de solución (`.sln`) con **Visual Studio 2022**.
3. Dale en compilar y presiona `F5` para iniciar.

## Bitácora de avances
Hecho **Día 1:** Creación de la solución, estructura de carpetas y configuración del repositorio.
Hecho **Día 2:** Discusión del avance. Nodos y métodos básicos de la lista doble, modelos de turno y diseño inicial del Form.
Pendiente **Día 3:** Inserciones intermedias, eliminación, adaptador de `LinkedList<T>` y vista del turno actual.
Pendiente **Día 4:** Conexión con la interfaz, validaciones de campos (`ErrorProvider`) y pruebas de funcionamiento.
Pendiente **Día 5:** Módulo de benchmark (comparativa de tiempos) y ventana de resultados.
Pendiente **Día 6:** Pruebas finales en modo Release, capturas de pantalla y documentación en `docs/`.

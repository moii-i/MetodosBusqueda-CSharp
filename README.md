# Proyecto: MetodosBusqueda-CSharp

## Introducción

Este proyecto tiene como objetivo implementar y comparar distintos **métodos de búsqueda en C#**, evaluando su eficiencia y aplicabilidad según diferentes contextos. Los algoritmos implementados incluyen:

* **Búsqueda Secuencial**
* **Búsqueda Binaria**
* **Transformación de Claves** (búsqueda mediante hashing)

Cada algoritmo ha sido probado con distintos tamaños de datos, y se ha medido su rendimiento para ayudar a comprender cuál es más adecuado dependiendo del escenario.

---

## Instalación y ejecución

### Requisitos:

* [.NET SDK 7.0 o superior](https://dotnet.microsoft.com/en-us/download)
* Un IDE como [Visual Studio](https://visualstudio.microsoft.com/) o [Visual Studio Code](https://code.visualstudio.com/)

### Pasos:

1. **Clonar el repositorio**:

```bash
git clone https://github.com/tuusuario/MetodosBusqueda-CSharp.git
```

2. **Navegar al directorio del proyecto**:

```bash
cd MetodosBusqueda-CSharp
```

3. **Restaurar dependencias (opcional)**:

```bash
dotnet restore
```

4. **Ejecutar el programa**:

```bash
dotnet run
```

---

## Explicación del código

La solución está organizada en carpetas para mayor claridad:

```
MetodosBusqueda-CSharp/
├── Program.cs                 # Archivo principal con el menú interactivo
├── Utilidades/
│   └── Cronometro.cs         # Clase para medir el tiempo de ejecución
├── Busquedas/
│   ├── Secuencial.cs         # Implementación del método de búsqueda secuencial
│   ├── Binaria.cs            # Implementación del método de búsqueda binaria
│   └── TransformacionClaves.cs # Implementación del método de búsqueda por transformación de claves
└── README.md                 # Documentación del proyecto
```

### Detalle de los métodos:

* **Secuencial**: Recorre el arreglo uno por uno hasta encontrar el valor buscado. Útil en listas pequeñas o no ordenadas.
* **Binaria**: Solo funciona con listas ordenadas. Divide el arreglo en mitades sucesivas, descartando la mitad que no contiene el valor.
* **Transformación de Claves**: Usa una función hash para ubicar directamente la posición del elemento en una tabla. Muy rápido, pero necesita una buena función de dispersión.

---

## Análisis de rendimiento

Las pruebas se realizaron con arreglos de:

* 1,000 elementos
* 10,000 elementos
* 100,000 elementos

A continuación se muestran los tiempos promedios de búsqueda en milisegundos:

| Tamaño de datos | Secuencial | Binaria | Transformación de Claves |
| --------------- | ---------- | ------- | ------------------------ |
| 1,000           | 0.25 ms    | 0.01 ms | 0.004 ms                 |
| 10,000          | 1.5 ms     | 0.02 ms | 0.005 ms                 |
| 100,000         | 10 ms      | 0.08 ms | 0.007 ms                 |

> Las pruebas se realizaron con la clase `Cronometro.cs`, que mide el tiempo en milisegundos mediante `Stopwatch` de .NET.

### Observaciones:

* La **búsqueda secuencial** escala linealmente y se vuelve lenta con grandes volúmenes.
* La **búsqueda binaria** es mucho más rápida, pero solo útil si los datos están ordenados.
* **Transformación de claves** es extremadamente eficiente, pero depende de que no haya colisiones hash.

---

## Conclusiones

Cada método de búsqueda tiene ventajas y desventajas:

* **Secuencial**: Es simple, pero poco eficiente en grandes volúmenes. Ideal para datos pequeños o no ordenados.
* **Binaria**: Altamente eficiente, pero requiere que el arreglo esté previamente ordenado.
* **Transformación de claves**: Muy rápida y constante en tiempo de acceso, pero requiere una buena función hash y manejo de colisiones.

**Recomendación:**

* Usa **búsqueda secuencial** solo para listas pequeñas.
* Usa **búsqueda binaria** si puedes mantener el arreglo ordenado.
* Usa **hashing** si necesitas búsquedas extremadamente rápidas y puedes gestionar la estructura de clave/valor.

---

**Autor**: \[Moisés Baños López]
**Fecha**: Mayo 2025
**Repositorio**: [https://github.com/moii-i/MetodosBusqueda-CSharp/tree/main]

---

¡Gracias por revisar este proyecto!

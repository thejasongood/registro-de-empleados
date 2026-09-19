# Registro de Empleados

Programa de consola desarrollado en C# para llevar un registro básico de empleados. El sistema permite agregar empleados, consultar los registros existentes y realizar algunas operaciones adicionales desde un menú.

## Funciones principales

* Agregar empleados con:

  * ID automático
  * Nombre
  * Salario base
  * Horas extra
* Listar todos los empleados registrados.
* Mostrar el pago total de cada empleado, incluyendo las horas extra.
* Buscar empleados por nombre.
* Calcular el factorial de un número entero.
* Salir del programa desde el menú principal.

## Estructura

El proyecto está dividido principalmente en dos partes:

* **Program.cs:** contiene el menú principal y las funciones para registrar, mostrar y buscar empleados, además del cálculo factorial.
* **Empleado.cs:** contiene la clase `Empleado`, sus propiedades y el método `PagoTotal()` utilizado para calcular el salario con horas extra.

## Cálculo del pago

Las horas extra tienen un valor fijo de **Q50.00** cada una.

```text
Pago total = Salario base + (Horas extra × Q50)
```

## Tecnologías utilizadas

* C#
* .NET
* Visual Studio
* Aplicación de consola

## Objetivo

El objetivo del proyecto es practicar el uso de clases, listas, métodos, ciclos, condicionales, validación de datos y recursividad mediante un programa sencillo de registro de empleados.

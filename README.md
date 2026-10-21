# Ejercicios de condicionales en C#

**Aprendiz:** Luis Mateo Guerra Arango  
**Número de ficha:** 3412768  
**Programa de formación:** Análisis y Desarrollo de Software

Repositorio con 30 ejercicios de lógica condicional, cada uno organizado como un proyecto de consola independiente dentro de la solución [`Condicionales.slnx`](Condicionales.slnx).

## Índice de problemas

| Problema | Título | Estructura elegida | Proyecto |
|---|---|---|---|
| 01 | Registro electoral | Operador ternario | [Problema01](Problema01/) |
| 02 | Tarifa de envío por peso | `if` y `switch` por rangos | [Problema02](Problema02/) |
| 03 | Menú de cajero automático | Expresión `switch` | [Problema03](Problema03/) |
| 04 | Alerta de batería | `if` simple | [Problema04](Problema04/) |
| 05 | El mayor de dos números | Operador ternario | [Problema05](Problema05/) |
| 06 | Piedra, papel o tijera | `if` / `else if` compuesto | [Problema06](Problema06/) |
| 07 | Signo de un número | `if` / `else if` / `else` | [Problema07](Problema07/) |
| 08 | Vocal o consonante | `if` / `else if` y validación | [Problema08](Problema08/) |
| 09 | Año bisiesto | Condición booleana y ternario | [Problema09](Problema09/) |
| 10 | Analizador de datos recibidos | `switch` con patrones de tipo | [Problema10](Problema10/) |
| 11 | Semáforo inteligente | Enumeración y `switch` | [Problema11](Problema11/) |
| 12 | Aprobación de crédito | `if` anidado | [Problema12](Problema12/) |
| 13 | Códigos de país | Expresión `switch` | [Problema13](Problema13/) |
| 14 | Estado del aprendiz | Operador ternario | [Problema14](Problema14/) |
| 15 | Índice de masa corporal | `switch` con patrones relacionales | [Problema15](Problema15/) |
| 16 | Ubicación de un dron | `if` / `else if` | [Problema16](Problema16/) |
| 17 | Control de un reproductor | Expresión `switch` | [Problema17](Problema17/) |
| 18 | Montaña rusa | Condición booleana y ternario | [Problema18](Problema18/) |
| 19 | Radar de velocidad | `switch` con patrones relacionales | [Problema19](Problema19/) |
| 20 | Días de cada mes | `switch` con patrones `or` | [Problema20](Problema20/) |
| 21 | Carrito de compras | Ternario e interpolación | [Problema21](Problema21/) |
| 22 | Calculadora básica | `switch` y excepciones | [Problema22](Problema22/) |
| 23 | Inicio de sesión | `if` / `else if` / `else` | [Problema23](Problema23/) |
| 24 | ¿Día hábil? | `switch` con patrones relacionales | [Problema24](Problema24/) |
| 25 | Calidad del aire | `switch` con patrones relacionales | [Problema25](Problema25/) |
| 26 | Peaje | Expresión `switch` | [Problema26](Problema26/) |
| 27 | Taquilla de cine | `switch` por día y ternario | [Problema27](Problema27/) |
| 28 | Descuento por compra | `switch` por rangos e `if` | [Problema28](Problema28/) |
| 29 | Control de acceso a la sede | Condición booleana y `switch` | [Problema29](Problema29/) |
| 30 | Boletín de calificaciones | `switch` y condicionales | [Problema30](Problema30/) |

Cada proyecto tiene un README con su estructura condicional, una justificación y la ruta para agregar la captura de ejecución en `evidencias/salida.png`. Las capturas se deben incorporar manualmente después de ejecutar cada ejercicio.

## Ejecución

Compilar la solución completa:

```powershell
dotnet build Condicionales.slnx
```

Ejecutar un problema individual:

```powershell
dotnet run --project Problema01/Problema01.csproj
```

Los programas leen los datos desde la entrada estándar, en el orden indicado por cada enunciado.

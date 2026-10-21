# Problema 10. Analizador de datos recibidos

**Estructura elegida:** `switch` con patrones de tipo.

**Justificación:** selecciona el mensaje usando el tipo real del objeto recibido, de forma legible y segura.

La entrada se interpreta como booleano, entero o decimal cuando puede analizarse como uno de esos tipos; en los demás casos se trata como texto.

**Evidencia:** agrega la captura de ejecución en `evidencias/salida.png`.

![Salida](evidencias/salida.png)

# Tarea 1.2: Modelado de Grafos

## Información
- **Nombre:** [Ricardo Rodrifuez Hernandez]
- **Fecha:** [05 de diciembre del 2025]
- 
# Modelado de Grafos en Problemas Reales

Este repositorio contiene tres ejercicios donde se modelan diferentes situaciones reales usando grafos.

## Contenido

### Ejercicio 1: Sistema de Vuelos
Modela una red de vuelos nacionales e internacionales con un grafo **dirigido y ponderado**.

| Origen   | Destino  | Precio |
|----------|----------|--------|
| México   | Cancún   | $1500  |
| México   | Monterrey| $1200  |
| Cancún   | Miami    | $3500  |
| Monterrey| Houston  | $2800  |
| Houston  | Miami    | $1800  |
| Miami    | México   | $4000  |

- Dibuja el grafo (con flechas y precios)
## Preguntas a resolver
- ¿Es dirigido o no dirigido? ¿Es ponderado?
- Calcula el grado de entrada y salida de cada ciudad
- ¿Cuál ciudad tiene más vuelos salientes?
- Encuentra la ruta más barata de México a Miami
- ¿Existe algún ciclo? Si sí, descríbelo

### Ejercicio 2: Red de Computadoras
Representa la estructura de una red de oficina con un grafo **no dirigido**, verificando su conexidad.

- El Router principal conecta con: Servidor, Switch1, Switch2
- Switch1 conecta con: PC1, PC2, Impresora1
- Switch2 conecta con: PC3, PC4, Impresora2
- El Servidor conecta con: Router (ya mencionado)

- Dibuja el grafo de la red
## Preguntas a resolver
- ¿Cuántos vértices y aristas tiene?
- ¿Es conexo? ¿Qué significa esto para la red?
- ¿Es un árbol? Justifica
- Si se desconecta el Router, ¿cuántas componentes conexas quedan?
- ¿Cuál es el dispositivo más crítico de la red? (si falla, más dispositivos quedan aislados)

### Ejercicio 3: Grafo Personal
Modela una situación real de tu elección como grafo.
Puede ser: tu grupo de amigos, materias y prerrequisitos,
rutas de transporte que usas, etc.

Requisitos mínimos:
- Al menos 6 vértices
- Al menos 7 aristas
- Debe representar algo real de tu vida o entorno

## Incluye 
- Descripción del problema que estás modelando
- Qué representa cada vértice
- Qué representa cada arista
- Diagrama del grafo
- Análisis: grados, conexidad, ciclos si existen
- Una pregunta interesante que puedas responder con tu grafo




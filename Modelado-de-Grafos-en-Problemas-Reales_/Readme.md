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

a) Dibuja el grafo (con flechas y precios)
## Preguntas a resolver
- b) ¿Es dirigido o no dirigido? ¿Es ponderado?
- c) Calcula el grado de entrada y salida de cada ciudad
- d) ¿Cuál ciudad tiene más vuelos salientes?
- e) Encuentra la ruta más barata de México a Miami
- f) ¿Existe algún ciclo? Si sí, descríbelo

### Ejercicio 2: Red de Computadoras
Representa la estructura de una red de oficina con un grafo **no dirigido**, verificando su conexidad.

- El Router principal conecta con: Servidor, Switch1, Switch2
- Switch1 conecta con: PC1, PC2, Impresora1
- Switch2 conecta con: PC3, PC4, Impresora2
- El Servidor conecta con: Router (ya mencionado)

a) Dibuja el grafo de la red
## Preguntas a resolver
- b) ¿Cuántos vértices y aristas tiene?
- c) ¿Es conexo? ¿Qué significa esto para la red?
- d) ¿Es un árbol? Justifica
- e) Si se desconecta el Router, ¿cuántas componentes conexas quedan?
- f) ¿Cuál es el dispositivo más crítico de la red? (si falla, más dispositivos quedan aislados)

### Ejercicio 3: Grafo Personal
Modela una situación real de tu elección como grafo.
Puede ser: tu grupo de amigos, materias y prerrequisitos,
rutas de transporte que usas, etc.

Requisitos mínimos:
- Al menos 6 vértices
- Al menos 7 aristas
- Debe representar algo real de tu vida o entorno

## Incluye 
- a) Descripción del problema que estás modelando
- b) Qué representa cada vértice
- c) Qué representa cada arista
- d) Diagrama del grafo
- e) Análisis: grados, conexidad, ciclos si existen
- f) Una pregunta interesante que puedas responder con tu grafo




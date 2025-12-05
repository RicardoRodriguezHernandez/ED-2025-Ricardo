# Ejercicio 3: Grafo Personal de Amistades

## Descripción
Este grafo modela mi grupo de amigos y sus conexiones de amistad.

## Vértices
Cada vertice representa a mis amigos, en este caso: Ana, Bruno, Carla, Diego, Elena, Fabio

## Aristas (amistades)
Cada arista representa las relaciones de mis amigos
- Ana — Bruno
- Ana — Carla
- Bruno — Carla
- Carla — Diego
- Bruno — Diego
- Diego — Elena
- Elena — Fabio
- Fabio — Ana

## Grados
- Ana: grado 3 (Bruno, Carla, Fabio)
- Bruno: grado 3 (Ana, Carla, Diego)
- Carla: grado 3 (Ana, Bruno, Diego)
- Diego: grado 2 (Carla, Bruno, Elena)
- Elena: grado 2 (Diego, Fabio)
- Fabio: grado 2 (Elena, Ana)

## Conexidad
El grafo es **conexo**.

## Ciclos
Sí:
- Triángulo Ana — Bruno — Carla — Ana
- Ciclos largos pasando por Fabio y Elena

## Pregunta interesante
¿Quiénes son las personas más influyente del grupo?  
→ **Ana, Bruno, Diego y Carla** (todos con grado 3)

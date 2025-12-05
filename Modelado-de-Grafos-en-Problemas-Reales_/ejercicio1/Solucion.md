# Ejercicio 1: Sistema de Vuelos

## Tipo de grafo
- **Dirigido** (cada vuelo tiene dirección)
- **Ponderado** (cada arista tiene precio)

## Aristas
- México → Cancún : $1500
- México → Monterrey : $1200
- Cancún → Miami : $3500
- Monterrey → Houston : $2800
- Houston → Miami : $1800
- Miami → México : $4000

## Grados de entrada y salida
- México: entrada = 1, salida = 2  
- Cancún: entrada = 1, salida = 1  
- Monterrey: entrada = 1, salida = 1  
- Houston: entrada = 1, salida = 1  
- Miami: entrada = 2, salida = 1  

## Ciudad con más vuelos salientes
- **México**

## Ruta más barata México → Miami
- México → Cancún → Miami = **$5000** (más barata)
- México → Monterrey → Houston → Miami = $5800

**Ruta óptima:** México → Cancún → Miami

## ¿Existen ciclos?
Sí:
- México → Cancún → Miami → México  
- México → Monterrey → Houston → Miami → México


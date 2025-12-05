# Ejercicio 2: Red de Computadoras

## Vértices
Router, Servidor, Switch1, Switch2, PC1, PC2, PC3, PC4, Impresora1, Impresora2

## Aristas
- Router — Servidor
- Router — Switch1
- Router — Switch2
- Switch1 — PC1
- Switch1 — PC2
- Switch1 — Impresora1
- Switch2 — PC3
- Switch2 — PC4
- Switch2 — Impresora2

## Número de vértices y aristas
- **10 vértices**
- **9 aristas**

## ¿Es conexo?
Sí, todos los dispositivos pueden comunicarse entre sí.

## ¿Es un árbol?
Sí, porque:
- Es conexo
- Tiene n − 1 aristas (10 − 1 = 9)
- No tiene ciclos

## Si se desconecta el Router:
Quedan **3 componentes**:
1. Servidor
2. Switch1 + PC1 + PC2 + Impresora1
3. Switch2 + PC3 + PC4 + Impresora2

## Dispositivo más crítico
**El Router**, porque separa la red en 3 partes si falla.

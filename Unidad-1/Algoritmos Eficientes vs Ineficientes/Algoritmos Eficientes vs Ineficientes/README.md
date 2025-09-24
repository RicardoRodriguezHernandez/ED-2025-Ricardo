# Algoritmos Eficientes vs Ineficientes

Ejercicio 1: Comparación de Búsquedas (Lineal vs Binaria)

1.1: Tiempos de Ejecución

| Tamaño | Búsqueda Lineal (s) | Búsqueda Binaria (s) | Ratio (Lineal/Binaria) |
|--------|--------------------|---------------------|------------------------|
| 1.000  | 0.00007095         | 0.00003176          | 2.2339                 |
| 10.000 | 0.00043144         | 0.00050752          | 0.8501                 |
| 50.000 | 0.00229719         | 0.00159929          | 1.4364                 |
| 100.000| 0.00366151         | 0.00371540          | 0.9855                 |

## Ejercicio 2: Comparación de Ordenamientos (Bubble Sort vs Python `sorted`)

### 2.1: Evaluación de Rendimiento

| Dimensión | Bubble Sort (s) | Merge Sort (s) | Observaciones |
|-----------|----------------|----------------|---------------|
| 100       | 0.001197       | 0.000192       | -             |
| 500       | 0.014232       | 0.000952       | -             |
| 1.000     | 0.058626       | 0.001949       | A partir de 1000 elementos, Bubble Sort empieza a costar mucho más. |
| 5.000     | 1.463795       | 0.012631       | -             |
| 10.000    | 5.791174       | 0.044770       | -             |

2.2: Análisis de Casos Específicos

| Escenario      | Bubble Sort (s) | Merge Sort (s) | Observaciones |
|----------------|----------------|----------------|---------------|
| Ordenado       | 0.034672       | 0.000490       | Bubble Sort aún consume tiempo; Merge Sort lo resuelve mucho más rápido. |
| Inverso        | 0.064684       | 0.000442       | Bubble Sort sigue lento; Merge Sort rápido incluso con lista invertida. |
| Casi ordenado  | 0.029197       | 0.000688       | Bubble Sort mejora un poco; Merge Sort sigue siendo muy rápido. |

Ejercicio 3: Fibonacci Recursivo vs Iterativo

3.1: Tiempos de Cálculo

| n       | Fibonacci Recursivo (s) | Iterativo (s) | Observaciones |
|---------|------------------------|---------------|---------------|
| 5       | 0.000007               | 0.000005      | Diferencia mínima en listas pequeñas. |
| 10      | 0.000026               | 0.000012      | Recursivo empieza a tardar un poco más. |
| 20      | 0.002234               | 0.000009      | Método recursivo tarda mucho más con listas medianas. |
| 30      | 0.170941               | 0.000009      | Iterativo mucho más eficiente que recursivo. |
| 35      | 3.287438               | 0.000024      | Iterativo sigue siendo más rápido en listas grandes. |

3.2: Límites Prácticos

- **Recursivo:** límite práctico n ≈ 40  
- **Iterativo:** puede calcular hasta n ≈ 65.536 en 30s

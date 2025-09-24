import random
import time

#Bubble sort 0 (n^2)-Ineficiente
def bubble_sort(lista):
    n = len(lista)
    for i in range(n):
        for j in range(0, n-i-1):
            if lista[j] > lista[j+1]:
                lista[j], lista[j+1] = lista[j+1], lista[j]
    return lista

dimensiones_ordenamiento = [100, 500, 1000]

for n in dimensiones_ordenamiento:
    # 1. Generar secuencia aleatoria de elementos únicos
    secuencia = random.sample(range(n*10), n)

    # 3. Medir tiempo de ejecución completo
    copia_bubble = secuencia.copy()
    inicio = time.time()
    resultado_bubble = bubble_sort(copia_bubble)
    fin = time.time()
    tiempo_bubble = fin - inicio

    # 4. Verificar ordenación
    correcto_bubble = resultado_bubble == sorted(secuencia)

    print(f"\n--- Dimensión: {n} ---")
    print(f"Bubble Sort -> {tiempo_bubble:.6f}s | Correcto: {correcto_bubble}")

    secuencia_ordenada = list(range(1000))
secuencia_inversa = list(range(1000, 0, -1))
secuencia_casi_ordenada = [x if x % 100 != 0 else x+500 for x in range(1000)]

casos = {
    "Ordenada": secuencia_ordenada,
    "Inversa": secuencia_inversa,
    "Casi ordenada": secuencia_casi_ordenada
}

for nombre, secuencia in casos.items():
    # Bubble Sort
    copia_bubble = secuencia.copy()
    inicio = time.time()
    resultado_bubble = bubble_sort(copia_bubble)
    fin = time.time()
    tiempo_bubble = fin - inicio

    print(f"\n--- Caso: {nombre} ---")
    print(f"Bubble Sort -> {tiempo_bubble:.6f}s")

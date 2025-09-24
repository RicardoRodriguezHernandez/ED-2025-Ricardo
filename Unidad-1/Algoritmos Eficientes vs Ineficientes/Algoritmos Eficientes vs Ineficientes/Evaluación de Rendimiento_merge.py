import random
import time

#Merge Sort 0(n log n)-Eficiente
def merge_sort(lista):
    if len(lista) <= 1:
        return lista
    medio = len(lista) // 2
    izquierda = merge_sort(lista[:medio])
    derecha = merge_sort(lista[medio:])
    return merge(izquierda, derecha)

def merge (izquierda, derecha):
    resultado = []
    i = j = 0

#Combina las dos listas ordenadas
    while i < len(izquierda) and j < len(derecha):
        if izquierda[i] < derecha[j]:
            resultado.append(izquierda[i])
            i += 1
        else:
            resultado.append(derecha[j])
            j += 1
            #Añade los elementos restantes
    resultado.extend(izquierda[i:])
    resultado.extend(derecha[j:])
    return resultado
    return lista

dimensiones_ordenamiento = [100, 500, 1000]

for n in dimensiones_ordenamiento:
    # 1. Generar secuencia aleatoria de elementos únicos
    secuencia = random.sample(range(n*10), n)

    # 3. Medir tiempo de ejecución completo
    inicio = time.time()
    resultado_merge = merge_sort(secuencia.copy())
    fin = time.time()
    tiempo_merge = fin - inicio

    # 4. Verificar ordenación
    correcto_merge = resultado_merge == sorted(secuencia)

    print(f"\n--- Dimensión: {n} ---")
    print(f"Merge Sort -> {tiempo_merge:.6f}s | Correcto: {correcto_merge}")

    secuencia_ordenada = list(range(1000))
secuencia_inversa = list(range(1000, 0, -1))
secuencia_casi_ordenada = [x if x % 100 != 0 else x+500 for x in range(1000)]

casos = {
    "Ordenada": secuencia_ordenada,
    "Inversa": secuencia_inversa,
    "Casi ordenada": secuencia_casi_ordenada
}

for nombre, secuencia in casos.items():
    # Merge sort
    inicio = time.time()
    resultado_merge = merge_sort(secuencia.copy())
    fin = time.time()
    tiempo_merge = fin - inicio

    correcto_merge = resultado_merge == sorted(secuencia)

    print(f"\n--- Caso: {nombre} ---")
    print(f"Merge Sort -> {tiempo_merge:.6f}s")
#Busqueda en Lista Ordenada
#Binaria

import time
import random

def busqueda_binaria(lista, objetivo):
    izquierda, derecha = 0, len(lista) - 1
    while izquierda <= derecha:
        medio = (izquierda + derecha) // 2
        if lista[medio] == objetivo:
            return medio
        elif lista[medio] < objetivo:
            izquierda = medio + 1
        else:
            derecha = medio - 1
    return -1

if __name__ == "__main__":
    tamanos = [1000, 10000, 50000, 100000]
    num_pruebas = 10  # 5 existentes + 5 no existentes

for n in tamanos:
    # 1. Generar lista ordenada
    lista = list(range(n))  # lista ordenada de 0 a n-1

    # 2. Elegir elementos para buscar
    existentes = random.sample(lista, 5)     # 5 que sí existen
    no_existentes = [n + i for i in range(1, 6)]  # 5 que no existen
    pruebas = existentes + no_existentes

    # 3. Medir tiempo promedio
    tiempos = []
    print(f"\n--- Tamaño de lista: {n} ---")
    for objetivo in pruebas:
        inicio = time.time()
        resultado = busqueda_binaria(lista, objetivo)
        fin = time.time()
        tiempos.append(fin - inicio)

        # Imprimir numeros existentes y no existentes
        if resultado != -1:
            print(f"Número {objetivo} encontrado en posición {resultado}")
        else:
            print(f"Número {objetivo} NO encontrado")

    tiempo_promedio = sum(tiempos) / num_pruebas
    print(f"Tiempo promedio de busqueda: {tiempo_promedio:.8f} segundos\n")
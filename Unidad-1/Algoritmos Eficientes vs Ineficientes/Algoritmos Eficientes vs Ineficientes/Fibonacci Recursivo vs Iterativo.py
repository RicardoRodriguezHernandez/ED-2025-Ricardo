#3.1: Tiempos de Cálculo

# Versión recursiva O(2^n) - muy ineficiente
def fib_recursivo(n):
    if n <= 1:
        return n
    return fib_recursivo(n-1) + fib_recursivo(n-2)


# Versión iterativa O(n)
def fib_iterativo(n):
    """Implementación iterativa O(n)"""
    if n <= 1:
        return n
    a, b = 0, 1
    for _ in range(2, n+1):
        a, b = b, a + b
    return b


# Versión con memoization O(n)
def fib_memoization(n, memo=None):
    """BONUS: Implementación con memoization O(n)"""
    if memo is None:
        memo = {}
    if n in memo:
        return memo[n]
    if n <= 1:
        memo[n] = n
    else:
        memo[n] = fib_memoization(n-1, memo) + fib_memoization(n-2, memo)
    return memo[n]

import time

valores_n = [5, 10, 20, 30, 35]

for n in valores_n:
    # Medir tiempo versión recursiva
    inicio = time.time()
    resultado_rec = fib_recursivo(n)
    fin = time.time()
    tiempo_rec = fin - inicio

    # Medir tiempo versión iterativa
    inicio = time.time()
    resultado_itr = fib_iterativo(n)
    fin = time.time()
    tiempo_itr = fin - inicio

    # Medir tiempo versión memoization
    inicio = time.time()
    resultado_memo = fib_memoization(n)
    fin = time.time()
    tiempo_memo = fin - inicio

    # Verificar que todos den el mismo resultado
    correcto = resultado_rec == resultado_itr == resultado_memo

    print(f"\n--- n = {n} ---")
    print(f"Recursivo: {resultado_rec} | Tiempo: {tiempo_rec:.6f} s")
    print(f"Iterativo: {resultado_itr} | Tiempo: {tiempo_itr:.6f} s")
    print(f"Memoization: {resultado_memo} | Tiempo: {tiempo_memo:.6f} s")
    print(f"Todos correctos: {correcto}")

    #Cersion iterativa 0(n)- eficiente
def fib_dinamico(n):
    if n <= 1:
        return n
    a, b = 0, 1
    for _ in range(2, n + 1):
        a, b = b, a + b
    return b

import time

valores_n = [5, 10, 20, 30, 35]

for n in valores_n:
    # Medir tiempo versión recursiva
    inicio = time.time()
    resultado_rec = fib_recursivo(n)
    fin = time.time()
    tiempo_rec = fin - inicio

    # Medir tiempo versión iterativa
    inicio = time.time()
    resultado_itr = fib_iterativo(n)
    fin = time.time()
    tiempo_itr = fin - inicio

    # Medir tiempo versión memoization
    inicio = time.time()
    resultado_memo = fib_memoization(n)
    fin = time.time()
    tiempo_memo = fin - inicio

    # Verificar que todos den el mismo resultado
    correcto = resultado_rec == resultado_itr == resultado_memo

    print(f"\n--- n = {n} ---")
    print(f"Recursivo: {resultado_rec} | Tiempo: {tiempo_rec:.6f} s")
    print(f"Iterativo: {resultado_itr} | Tiempo: {tiempo_itr:.6f} s")
    print(f"Memoization: {resultado_memo} | Tiempo: {tiempo_memo:.6f} s")
    print(f"Todos correctos: {correcto}")


# 3.2: Límites Prácticos

    import time

# Versión recursiva
def fib_recursivo(n):
    if n <= 1:
        return n
    return fib_recursivo(n-1) + fib_recursivo(n-2)

# Versión iterativa (dinámica)
def fib_dinamico(n):
    if n <= 1:
        return n
    a, b = 0, 1
    for _ in range(2, n + 1):
        a, b = b, a + b
    return b

# --- Recursivo ---
n = 0
while True:
    if n > 40:  # límite práctico para la versión recursiva
        print("Recursivo: límite n = 40 alcanzado")
        break
    inicio = time.time()
    fib_recursivo(n)
    fin = time.time()
    if fin - inicio > 30:
        print(f"Recursivo: Máximo n calculable en <30s: {n-1}")
        break
    n += 1

# --- Iterativo ---
n = 1
while n <= 100000:  # límite práctico para la versión iterativa
    inicio = time.time()
    fib_dinamico(n)
    fin = time.time()
    if fin - inicio > 30:
        print(f"Iterativo: Máximo n calculable en <30s: {n-1}")
        break
    n *= 2  # doblamos n cada vez para acelerar la prueba
else:
    print(f"Iterativo: Puede calcular hasta n={n//2} en <30s")
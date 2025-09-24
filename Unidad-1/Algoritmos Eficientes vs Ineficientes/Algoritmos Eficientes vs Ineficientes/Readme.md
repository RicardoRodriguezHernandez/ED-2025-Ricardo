#Algoritmos Eficinetes vs Ineficientes 

Ejercicio 1: Comparación de Búsquedas (Lineal vs Binaria)
1.1: Tiempos de Ejecución

Tamaño	     Búsqueda Lineal (s)	 Búsqueda Binaria (s)	 Ratio (Lineal/Binaria)
1,000	 	 	   0.00007095 segundos   0.00003176 segundos         2.233942065
10,000	 	 	 0.00043144 segundos   0.00050752 segundos         0.8500945776
50,000	 	 	 0.00229719 segundos   0.00159929 segundos         1.436381144
100,000	 	 	 0.00366151 segundos   0.00371540 segundos         0.9854955052

Ejercicio 2: Comparación de Ordenamientos (Bubble Sort vs Python sorted)
2.1: Evaluación de Rendimiento
Dimensión	  Bubble Sort (s)	  Merge Sort (s)	  Relación BS/MS
100	 	 	    0.001197s         0.000192s         ninguna. 
500	 	 	    0.014232s         0.000952s         ninguna. 
1,000	 	 	  0.058626s         0.001949s         aqui ya demuestra que los programas con un
                                                total de 1000 nuevos les empieza a costar aun mas, 
                                                principalmente al bubblr sort. 
5,000	 	 	  1.463795s         0.012631s         ninguna.       
10,000      5.791174s         0.044770s         ninguna. 

2.2: Análisis de Casos Específicos
Escenario	      Bubble Sort (s)	  Merge Sort (s)	  Observaciones
Ordenado	 	 	  0.034672s         0.000490s         Bubble sort aun con una lista ordena le llega a costar al de tiempo
                                                    pero el marge sort lo resolvio sin muchos problemas y en un tiempo mucho
                                                    mas corto.
Inverso	 	 	    0.064684s         0.000442s         Le sigue costando y aun mas estando todo invertido, quizas no llego a un 1 segundo 
                                                    pero sigue demostrando como marge lo hace mas rapido y facil aun con toda la lista 
                                                    invertida.
Casi ordenado   0.029197s         0.000688s         quizas aqui el metodo llego a tardar un poco mas, pero sigue siendo muy poco tiempo 
                                                    a comparacion del bubble sort que al menos en esta situacion le fue un poco mejor.

Ejercicio 3: Fibonacci Recursivo vs Iterativo
3.1 Tiempos de Cálculo
Tabla de Resultados:
 
n	   Fibonacci	  Recursivo (s)	  Iterativo (s)	  Diferencia
5	   5	 	 	      0.000007s       0.000005s       cuando se trata de una lista pequeña, la diferencia no puede ser mucha.
10	 55	 	 	      0.000026s       0.000012s       ya al metodo recursivo le toma un poquito mas de tiempo que el metodo iterativo.
20	 6765	 	 	    0.002234s       0.000009s       aqui es donde el metodo recursivo empieza a tardar un poco demas con listas mas grandes de 10,
                                                  mientras que el metodo iterativo logra seguir teneindo un tiempo mas pequeño con facilidad.  
30	 832040	 	 	  0.170941s       0.000009s       aqui ya deplanpo nos muentran porque el metodo iterativo es mejor que el recursico.
35	 9227465      3.287438s       0.000024s       y con esto nos afirma que el metodod iterativo con listas mas grandes aun sigue siendo mas eficiente que 
                                                  que el metodo recursivo, mientras que este mismo llega a tomas aun mas tiempo para solucionar este problema.

3.2: Límites Prácticos
Recursivo: límite n = si alcanza los 40 
Iterativo: Puede calcular hasta n = 65536 en 30s

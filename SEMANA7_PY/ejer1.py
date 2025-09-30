p = i = 0

while True:
    num = int(input("Ingrese un número entero (negativo para salir): "))

    if num < 0:break
    if num % 2 == 0: p+= 1
    else: i += 1

print("\nCantidad de pares: ",p)
print("Cantidad de impares: ",i)
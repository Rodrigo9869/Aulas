num = int(input("Número: "))
contador = 0

for i in range(1, num + 1):
    if num % i == 0:
        contador += 1

print("Divisores:", contador)
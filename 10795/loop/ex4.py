num = int(input("Número: "))
divisores = 0

for i in range(1, num + 1):
    if num % i == 0:
        divisores += 1

if divisores == 2:
    print("Primo")
else:
    print("Não é primo")
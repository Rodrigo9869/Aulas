pares = 0
impares = 0
num = 1

while pares < 30 or impares < 30:
    if num % 2 == 0 and pares < 30:
        print("Par:", num)
        pares += 1
    elif num % 2 != 0 and impares < 30:
        print("Ímpar:", num)
        impares += 1
    num += 1
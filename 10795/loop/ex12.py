num = int(input("Número: "))
contador = 0

for i in range(1, num):
    soma = num + i
    sub = num - i
    mult = num * i
    div = num / i
    
    contador += 4

print("Total de operações:", contador)
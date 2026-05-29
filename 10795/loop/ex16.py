soma = 0
contador = 0

while contador < 30:
    num = int(input("Número (1-50): "))
    
    if 1 <= num <= 50 and num % 2 == 0:
        soma += num
        contador += 1
    else:
        print("Inválido")

media = soma / 30
print("Média:", media)
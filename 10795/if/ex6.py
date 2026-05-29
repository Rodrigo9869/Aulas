nome = input("Nome: ")
compra = float(input("Valor da compra: "))

if compra <= 200:
    desconto = compra * 0.10
elif compra <= 500:
    desconto = compra * 0.15
else:
    desconto = compra * 0.20

total = compra - desconto

print("Nome:", nome)
print("Compra:", compra)
print("Desconto:", desconto)
print("Total a pagar:", total)
n1 = int(input("Num1: "))
n2 = int(input("Num2: "))
n3 = int(input("Num3: "))

# Crescente
if n1 <= n2 and n1 <= n3:
    if n2 <= n3:
        print("Crescente:", n1, n2, n3)
    else:
        print("Crescente:", n1, n3, n2)
elif n2 <= n1 and n2 <= n3:
    if n1 <= n3:
        print("Crescente:", n2, n1, n3)
    else:
        print("Crescente:", n2, n3, n1)
else:
    if n1 <= n2:
        print("Crescente:", n3, n1, n2)
    else:
        print("Crescente:", n3, n2, n1)

# Decrescente (invertido)
if n1 >= n2 and n1 >= n3:
    if n2 >= n3:
        print("Decrescente:", n1, n2, n3)
    else:
        print("Decrescente:", n1, n3, n2)
elif n2 >= n1 and n2 >= n3:
    if n1 >= n3:
        print("Decrescente:", n2, n1, n3)
    else:
        print("Decrescente:", n2, n3, n1)
else:
    if n1 >= n2:
        print("Decrescente:", n3, n1, n2)
    else:
        print("Decrescente:", n3, n2, n1)
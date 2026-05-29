soma = 0
notas = []

for i in range(10):
    nota = float(input(f"Nota {i+1}: "))
    notas.append(nota)
    soma += nota

media = soma / 10
contador = 0

for n in notas:
    if n >= media:
        contador += 1

print("Média:", media)
print("Alunos acima ou iguais à média:", contador)
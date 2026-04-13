dado = input("Digite um tipo de dado: ")

match dado:
    case 1:
        print("Número Inteiro")
    case 2:
        print("Número decimal")
    case 3:
        print("String Numérica")
    case 4:
        print("String Textual")
    case 5:
        print("Lista")
    case _:
        print("Tipo desconhecido")
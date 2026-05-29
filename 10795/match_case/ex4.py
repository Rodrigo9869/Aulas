dado = input("Digite um tipo de dado: ")

match dado:
    case int():
        print("Número Inteiro")
    case float():
        print("Número decimal")
    case str() if str.isnumeric():
        print("String Numérica")
    case str():
        print("String Textual")
    case list():
        print("Lista")
    case _:
        print("Tipo desconhecido")

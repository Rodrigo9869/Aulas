nota = int(input("Nota: "))

match nota:
    case n if 100 >= n >= 90:
        print("Excelente")
    case n if 70 <= n <= 89:
        print("Bom")
    case n if 50 <= n <= 69:
        print("Suficiente")
    case n if n > 100:
        print("Nota excedida")
    case _:
        print("Insuficiente")
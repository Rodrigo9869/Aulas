tipo = input("Tipo(compra/venda): ").lower()
#valor = int(input("Valor: "))

match tipo:
    case "compra":
        print("Compra de 250€")
    case "venda":
        print("venda de 250€")
    case _:
        print("Pedido Desconhecido")

'''   
pedido = {"tipo": "venda", "valor": 250}

match pedido:
    case {"tipo": "compra", "valor": v}:
        print(f"Compra de {v}€")
    case {"tipo": "venda", "valor": v}:
        print(f"Venda de {v}€")
    case _:
        print("Pedido desconhecido")
'''
tipo = input("Tipo(compra/venda): ").lower()
#valor = int(input("Valor: "))

match tipo:
    case "compra":
        print("Compra de 250€")
    case "venda":
        print("venda de 250€")
    case _:
        print("Pedido Desconhecido")
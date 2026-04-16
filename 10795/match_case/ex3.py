dados = {
    "tipo": input("Tipo (compra/venda): ").lower(),
    "valor": float(input("Valor: "))
}

match dados:
    case {"tipo": "compra", "valor": v}:
        print("Compra de ",v)
    case {"tipo": "venda", "valor": v}:
        print("venda de ",v)
    case _:
        print("Pedido Desconhecido")

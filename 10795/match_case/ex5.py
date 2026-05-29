msg = input("Digite alguma coisa: ").lower()

match msg:
    case "ola" | "bom dia":
        print("Saudação")
    case "?":
        print("Pergunta")
    case "tchau" | "Adeus":
        print("Despedida")
    case _:
        print("Mensagem genérica")

'''
msg = input("Mensagem: ").lower()

match msg:
    case "olá" | "ola" | "bom dia":
        print("Saudação")
    case m if m.endswith("?"):
        print("Pergunta")
    case m if "tchau" in m or "adeus" in m:
        print("Despedida")
    case _:
        print("Mensagem genérica")
'''
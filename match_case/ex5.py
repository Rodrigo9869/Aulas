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
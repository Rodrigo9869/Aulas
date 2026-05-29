for i in range(0, 256):
    print(i, "->", chr(i))
    
    if i % 20 == 0 and i != 0:
        op = input("Continuar? (s/n): ")
        if op.lower() != "s":
            break
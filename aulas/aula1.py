import requests as rex

comeco = int(input("Insira o número para começar: "))
fim = int(input("Insira o número para terminar: "))
sessao = int(input("Desejas achar um Formando (digite '1') ou Formador (digite '2')? "))
primeironome = input("Insira o primeiro nome: ")
ultimonome= input("Insira o ultimo nome: ")

for i in range(comeco,fim,1):
    request=rex.get(f"https://trainingserver.atec.pt/TrainingServer/Mulberry/JSON/Controls/Calendar/getCalendarDataSource.ashx?command=_SelectAllSchedulesDataSetGivenByUserId&oId={i}&idField=DataValueField&titleField=DataTextField&startDateField=DataStartField&endDateField=DataEndField&backgroundColorField=&textColorField=textcolor&eventColorField=color&description=description&picField=pic&urlField=url&start=1771804800&end=1772409600&_=1771937452532")


    if sessao == 1:
        if primeironome in request.text and ultimonome in request.text and "Sessão como Formando" in request.text:
            print(f"Nome encontrado para o id {i}: {primeironome} {ultimonome}")
            break
        else:              
            print(f"ID {i}: Nome não encontrado.")

    if sessao == 2:
        if primeironome in request.text and ultimonome in request.text and "Sessão como Formador" in request.text:
            print(f"Nome encontrado para o id {i}: {primeironome} {ultimonome}")
            break
        else:              
            print(f"ID {i}: Nome não encontrado.")
def ejer1():
    edad = int(input("Ingrese su edad: "))

    if edad >= 18:
        print("Puede votar.")

        if edad >=25:
            print("Candidato para un cargo politico")
        else:
            print("No es candidato para un cargo politico")
    else:
        print("No puede votar.")
        print("No puede ejercer un cargo politico.")



ejer1()
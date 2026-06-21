def number1():
    while True:
        try:
            a = int(input(f'enter a integer: '))
        except ValueError:
            print("try again")
            continue
        break
    return a
def number2():
    while True:
        try:
            b = float(input(f'Enter a float number: '))
        except ValueError:
            print("try again")
            continue
        break
    return b
def number3():
    while True:
        try:
            c = int(input(f'Enter a int number: '))
        except ValueError:
            print("try again")
            continue
        if c > 120:
            print(f'This int can be bigger then 120')
            continue
        else:
            break
    return c
def number4():
    while True:
        try:
            d = float(input(f'Enter a float number: '))
        except ValueError:
            print("try again")
            continue
        if d > 120:
            print(f'This float can\'t be bigger then 120')
            continue
        else:
            break
    return d
def number5():
    while True:
        try:
            e = int(input(f'Enter a int number: '))
        except ValueError:
            print("try again")
            continue
        if e > 120 or e < 50:
            print(f'This int can be bigger then 120 or smaller then 50')
            continue
        else:
            break
    return e
def number6():
    while True:
        try:
            f = float(input(f'Enter a float number: '))
        except ValueError:
            print("try again")
            continue
        if f > 120 or f < 50:
            print(f'This float can\'t be bigger then 120 or smaller then 50')
            continue
        else:
            break
    return f
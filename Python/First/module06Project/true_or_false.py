def true_false():
    while True:
        a = input(f'True or false: the sky is red (you can abbreviate) ')
        if a.lower() == "true" or a.lower() == "t":
            print(f'nope its not')
            break
        if a.lower() == "false" or a.lower() == "f":
            print(f'The is true')
            break
        else:
            print('Enter true of false you (can abbreviate)')
            continue
def yes_or_no():
    while True:
        b = input(f'yes or no: the sun is white? (you can abbreviate) ')
        if b.lower() == "yes" or b.lower() == "y":
            print(f'That is true')
            break
        if b.lower() == "no" or b.lower() == "n":
            print(f'nope that wrong')
            break
        else:
            print('Enter yes or no (you can abbreviate)')
            continue
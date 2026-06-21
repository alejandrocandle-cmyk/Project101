def pick_one():
    while True:
        list = ['red', 'blue', 'green']
        answer = input(f'What color do you want red, blue or green')
        if answer.lower() in list:
            print(f'You picked {answer}')
            break
        else:
            print(f'try again pick red, blue or green don\'t worry about uppercase  ')
            continue
def pick_two():
    while True:
        list = ['Red', 'Blue', 'Green']
        answer = input(f'What color do you want Red, Blue or Green')
        if answer in list:
            print(f'You picked {answer}')
            break
        else:
            print(f'try again spell it right')
            continue
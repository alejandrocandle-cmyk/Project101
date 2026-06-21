print(f'Let play a little a game')

print(f'You are stuck in a zombie apocalypse make the best choices to survive')
input(f'Press enter to continue ')

print(f'You are walking around and need a place to sleep, night fall is near pick one(type the number)')
choice1 = 0
choice2 = 0
choice3 = 0
choice4 = 0
choice5 = 0
choice6 = 0
final = 0
while True:
    print(f'1: House')
    print(f'2: Grocery Store')
    print(f'3: Mall')
    choice1 = int(input(f''))
    if choice1 == 1:
        print(f'You made through the night with some food you found')
        input(f'Press enter to continue ')
        break
    elif choice1 == 2:
        print(f'You made through the night but all the food was taken')
        input(f'Press enter to continue ')
        break
    elif choice1 == 3:
        print(f'The Mall was locked and you got hurt fighting a zombie in the middle of the night')
        input(f'Press enter to continue ')
        choice5 = 1
        break
    else:
        print(f'Pick a right number!!!')
        continue

print(f'You went back on the road and found care package')
print(f'It had a Gun with 8 rounds in it and a map to a city with survivors')
choice4 = 8
input(f'Press enter to continue ')
print(f'While walking to the city a big horde of zombies found you(type the number')
while True:
    print(f'1: Make a Run for it')
    print(f'2: Try to hide')
    print(f'3: Shoot at them')
    choice2 = int(input(f''))
    if choice2 == 1:
        if choice5 == 1:
            print(f'You can\'t run far because you are hurt')
            print(f'You Died')
            exit()
        elif choice5 == 0:
            print(f'You found a big building in front of where you need to go')
            break
    elif choice2 == 2:
        print(f'They pass you but they stayed there for while so you sneak around them')
        print(f'You found a big building in front of where you need to go')
        break
    elif choice2 == 3:
        print(f'There is to many of them so you ran for it but used all your ammo')
        print(f'You found a big building in front of where you need to go')
        choice4 = 0
        break
    else:
        print(f'Pick a right number!!!')
        continue

input(f'Press enter to continue')

while True:
    print(f'1: Go inside the building? or 2: Go around?')
    choice3 = int(input(f''))
    if choice3 == 1:
        print(f'The building is dark but you found a flashlight continue')
        break
    elif choice3 == 2:
        print(f'The build was to big and you could\'t get around in time and the horde of zombies got you')
        print(f'You Dead')
        exit()
    else:
        print(f'Pick a right number!!!!')
        continue

input(f'Press enter to continue')
print(f'You where walking and then a zombies jumps on you')

if choice5 == 1:
    print(f'Your hurt so you use a round but then all the other zombies heard')
    print(f'RUNNNN!!!!')
    choice4 = choice4 - 1
    choice6 = 1
elif choice5 == 0:
    print(f'You fought it off but got it bites you so you hurry up out of the building')
    choice6 = 2
input(f'Press enter to continue ')
print(f'the exit was locked')
while True:
    print(f'1: shoot the lock? 2: try to pull it off?')
    final = int(input(f''))
    if final == 1:
        print(f'it open')
        choice4 = choice4 - 2
        break
    elif final == 2:
        print(f'it open')
        break

input(f'Press enter to continue ')
print(f'You got out but the horde of zombies was waiting for you')

if choice4 <= 7:
    print(f'you go down fighting but then people pulled up with a car and '
          f'run over the zombies and took you to the city')
    if choice6 == 2:
        print(f'They saw you, they bite and kicked you out')
        print(f'GAME OVER')
        exit()
    else:
        print('you lived GAME over :)')
        exit()
if choice4 >= 7:
    print(f'You didn\'t have enough ammo')
    print(f'GAME OVER')
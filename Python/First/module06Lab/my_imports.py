# Alejandro Garcia
# module06 Lab assignment
# This code imports code from the same file but makes sure that each part of the code is called on right
#
#
# add header block at top of file

# Add import and/or from statement(s) here
import emcc
import teams.broncos
import teams.cardinals as c
from emcc import team_name
from emcc import print_key_figure
from teams.broncos import best_team
# Do not edit go_team()
def go_team():
    print('Go Suns!')

# Do not edit main()
def main():
    print('1: ', end='')
    print(team_name) 
    print('2: ', end='')
    go_team()
    print('3: ', end='')
    emcc.go_team()
    print('4: ', end='')
    c.go_team() 
    print('5: ', end='')
    print_key_figure()
    print('6: ', end='')
    teams.broncos.best_team()
    print('7: ', end='')
    best_team()
 
# Edit below this line to have main() execute based on __name__ 
if __name__ == '__main__':
    main()
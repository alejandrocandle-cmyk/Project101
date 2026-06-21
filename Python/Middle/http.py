# this code find a sock from an URL but it checks if the URL has a http:// and if it doesn't it add
# it to the url for them but if it does have it nothing happens




import socket

mysock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
mysock.connect(('data.pr4e.org', 80))

user_url = input(f'Enter a URL: ')

if user_url[:8] != 'http://':
    http = 'http://'
    user_url = http + user_url

cmd = f'GET {user_url} HTTP/1.0\r\n\r\n'.encode()
mysock.send(cmd)

while True:
    data = mysock.recv(512)
    if len(data) < 1:
        break
    print(data.decode(),end='')

mysock.close()

# Code: https://www.py4e.com/code3/socket1.py

# http://data.pr4e.org/romeo.txt
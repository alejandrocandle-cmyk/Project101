import requests
from bs4 import BeautifulSoup

def print_unicode_grid(doc_url: str):
    response = requests.get(doc_url)
    response.raise_for_status()

    soup = BeautifulSoup(response.text, "html.parser")

    grid = {}
    max_x = 0
    max_y = 0

    # Google Docs tables → rows in <tr>
    rows = soup.find_all("tr")

    for row in rows:
        cols = row.find_all("td")

        if len(cols) != 3:
            continue

        try:
            x = int(cols[0].get_text(strip=True))
            char = cols[1].get_text(strip=True)
            y = int(cols[2].get_text(strip=True))
        except:
            continue

        grid[(x, y)] = char
        max_x = max(max_x, x)
        max_y = max(max_y, y)

    for y in range(max_y + 1):
        print("".join(grid.get((x, y), " ") for x in range(max_x + 1)))


print_unicode_grid("https://docs.google.com/document/d/e/2PACX-1vSvM5gDlNvt7npYHhp_XfsJvuntUhq184By5xO_pA4b_gCWeXb6dM6ZxwN8rE6S4ghUsCj2VKR21oEP/pub")
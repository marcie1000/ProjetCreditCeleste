import requests
from bs4 import BeautifulSoup
import random
import re
from enum import Enum

class Voiture:
    marque = "marque"
    modele = "modele"
    moteur = 0

class Moteur:
    carburant = 0
    nom = "nom"
    puissance = 0

class Carburant(Enum):
    ESSENCE = "Essence"
    DIESEL = "Diesel"
    ELECTRIQUE = "Electrique"
    HYBRIDE = "Hybride"
    INCONNU = 0

class TableParser:
    colonneNb = 0
    color = ""
    colspan = 1
    nomMoteur = ""
    puissance = ""


voitures = []

response = requests.get(
    url="https://fr.wikipedia.org/wiki/Volkswagen_Golf_VII#Motorisation",
)
soup = BeautifulSoup(response.content, 'html.parser')

title = soup.find(id="firstHeading")
print(title.text)

# Get motorisation
h3Moto = soup.find(id=re.compile(r"^[Mm]otorisations"))
print(h3Moto)
nextSection = h3Moto.find_next(class_="mw-heading mw-heading2")

between = h3Moto.find_all_next()
i = 0
while between[i] != nextSection:
    i += 1
between = between[:i]

tables = []

for tag in between:
    if tag.has_attr("class") and tag["class"][0] == 'wikitable':
        tables.append(tag)

for table in tables:
    motors = ""
    for tag in table.find_all("tr"):
        # breakpoint()
        if str(tag).find("background:#32CD32") != -1 or str(tag).find("background:#0080FF") != -1 or str(tag).find("background:#FFFF00") != -1:
            motors = tag

    columns = []
    i = 0
    for tag in motors.find_all(re.compile(r"t[dh]")):
        if(tag.text != ""):
            col = TableParser()
            col.colonneNb = i
            if tag.has_attr("style"):
                col.color = tag["style"]
            if tag.has_attr("colspan"):
                col.colspan = tag["colspan"]
            col.nomMoteur = tag.text
            columns.append(col)
        i += int(col.colspan)

    #TODO : plusieurs variations en fontion des années???
    pPattern = re.compile(r"[Pp]uissance")
    for tag in table.find_all("tr"):
        if re.search(pPattern, tag.text):
            # breakpoint()
            # print(tag)
            # input()
            i = 0
            sumColspan = 0
            for tag2 in tag.find_all("td"):
                colspan = 1
                columns[i].puissance = tag2.text
                if tag2.has_attr("colspan"):
                    colspan = int(tag2["colspan"])
                sumColspan += colspan
                if sumColspan >= columns[i].colonneNb + int(columns[i].colspan) and i < len(columns) - 1:
                    i += 1

    moteurs = []
    for col in columns:
        # print(col.nomMoteur, col.colonneNb, col.color, col.colspan, col.puissance, sep=";;")
        m = Moteur()
        m.nom = col.nomMoteur
        if(col.color == "background:#32CD32"): # vert
            m.carburant = Carburant.ESSENCE
        elif(col.color == "background:#0080FF"): # bleu
            m.carburant = Carburant.HYBRIDE
        elif(col.color == "background:#FFFF00"): # jaune
            m.carburant = Carburant.DIESEL
        else:
            m.carburant = Carburant.INCONNU
        m.puissance = col.puissance
        print(m.carburant, m.puissance, m.nom)
        moteurs.append(m)

    v = Voiture()
    sp = title.text.split()
    v.marque = sp[0]
    v.modele = ' '.join(sp[1:])

    print("marque : ", v.marque, "modèle :", v.modele)


# # breakpoint()
# for tag in h3Moto[0].find_all_next():
#     # if tag.has_attr("class") and tag["class"] == "mw-heading mw-heading2":
#     #     print("I've found on :\n", tag)
#     #     break

breakpoint()

# print(between)

# allLinks = soup.find(id="bodyContent").find_all("a")
# random.shuffle(allLinks)
# linkToScrape = 0

# for link in allLinks:
#     # We are only interested in other wiki articles
#     if link['href'].find("/wiki/") == -1:
#         continue

#     # Use this link to scrape
#     linkToScrape = link
#     break

# print(linkToScrape)

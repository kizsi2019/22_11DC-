
import spotipy
from spotipy.oauth2 import SpotifyClientCredentials
from pprint import pprint, pformat
import json  

client_secret = '8a6cf6ced01f492cbbf04f3789b19a41'
client_id = '3f7c2f734773444384f059e5e19470df'
# Itt már a Client Credential Manager a környezeti változókból
# olvassa ki a Client ID és Client Secret értékét.
sp = spotipy.Spotify(client_credentials_manager=SpotifyClientCredentials(client_id=client_id,client_secret=client_secret))
results = sp.search(q='csillag', limit=50, type='artist')
# A results szótárt csupán azért írjuk ki JSON fomátimban egy külön fájlba,
# hogy könnyebben vizsgálhassuk a belső strukturáját.   
with open('eredmeny.json', 'w') as kimenet_json:
    json.dump(results, kimenet_json, indent=2)
    
# Ez szolgál az előadók és datainak tárolására    
artists = results['artists']['items']

# Itt kérjük le az első 10 utáni eredményeket
limit = 10
index = 1
while results['artists']['next'] and index < limit:
    results = sp.next(results['artists'])
    artists.extend(results['artists']['items'])
    index += 1
    
print(len(artists))
for index, item in enumerate(artists):
    print(f'{index}: {item["name"]}, {item["popularity"]}')
    
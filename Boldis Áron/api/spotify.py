import spotipy
from spotipy.oauth2 import SpotifyClientCredentials
from pprint import pprint, pformat
import json  

client_id = '7ca72f3389c642cfb888e95873cede6e'
client_secret = 'ed87d7033d9f45f284a70c753e59ee10'

    # Itt már a Client Credential Manager a környezeti változókból
    # olvassa ki a Client ID és Client Secret értékét.
sp = spotipy.Spotify(client_credentials_manager=SpotifyClientCredentials(client_id=client_id, client_secret=client_secret))
results = sp.search(q='csillag', limit=50, type='artist')

    # A results szótárt csupán azért írjuk ki JSON fomátimban egy külön fájlba,
    # hogy könnyebben vizsgálhassuk a belső strukturáját.    
with open('eredmeny.json', 'w') as kimenet_json:
    json.dump(results, kimenet_json, indent=2)
    
artists = results['artists']['items']

limit = 10
index = 1
while results['artists']['next'] and index < limit:
    results = sp.next(results['artists'])
    artists.extend(results['artists']['items'])
    index += 1
    
print(len(artists))
for index, item in enumerate(artists):
    print(f'{index}: {item["name"]}, {item["popularity"]}')
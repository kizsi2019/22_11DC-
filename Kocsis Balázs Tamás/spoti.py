import spotipy
from spotipy.oauth2 import SpotifyClientCredentials
from pprint import pprint
import json

client_id = 'af33dcd8c57b441abdb4191f0cc0f919'
client_secret = 'aae21f0bd7de4af0b09a9d228f0779b0'
sp = spotipy.Spotify(client_credentials_manager=SpotifyClientCredentials(client_id=client_id, client_secret=client_secret))

result = sp.search(q='csillag', type='artist', limit=50)
#with open('eredmeny.json', 'w') as kimenet:
    #json.dump(result, kimenet, indent=2)

artists = result['artists']['items']

max_page = 10
index = 1
while result['artists']['next'] and index < max:
    result = sp.next(result['artists'])
    artists.extend(result['artists']['items'])
    index += 1

print(len(artists))
for index, item in enumerate(artists):
    print(f'{index}: {item["name"]}, {item["popularity"]}')

# SPOTIPY_CLIENT_ID='af33dcd8c57b441abdb4191f0cc0f919'
# SPOTIPY_CLIENT_SECRET='aae21f0bd7de4af0b09a9d228f0779b0'
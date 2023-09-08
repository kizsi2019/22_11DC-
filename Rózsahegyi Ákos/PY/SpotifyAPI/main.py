import spotipy
from spotipy.oauth2 import SpotifyClientCredentials

client_id = '0faadf6bd5f2417c9fdba7a5abf0a08d'
client_secret = 'b1d5c4e7d84d4c5cb1facd681643834c'
sp = spotipy.Spotify(client_credentials_manager=SpotifyClientCredentials(client_id=client_id, client_secret=client_secret))

result = sp.search(q='csillag', type='artist')
# with open('eredmeny.json', 'w') as kimenet_json:
    # json.dump(result, kimenet_json, indent=2)

artists = result['artists']['items']

max_page = 10
index = 1
while result['artists']['next'] and index < max_page:
    results = sp.next(result['artists'])
    artists.extend(result['artists']['items'])
    index += 1

print(len(artists))
for index, item in enumerate(artists):
    print(f'{index}: {item["name"]}, {item["popularity"]}')
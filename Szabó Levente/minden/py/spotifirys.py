import spotipy
from spotipy.oauth2 import SpotifyClientCredentials

client_id = '6rqhFgbbKwnb9MLmUQDhG6'
client_secret = '6rqhFgbbKwnb9MLmUQDhG6'
sp = spotipy.Spotify(client_credentials_manager=SpotifyClientCredentials(client_id=client_id, client_secret=client_secret))

sp.search()
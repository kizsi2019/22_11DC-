import spotipy
from spotipy.oauth2 import SpotifyClientCredentials

client_id = '0faadf6bd5f2417c9fdba7a5abf0a08d'
client_secret = 'b1d5c4e7d84d4c5cb1facd681643834c'
sp = spotipy.Spotify(client_credentials_manager=SpotifyClientCredentials(client_id=client_id, client_secret=client_secret))

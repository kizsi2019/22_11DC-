import spotipy
from spotipy.oauth2 import SpotifyClientCredentials

client_id = '64127561f70a424a907d3f350cac5617'
client_secret = '8379c695252840cba3a01be4bbc4b631'
sp = spotipy.Spotify(client_credentials_manager=SpotifyClientCredentials(client_id=client_id, client_secret=client_secret))

sp.search()
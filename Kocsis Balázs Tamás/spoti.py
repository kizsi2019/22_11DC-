import spotipy
from spotipy.oauth2 import SpotifyClientCredentials

client_id = 'af33dcd8c57b441abdb4191f0cc0f919'
client_secret = 'aae21f0bd7de4af0b09a9d228f0779b0'
sp = spotipy.Spotify(client_credentials_manager=SpotifyClientCredentials(client_id=client_id, client_secret=client_secret))

sp.search()
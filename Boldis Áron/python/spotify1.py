import spotipy
from spotipy.oauth2 import SpotifyClientCredentials

client_id = "7ca72f3389c642cfb888e95873cede6e"
client_secret = "ed87d7033d9f45f284a70c753e59ee10"

sp = spotipy.Spotify(client_credentials_manager=SpotifyClientCredentials(client_id=client_id, client_secret=client_secret))

sp.
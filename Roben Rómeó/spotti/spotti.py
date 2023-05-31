
import spotipy
from spotipy.oauth2 import SpotifyClientCredentials
from pprint import pprint, pformat
import json  
    
client_id='877d3f00c4d3480e87afc82de65d7ba1'
client_secret='a764dd7921e0432fa5e6f1bcf235a02c'
sp = spotipy.Spotify(client_credentials_manager=SpotifyClientCredentials())
results = sp.search(q='csillag', limit=50, type='artist')

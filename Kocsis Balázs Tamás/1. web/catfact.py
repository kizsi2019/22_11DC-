import requests
from pprint import pprint

resp = requests.get('https://catfact.ninja/facts')
macska_infok = resp.json()
pprint(macska_infok)
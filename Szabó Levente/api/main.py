import requests
from pprint import pprint

resp = requests.get('https://catfact.ninja/facts/')
macskainfo = resp.json()
for info in macskainfo['data']:
    print(info['fact'])
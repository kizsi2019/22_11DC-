import requests
from pprint import pprint

resp = requests.get('https://catfact.ninja/facts')
cat_datas = resp.json()
for info in cat_datas['data']:
    pprint('cat_datas')
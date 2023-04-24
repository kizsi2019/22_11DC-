import requests

resp = requests.get('https://catfact.ninja/facts')
macska_infok = resp.json()['fact']
print('fact')
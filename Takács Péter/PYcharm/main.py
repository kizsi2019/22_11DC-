import requests

resp = requests.get('https://webterkep.sulypy.hu/')
print(resp.text)
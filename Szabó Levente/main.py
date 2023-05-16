import requests
from pprint import pprint

#https://api.openweathermap.org/data/2.5/weather?lat=44.34&lon=10.99&appid=563dfc82427c5789270261df5afdc163

API_KEY = '563dfc82427c5789270261df5afdc163'
API_URL = 'https://home.openweathermap.org/data/2.5/weather'

payload = {'lat': 35, 'lon': 139,'appid': API_KEY}
resp = requests.get(API_URL, params=payload)
resp = resp.json()
pprint(resp)
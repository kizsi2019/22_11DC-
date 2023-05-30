import requests
from pprint import pprint

API_KEY = 'f66df4d66f933f1ae6ae2f1e2d6d13a3'
ONE_CALL_API = 'https://api.openweathermap.org/data/2.5/onecall'
GEOCODING_API = 'http://api.openweathermap.org/geo/1.0/direct'


def get_coordinates(city):
    geo_payload = {'q': city, 'appid': API_KEY}
    geo_resp = requests.get(GEOCODING_API, params=geo_payload)
    geo_resp = geo_resp.json()[0]
    return geo_resp['lat'], geo_resp['lon']


def get_weather(lat, lon):
    weather_payload = {'lat': lat, 'lon': lon,
                       'appid': API_KEY, 'units': 'metric', 'lang': 'hu'}
    weather_resp = requests.get(ONE_CALL_API, params=weather_payload)
    weather_resp = weather_resp.json()
    return weather_resp


def main():
    coordinates = get_coordinates('Budapest')
    weather = get_weather(coordinates[0], coordinates[1])
    pprint(weather)
    for i in range(8):
        a = weather['daily'][i]['weather'][0]['descrition']
        if 'eső' in a:
            print(f'Az {i}, nap {a}')


main()

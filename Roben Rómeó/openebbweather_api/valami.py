import requests
from pprint import pprint

API_KEY = 'ba90bdde34b41af55d498d88ad37935c'
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
        if 'enyhe eső' or 'közepes eső' in weather['daily'][i]['weather']['description'] < 10:
            print('Van benne e betű.')
        else:
            print('Nincs benne e betű.')


main()

pprint(main())
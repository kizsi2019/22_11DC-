import requests
from pprint import pprint

API_KEY = '4ec5aaba21784a224fe6cf52f6b11c08'
ONE_CALL_API = 'https://api.openweathermap.org/data/2.5/forecast'
GEOCODING_API = 'http://api.openweathermap.org/geo/1.0/direct'

def get_coordinates(city):
    geo_payload = {'q': city, 'appid': API_KEY}
    geo_resp = requests.get(GEOCODING_API, params=geo_payload)
    geo_resp = geo_resp.json()[0]
    return geo_resp['lat'], geo_resp['lon']

def get_weather(lat, lon):
    weather_payload = {'lat': lat, 'lon': lon, 'appid': API_KEY, 'units': 'metric', 'lang': 'hu'}
    weather_resp = requests.get(ONE_CALL_API, params=weather_payload)
    weather_resp = weather_resp.json()
    return weather_resp

def main():
    coordinates = get_coordinates('Budapest')
    weather = get_weather(coordinates[0], coordinates[1])
    pprint(weather)
    for forecast in weather['list']:
        a = forecast['weather'][0]['description']
        if 'eső' in a:
            print(f"Az időjárás előrejelzésben {forecast['dt_txt']}-kor eső várható.")

main()

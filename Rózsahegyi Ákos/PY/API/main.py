import requests

resp = requests.get("https://catfact.ninja/fact")
fact = resp.json()["fact"]
print(fact)
var nev1 = "Ond";
var nev2 = "Kond"
var nev3 = "Tas";

var nevek = ["Ond", "Kond", "Tas"];
var korok = new Array(35, 42, 38);

console.log(korok[1]);
console.log(nevek);
console.log(nevek.length);

nevek[1] = "Huba";
console.log(nevek);

nevek[nevek.length] = "Álmos";
console.log(nevek);

var huba = ["Huba", 38, "vezér", true];
console.log(huba);

huba.push(42);
console.log(huba);

huba.unshift("ifj");
console.log(huba)

huba.pop();
console.log(huba)

huba.shift();
console.log(huba);

console.log(huba.indexOf(48));

var szakacs = huba.indexOf("szakacs") === -1 ? "Huba nem szakács" : "Huba szakács";
console.log(szakacs);
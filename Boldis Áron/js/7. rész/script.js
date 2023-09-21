var film = "Gladiátor";
var mufaj;

switch (film){
    case "Shrek" : mufaj = "mese";
        break;
    case "Terminator" : mufaj = "akció";
        break;
    case "Utazók" : mufaj = "sci-fi";
        break;
    default :
        mufaj = "besorolatlan"
}

console.log(mufaj);

var kor = 10;
var nev = "Béla";

switch (true){
    case kor < 13 :
        console.log(nev + " kisfiú")
    case kor >= 13 && kor <= 20:
        console.log(nev + " tinédzser")
    case kor >= 20 && kor < 20:
        console.log(nev + " fiatalember")
    default:
        console.log(nev + " igazi férfi")
}
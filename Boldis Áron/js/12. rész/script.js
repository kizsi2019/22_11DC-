var eletSzakaszok = function(nev, kor) {
    switch (true){
        case kor < 13:
            return nev + " gyerek";
            break;
        case kor >= 13 && kor <= 20:
            return nev + " tinédzser";
            break;
        case kor > 20 && kor <= 30:
            return nev + " ifju";
            break;
        case kor > 30 && kor <=50:
            return nev + " középkorú"
            break;
        default:
            return nev + " idős";
    }
}

console.log(eletSzakaszok("Kati", 12))
console.log(eletSzakaszok("Peti", 20))
console.log(eletSzakaszok("Márk", 67))

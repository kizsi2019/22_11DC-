function korKer(sugar){
    var kerulet = 2 * sugar * Math.PI;
    return kerulet;
}

function korTer(sugar){
    var terulet = Math.pow(sugar) * Math.PI;
    return terulet;
}

var sugar = prompt()

console.log(korKer(sugar))
console.log(korTer(sugar))
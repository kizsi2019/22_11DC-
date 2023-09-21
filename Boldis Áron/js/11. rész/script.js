function teglalapKeruletTerulet(a, b, funkcio) {
    var eredmeny;
    if (funkcio === "kerület"){
        eredmeny = (a + b) * 2;
    }
    else if (funkcio === "terulet"){
        eredmeny = a * b;
    }
    else{
        return "Hibás funkció";
    }

    return funkcio + " = " + eredmeny;
}   

console.log(teglalapKeruletTerulet(5, 4, "kerület"));
console.log(teglalapKeruletTerulet(4, 5, "terület"));
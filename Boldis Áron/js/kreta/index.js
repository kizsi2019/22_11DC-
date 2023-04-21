const studioName = document.getElementById("studioName");
let progressBar = document.getElementById("progressBar");

document.getElementById("submitBtn").onclick = function(){
    document.getElementById("studioName").innerHTML = document.getElementById("inputField").value;
    
}

document.getElementById("submitBtn2").onclick = function(){
    let color = document.getElementById("inputField2").value; 
    document.getElementById("studioContainer").style.backgroundColor = color;
}
document.getElementById("submitBtn3").onclick = function(){
    let rating = document.getElementById("inputField3").value;
    let progressBarWidth = rating + 1 + "%";
    progressBar.style.width = progressBarWidth;
}
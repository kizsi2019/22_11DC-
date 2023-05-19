function showStudio() {
    const studioInput = document.getElementById("studio").value;
    const studioDiv = document.getElementById("studió");
    studioDiv.innerText = studioInput;
    studioDiv.classList.remove("hide");
}

function changeColor() {
    const colorInput = document.getElementById("color").value;
    document.body.style.backgroundColor = colorInput;
}

function showRating() {
    const ratingInput = document.getElementById("rating").value;
    const progressBars = document.querySelectorAll("#progressbar1, #progressbar2, #progressbar3, #progressbar4, #progressbar5");
    progressBars.forEach((bar, index) => {
        if (index < ratingInput) {
            bar.classList.remove("hide");
            const progress = bar.querySelector("div");
            progress.style.width = `${(index + 1) * 20}%`;
        } else {
            bar.classList.add("hide");
        }
    });
}

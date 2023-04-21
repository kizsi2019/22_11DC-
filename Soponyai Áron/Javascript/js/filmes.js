function showStudioName() {
    const input = document.getElementById("studio-name-input");
    const name = input.value;
    const studioName = document.getElementById("studio-name");
    studioName.innerText = name;
    studioName.style.display = "block";
}

function changeBackgroundColor() {
    const input = document.getElementById("favorite-color-input");
    const color = input.value;
    document.body.style.backgroundColor = color;
}

function showProgressBar() {
    const input = document.getElementById("movie-rating-input");
    const rating = input.value;
    const progressBar = document.getElementById("progress-bar-" + rating);
    progressBar.style.display = "block";
    const progressBarsContainer = document.getElementById("progress-bars");
    progressBarsContainer.style.display = "block";
}
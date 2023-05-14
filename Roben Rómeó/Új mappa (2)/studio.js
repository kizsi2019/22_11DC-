const form = document.querySelector('form');
const progressBar = document.querySelector('#movie-rating-progress');

form.addEventListener('submit', function(event) {
  event.preventDefault();
  const studioName = document.querySelector('#studio-name').value;
  const favColor = document.querySelector('#fav-color').value;
  const movieRating = document.querySelector('#movie-rating').value;

  // Change the text color to the user's favorite color
  document.body.style.color = favColor;

  // Update the progress bar based on the movie rating
  progressBar.value = movieRating;

  // Display a message to the user
  alert(`Köszönjük, ${studioName}! Az értékelésed: ${movieRating}.`);
});
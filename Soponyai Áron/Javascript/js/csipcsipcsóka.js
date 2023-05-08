const form = document.querySelector('form');
const filmstudio = document.querySelector('#filmstudio');

form.addEventListener('submit', (event) => {
	event.preventDefault();
	const nev = document.querySelector('#nev').value;
	filmstudio.textContent = nev;
	});

const div = document.querySelector('form');

div.addEventListener('submit', (event) => {
    event.preventDefault();
    const szin = document.querySelector('#szin').value;
    document.body.style.backgroundColor = szin;
    });

    const div2 = document.querySelector('form');
    const progressBar1 = document.querySelector('#progress-bar-1');
    const progressBar2 = document.querySelector('#progress-bar-2');
    const progressBar3 = document.querySelector('#progress-bar-3');
    const progressBar4 = document.querySelector('#progress-bar-4');
    const progressBar5 = document.querySelector('#progress-bar-5');

    progressBar1.style.display = 'none';
    progressBar2.style.display = 'none';
    progressBar3.style.display = 'none';
    progressBar4.style.display = 'none';
    progressBar5.style.display = 'none';

    div2.addEventListener('submit', (event) => {
        event.preventDefault();
        const ertek = parseInt(document.querySelector('#ertek').value);
        if (ertek >= 1 && ertek <= 5) {
            const progressBar = document.querySelector(`#progress-bar-${ertek}`);
            progressBar.style.display = 'block';
            const progress = progressBar.querySelector('.progress');
            progress.style.width = `${ertek * 20}%`;
        }
    });
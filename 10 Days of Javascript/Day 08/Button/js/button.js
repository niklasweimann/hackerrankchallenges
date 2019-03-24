window.onload = () => {
    const clickMeButton = document.getElementById('btn');
    clickMeButton.id = 'btn';
    clickMeButton.innerHTML = '0';
    clickMeButton.addEventListener('click', (e) => {
              const clicks = parseInt(e.currentTarget.innerText, 0) + 1;
              e.currentTarget.innerText = clicks;
         }); 
}
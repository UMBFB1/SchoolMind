function toggleDropdown(id) {
    let dropdownMenu = document.getElementById(id);
    dropdownMenu.classList.toggle("show-dropdown");
}

function closePop(id) {
    let pop = document.getElementById(id);
    pop.style.display = 'none';   
}

function openPop(event, id) {
    event.preventDefault();
    let pop = document.getElementById(id);
    pop.style.display = 'block';   
}

function aparecerConteiner(conteinerId) {
    const conteiner = document.getElementById(conteinerId);
    if (conteiner.style.display === 'flex') {
        conteiner.style.display = 'none';
    }else{
        conteiner.style.display = 'flex'
    }
}
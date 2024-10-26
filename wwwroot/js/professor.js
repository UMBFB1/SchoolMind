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

function toggleMaterialType() {
    const tipo = document.getElementById('tipoMaterial').value;
    const campoArquivo = document.getElementById('campoArquivo');
    const campoTexto = document.getElementById('campoTexto');
    const campoLink = document.getElementById('campoLink');
    
    campoArquivo.style.display = 'none';
    campoTexto.style.display = 'none';
    campoLink.style.display = 'none';
    
    if (tipo === 'arquivo') {
        campoArquivo.style.display = 'block';
    } else if (tipo === 'texto') {
        campoTexto.style.display = 'block';
    } else if (tipo === 'link') {
        campoLink.style.display = 'block';
    }
}
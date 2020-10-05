
function colocarFilmesNoHTML(filmes){
    var filmes = [
        {
            'titulo': 'Alice no Pais das Maravilhas',
            'genero': 'Fantasia'
        },
        {
            'titulo': 'The Boys',
            'genero': 'Ficção Cientifica'
        },
        {
            'titulo': 'Clube da Luta',
            'genero': 'Ação'
        },
        {
            'titulo': 'Coringa (2019)',
            'genero': 'Drama'
        },
    ]
    
    $.ajax({
        url : "http://localhost:5000/api/Filmes",
        type : 'get',
        data : {}
   })
   .done(function(retorno){
        filmes = retorno
        console.log("DEBUG | COLOCANDO FILMES")
   })

    console.log("DEBUG | COLOCANDO FILMES")
    $("#filmesContainer").empty();
    
    $("#filmesContainer").append(`
        <p class="logoTitulo">Lista de Filmes</p>
    `)

    filmes.forEach(filme => {
        $("#filmesContainer").append(`
        <div class="filmeContainer">
            <span class="listaPagina marginLeft">${filme.titulo}</span>
            <span class="listaPagina marginLeft">${filme.genero}</span>
        </div>`)
    });

    $("#filmesContainer").append(`
        <div class="flex justifyContentFlexEnd">
            <button class="botaoListarFilmes" id="listarFilmes">Listar filmes</button>
        </div>
    `)
}



$( "#filmesContainer" ).click(function() {
    colocarFilmesNoHTML()
});

colocarFilmesNoHTML()





using _14_RelacionarClasses;

Banda banda1 = new Banda();
banda1.nome = "Nome da banda 1";

Banda banda2 = new Banda();
banda2.nome = "Calipso Banda 2";


Album album1 = new Album();
album1.nome = "album 1";

Album album2 = new Album();
album2.nome = "album 2";



Musica musica1 = new Musica(banda1);
musica1.nome = "Primeira musica";

Musica musica2 = new Musica(banda2);
musica2.nome = "Segunda musica";





album1.AdicionarMusica(musica1);
album1.AdicionarMusica(musica2);

album1.ExibirMusicaDoAlbum();


banda1.adicionarAlbum(album1);
banda1.adicionarAlbum(album2);

banda1.exibirBanda(); ;

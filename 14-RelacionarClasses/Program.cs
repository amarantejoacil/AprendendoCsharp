




using _14_RelacionarClasses;

Album album1 = new Album();
album1.nome = "album 1";


Musica musica1 = new Musica();
musica1.nome = "Primeira musica";

Musica musica2 = new Musica();
musica2.nome = "Segunda musica";


album1.AdicionarMusica(musica1);
album1.AdicionarMusica(musica2);



album1.ExibirMusicaDoAlbum();

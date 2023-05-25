



using _15_DesafioPodCast;

PodCast AgileMind = new PodCast("AgileMind", "Novo Host");
Epsodio epsodioUm = new Epsodio();

epsodioUm.numeroEpisodio = 1;
epsodioUm.duracaoEpisodio = 20;
epsodioUm.tituloEpisodio = "O que são métodos ágeis?";


AgileMind.adicionarEpsodio(epsodioUm);

AgileMind.exibirDetalhes();




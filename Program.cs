﻿Album albumDoQueen = new Album();
albumDoQueen.Nome = "A night at the opera";

Musica musica1 = new Musica();
musica1.Nome = "Love of my life";
musica1.Duracao = 213;

Musica musica2 = new Musica();
musica2.Nome = "Bohnemian Rhapsody";
musica2.Duracao = 364;

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);
albumDoQueen.ExibirMusicasDoAlbum();
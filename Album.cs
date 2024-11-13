class Album
{
	private List<Musica> musicas = new List<Musica>();
	public string Nome {  get; set; }
	public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica (Musica musica)
	{
		musica.Add(musica);
	}

	public void ExibirMusicaDoAlbum(
	{
		Console.WriteLine($"Lista de musicas do álbum{Nome}:\n");


		foreach (var musica in musicas)
		{
			Console.WriteLine($"Musica: {musicas.Nome}");
		}
		Console.WriteLine($"Para ouvir este álbum inteiro você precisa de {DuracaoTotal}.");
	}
	
}

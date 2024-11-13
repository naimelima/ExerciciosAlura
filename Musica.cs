class Musica
{
    //propriedade
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel {  get; set; }
    //Lambda � usada para propriedades somente de leitura ex: sando de uma conta
    public string DescricaoResumida => $"A m�sica {Nome} pertence � banda {Artista}";
    


    //M�todo
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome:{Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Dura��o: {Duracao}");
        if(Disponivel)
        {
            Console.WriteLine("Dispon�vel no plano");
        }else
        { Console.WriteLine("Adquira o plano Pus+");
    }
}
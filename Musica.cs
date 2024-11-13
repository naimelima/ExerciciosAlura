class Musica
{
    //propriedade
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel {  get; set; }
    //Lambda é usada para propriedades somente de leitura ex: sando de uma conta
    public string DescricaoResumida => $"A música {Nome} pertence à banda {Artista}";
    


    //Método
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome:{Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        if(Disponivel)
        {
            Console.WriteLine("Disponível no plano");
        }else
        { Console.WriteLine("Adquira o plano Pus+");
    }
}
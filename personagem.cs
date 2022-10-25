public class personagem {
    public int forca, vida;
    public string? raca, nome;
    public arma arma;
    public magia magia;

    //construtor
    public personagem(int forca, int vida, string? raca, string? nome, int arma, int magia){
        this.forca = forca;
        this.vida = vida;
        this.raca = raca;
        this.nome = nome;

        //arma
        arma espada = new arma("Espada", 7);
        arma arco = new arma("Arco ee Flecha", 6);
        arma cajado = new arma ("Cajado", 9);

        //magia
        magia fogo = new magia("Bolas de Fogo", 8);
        magia agua = new magia("Tempestade de chuva", 5);
        magia terra = new magia("Terremoto Impiedoso", 10);
        magia ar = new magia("Tornado", 8);
    }

    public void mostraPersonagem(){
        Console.WriteLine($"Seu personagem é: {this.nome}");
        Console.WriteLine($"Alguns atributos: ");
        Console.WriteLine($"Raça: {this.raca}\nForça: {this.forca}\nArma: {this.arma}\nMagia: {this.magia}");
    }

}
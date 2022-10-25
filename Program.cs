class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Hello Raoni, welcome to my game!!");

    //objetos
    arqueiro arqueiro = new arqueiro();
    guerreiro guerreiro = new guerreiro();
    feiticeiro feiticeiro = new feiticeiro();
    espadachim espadachim = new espadachim();

    guerreiro.mostraPersonagem();
    arqueiro.mostraPersonagem();
    feiticeiro.mostraPersonagem();
    espadachim.mostraPersonagem();

  }
}

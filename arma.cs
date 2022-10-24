public class arma : artefato {
    private string nomeArma;
    private int poderArma;

    public String NomeArma { 
        get => nomeArma; 
        set => nomeArma = value;   
    }
    public int PoderArma { 
        get => poderArma; 
        set => poderArma = value;
    }
}

public class guerreiro : personagem {
}

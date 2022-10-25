public class artefato{
    private string nome;
    private int poder;

    //construtor
    public artefato(string nome, int poder) { 
        this.nome = nome;        
        this.poder = poder;
    }

    //encapsulamento?
    public string Nome { 
        get => nome; 
        set => nome = value;
    }
    public int Poder {
        get => poder;
        set => poder = value;
    }  

    //métodos
    public string mostraNome(){
        return this.nome;
    }

    public int mostraPoder(){
        return this.poder;
    }
}

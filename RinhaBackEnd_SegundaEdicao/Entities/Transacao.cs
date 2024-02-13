namespace RinhaBackEnd_SegundaEdicao.Entities;

public class Transacao
{
    public int _valor;
    public char _tipo;
    public string _descricao;
    public DateTime _realizada_em;
    public Transacao(int valor, char tipo, string descricao) {
        _valor = valor;
        _tipo = tipo;
        _descricao = descricao;
        _realizada_em = DateTime.Now;
    }
}

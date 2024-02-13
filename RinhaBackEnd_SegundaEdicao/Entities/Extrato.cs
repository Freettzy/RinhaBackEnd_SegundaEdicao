namespace RinhaBackEnd_SegundaEdicao.Entities;

public record Extrato(Saldo saldo, List<Transacao> ultimas_transacoes);

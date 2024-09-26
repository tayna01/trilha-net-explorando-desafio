namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            foreach (var hospede in hospedes)
            {
                if (hospedes.Count <= Suite.Capacidade)
                {
                    Hospedes = hospedes;
                }
                else
                {
                    throw new Exception("O número de hóspedes recebido deve ser menor ou igual à capacidade!");
                }
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            var valor_diaria = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10)
            {
                valor_diaria *= 0.90m;
            }

            return valor_diaria;
        }
    }
}
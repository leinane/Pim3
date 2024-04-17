namespace Pim3.Models
{
    public class EmprestimosModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sala { get; set; }
        public DateTime DataReserva { get; set; } = DateTime.Now;
        public string EquipamentoMultimidia { get; set; }
        public DateTime DataDevolucao { get; set; }



    }
}

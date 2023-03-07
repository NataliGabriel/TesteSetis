namespace TesteSetis.Models
{
    public class Class_ADM_Perfil
    {
        public short PER_Id { get; set; }
        public byte PER_SIS_ID { get; set; }
        public string PER_Nome { get; set; }
        public Class_ADM_Sistema Sistema { get; set; }
    }
}

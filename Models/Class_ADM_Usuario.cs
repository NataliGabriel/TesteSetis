namespace TesteSetis.Models
{
    public class Class_ADM_Usuario
    {
        public short USU_Id { get; set; }
        public short USU_ENT_Id { get; set; }
        public string USU_Nome { get; set; }
        public string USU_Login { get; set; }
        public string USU_Senha { get; set; }
        public bool USU_Bloqueado { get; set; }
        public DateTime USU_DataAcesso { get; set; }
        public Class_ADM_Entidade Entidade { get; set; }
        public List<Class_ADM_Perfil> Perfis { get; set; }
    }
}

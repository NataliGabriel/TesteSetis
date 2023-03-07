namespace TesteSetis.Models
{
    public class Class_ADM_UsuarioXPerfil
    {
        public short USP_USU_Id { get; set; }
        public short USP_PER_Id { get; set; }
        public Class_ADM_Usuario Usuario { get; set; }
        public Class_ADM_Perfil Perfil { get; set; }
    }
}

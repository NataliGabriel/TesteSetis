using System.Xml.Serialization;

namespace TesteSetis.Models
{
    public class XML_Model
    {
        [XmlRoot("usuarios")]
        public class UsuariosXml
        {
            [XmlElement("usuario")]
            public List<UsuarioXml> Usuarios { get; set; }
        }

        public class UsuarioXml
        {
            [XmlElement("id")]
            public int Id { get; set; }

            [XmlElement("entidade")]
            public EntidadeXml Entidade { get; set; }

            [XmlElement("nome")]
            public string Nome { get; set; }

            [XmlElement("login")]
            public string Login { get; set; }

            [XmlElement("senha")]
            public string Senha { get; set; }

            [XmlElement("bloqueado")]
            public bool Bloqueado { get; set; }

            [XmlElement("dataAcesso")]
            public DateTime DataAcesso { get; set; }

            [XmlElement("perfis")]
            public List<int> Perfis { get; set; }
        }

        public class EntidadeXml
        {
            [XmlElement("id")]
            public int Id { get; set; }

            [XmlElement("nome")]
            public string Nome { get; set; }

            [XmlElement("responsavel")]
            public string Responsavel { get; set; }

            [XmlElement("terminalPrefixo")]
            public int TerminalPrefixo { get; set; }
        }

    }
}

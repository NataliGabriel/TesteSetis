using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Xml.Serialization;
using TesteSetis.Models;
using static TesteSetis.Models.XML_Model;

namespace TesteSetis.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            try
            {
                // Ler o arquivo XML
                var serializer = new XmlSerializer(typeof(UsuariosXml), new XmlRootAttribute("adm"));
                using (var reader = new StreamReader("..\\TesteSetis\\Models\\XMLFile.xml"))

                {
                    var usuariosXml = (UsuariosXml)serializer.Deserialize(reader);

                    // Preencher a lista de usuários
                    var usuarios = new List<Class_ADM_Usuario>();
                    foreach (var usuarioXml in usuariosXml.Usuarios)
                    {
                        var usuario = new Class_ADM_Usuario
                        {
                            USU_Id = (short)usuarioXml.Id,
                            USU_Nome = usuarioXml.Nome,
                            USU_Login = usuarioXml.Login,
                            USU_Senha = usuarioXml.Senha,
                            USU_Bloqueado = usuarioXml.Bloqueado,
                            USU_DataAcesso = usuarioXml.DataAcesso
                        };

                        // Preencher a entidade do usuário
                        usuario.Entidade = new Class_ADM_Entidade
                        {
                            ENT_Id = (short)usuarioXml.Entidade.Id,
                            ENT_Nome = usuarioXml.Entidade.Nome,
                            ENT_Responsavel = usuarioXml.Entidade.Responsavel,
                            ENT_TerminalPrefixo = (short)usuarioXml.Entidade.TerminalPrefixo
                        };
                    }
                }

            }
            catch (Exception ex) { return View("Error" + ex); }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
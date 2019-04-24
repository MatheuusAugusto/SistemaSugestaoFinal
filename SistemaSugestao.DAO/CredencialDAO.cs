using SistemaSugestao.VO;
using SistemaSugestao.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSugestao.DAO
{
    public class CredencialDAO
    {
        public void Login(CredencialVO dadosTela)
        {
            using (var conexao = new TrabalhoGrupoEntities())
            {
                var novoLogin = new dbo.Credencial();
            }
        }
    }
}

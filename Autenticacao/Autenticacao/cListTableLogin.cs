using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autenticacao
{
    public class cListTableLogin 
    {
        public int f_id_usuario { get; set; }
        public string f_nome { get; set; }
        public string f_login { get; set; }
        public string f_senha { get; set; }
        public int f_status { get; set; }
        public DateTime f_dt_troca_senha { get; set; }
        public DateTime f_aviso_troca { get; set; }
        public int f_aviso_lock { get; set; }
        public DateTime f_dt_cadastro { get; set; }
        public DateTime f_dt_alteracao { get; set; }
        public DateTime f_dt_ultimo_login { get; set; }
        public string f_email { get; set; }
        public string f_telefone { get; set; }
    }
}

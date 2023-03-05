using SPAWithAjaxPost.WebApp.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace SPAWithAjaxPost.WebApp.Models
{
    public class Cliente
    {
        public Int64 Id { get; set; }

        [DisplayName("UF")]
        public UnidadeFederacao UF { get; set; }

        public Cidade Cidade { get; set; }

        public IEnumerable<Cidade> ListaCidades
        {
            get
            {   
                return RepositorioCidade.ObterTodos().Where(x => x.UF == UF).ToList();
            }
        }
    }
}
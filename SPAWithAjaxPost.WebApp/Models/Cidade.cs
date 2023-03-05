using SPAWithAjaxPost.WebApp.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPAWithAjaxPost.WebApp.Models
{
    public class Cidade
    {
        public virtual Int64 Id { get; set; }
        public virtual String Nome { get; set; }
        public virtual UnidadeFederacao UF { get; set; }

        public virtual String NomeCidade
        {
            get
            {
                return String.Format("{0}-{1}", Nome, UF);
            }
        }
    }
}
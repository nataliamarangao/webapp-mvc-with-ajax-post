using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPAWithAjaxPost.WebApp.Models
{
    public class RepositorioCidade
    {
        public static IList<Cidade> ObterTodos()
        {
            IList<Cidade> lista = new List<Cidade>();

            lista.Add(new Cidade { Id = 1, Nome = "Adamantina", UF = Enum.UnidadeFederacao.SP });
            lista.Add(new Cidade { Id = 2, Nome = "Lucelia", UF = Enum.UnidadeFederacao.SP });
            lista.Add(new Cidade { Id = 3, Nome = "Porto Seguro", UF = Enum.UnidadeFederacao.BA });
            lista.Add(new Cidade { Id = 4, Nome = "São Miguel dos milagres", UF = Enum.UnidadeFederacao.AL });

            return lista;

        }
    }
}
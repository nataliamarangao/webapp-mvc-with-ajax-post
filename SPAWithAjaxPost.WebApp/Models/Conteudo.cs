using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPAWithAjaxPost.WebApp.Models
{
    public class Conteudo
    {
        public virtual Int64 ID { get; set; }
        public virtual String Titulo { get; set; }
        public virtual Categoria Categoria { get; set; }
        public virtual String Texto { get; set; }
        public virtual DateTime Data { get; set; }

        public static IList<Conteudo> Todos()
        {
            var retorno = new List<Conteudo>
            {
                new Conteudo
                {
                    ID = 1,
                    Categoria = new Categoria() { ID =1, Descricao="Esportes"},
                    Titulo = "Mauro Cezar: Problema do Palmeiras não é elenco, é capacidade do treinador",
                    Texto = "O técnico Abel Ferreira mais uma vez tem uma semana livre para trabalhar com o elenco do Palmeiras depois da derrota para o Flamengo, quando veio de duas semanas sem jogos e ainda assim não conseguiu demonstrar evolução, perdendo diante de um rival desfalcado no Allianz Parque, o que levou a questionamentos ao trabalho do treinador português e também aumentou a cobrança em relação ao elenco, já que não houve a chegada de reforços com tanto nome como as recentes aquisições de Atlético-MG, Flamengo e Corinthians.",
                    Data= new DateTime(2021,09,08)
                },

                new Conteudo
                {
                    ID = 2,
                    Categoria = new Categoria() { ID=2, Descricao="Economia"},
                    Titulo = "Inflação alta coloca em risco plano de Bolsonaro de Bolsa Família turbinado",
                    Texto = "O forte aumento dos preços no país coloca em xeque a estratégia do governo para lançar um bolsa família turbinado no próximo ano.",
                    Data= new DateTime(2021,09,03)
                },

                new Conteudo
                {
                    ID = 3,
                    Categoria = new Categoria() {ID=3, Descricao="Educação"},
                    Titulo = "UFPR: aprovados na 1ª lista do Vestibular 2021 criam abaixo-assinado para ter vagas de volta",
                    Texto = "Os vestibulandos que constavam nessa primeira lista foram substituídos por outros nomes. Dessas 31 vagas, 25 são dos dois cursos de Medicina, os mais concorridos do vestibular.",
                    Data= new DateTime(2021,09,14)
                },
                new Conteudo
                {
                    ID = 4,
                    Categoria = new Categoria() {ID=3, Descricao="Educação"},
                    Titulo = "UFAM abre inscrições das etapas 1 e 2 do PSC 2021",
                    Texto = "A Universidade Federal do Amazonas (UFAM) abriu nesta terça-feira, 14 de setembro, as inscrições das etapas 1 e 2 do Processo Seletivo Contínuo (PSC) 2021. Os candidatos podem se inscrever até as 17h do próximo dia 30 (horário local). A taxa é de R$ 80.",
                    Data= new DateTime(2021,09,14)
                }

            };
            return retorno;
        }
    }

}
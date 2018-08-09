using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortalDeNoticias.Models
{
    public class RepositorioNoticias
    {
        private static List<Noticia> noticias;

        public static List<Noticia> Noticias
        {

            get
            {
                if (noticias == null)
                    CriarNoticias();
                return noticias;
            }

        }

        private static void CriarNoticias()
        {
            noticias = new List<Noticia>();

            noticias.Add(new Noticia
            {
                Id = 1,
                Titulo = "Samsung anuncia investimento de US$ 20 bilhões em novas tecnologias",
                Autor = "Victor Oses",
                Data = DateTime.Today.AddDays(-5),
                Conteudo = "O Samsung Group anunciou nesta quarta-feira, 8/8, que irá investir cerca de 20 bilhões de dólares (25 trilhões de wons coreanos) em novas tecnologias e áreas como as indústrias farmacêutica e automobilística."
            });

            noticias.Add(new Noticia
            {
                Id = 2,
                Titulo = "Brasil está preparado para a internet das coisas?",
                Autor = "Carlos Soares",
                Data = DateTime.Today.AddDays(-10),
                Conteudo = "Conforme estudo desenvolvido sobre o impacto da IoT na economia nacional pela McKinsey, em parceria com o Centro de Pesquisa e Desenvolvimento (CPqD) e o escritório de advocacia Pereira Neto Advogados, em 2025, a internet das coisas pode gerar receita de até US$ 200 bilhões por ano no Brasil."
            });

            noticias.Add(new Noticia
            { 
                Id = 3,
                Titulo = "GOL reformula app e agora permite salvar destinos para acompanhar promoções",
                Autor = "Junior Augusto",
                Data = DateTime.Today.AddDays(-10),
                Conteudo = "App permite realizar alterações ou emissões de bilhetes, acompanhar saldo de milhas do Smiles e acessar o cartão de embarque mesmo offline."
            });

            noticias.Add(new Noticia
            {
                Id = 4,
                Titulo = "Equipes de TI não estão nada satisfeitas com as atualizações do Windows 10",
                Autor = "Pedro Junior",
                Data = DateTime.Today.AddDays(-15),
                Conteudo = "Uma pesquisa feita entre administradores de TI revelou que patches, atualizações e upgrades do Windows, da Microsoft – em particular o Windows 10 -, são considerados uma bagunça que a empresa precisa ajustar."
            });

        }
    }
}
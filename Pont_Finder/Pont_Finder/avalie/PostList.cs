using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pont_Finder.avalie
{
    class PostList
    {
        

        public static List<PostConstructor> poster = new List<PostConstructor>();

        public static void PostAdd(PostConstructor post)
        {
            PostConstructor pos = new PostConstructor();

            pos.Tipoproblema = post.Tipoproblema;
            pos.Localizao = post.Localizao;
            pos.Desc = post.Desc;
            pos.Tempohora = post.Tempohora;
            pos.Modulo = "avalie";
            
            poster.Add(pos);
        }

        public static string[] select(int index)
        {
            
                string desc = poster[index].Desc;
                string tipoProblema = poster[index].Tipoproblema;
                string localiza = poster[index].Localizao;
                string tempohor = poster[index].Tempohora;
                string modulo = poster[index].Modulo;
                string[] vetor = { tempohor, tipoProblema, localiza, desc };
                return vetor;

        }


        public static void del(int index)
        {
            poster[index].Tempohora = "";
            poster[index].Desc = "";
            poster[index].Tipoproblema = "";
            poster[index].Localizao = "";

        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace project.FakeGym.Model
{
    public class alunoMOD
    {
        public Int32 id_aluno { get; set; }
        public String nome_aluno { get; set; }
        public String sobrenome_aluno { get; set; }
        public String dtNasc_aluno { get; set; }
        public String nome_professor { get; set; }
        public String nome_academia { get; set; }
        public String senha_aluno { get; set; }
        public Decimal status_aluno { get; set; }
    }
}




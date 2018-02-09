using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project.FakeGym.Repository;
using project.FakeGym.Model;

namespace project.FakeGym.Business
{
    public class TreinoBUS
    {
        private TreinoREP _repTreino = new TreinoREP();

        public List<TreinoMOD> Listar()
        {
            return _repTreino.Listar();
        }
    }
}

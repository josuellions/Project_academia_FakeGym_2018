using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project.FakeGym.DataAccess;
using project.FakeGym.Model;
using System.Data;

namespace project.FakeGym.Repository
{
    public class TreinoREP
    {
        private ADO _ado = new ADO();

        public List<TreinoMOD> Listar()
        {
            var treinos = new List<TreinoMOD>();

            String _strSql = $@"SELECT * FROM tbTreino";

            var registroTreinos = _ado.RetornoTabela(_strSql);

            foreach (DataRow item in registroTreinos.Rows)
            {
                treinos.Add(new TreinoMOD
                {
                    //id_treino = Convert.ToInt32(item["Id_treino"]),
                    exercicio_01 = item["exercicio_01"].ToString(),
                    exercicio_02 = item["exercicio_02"].ToString(),
                    exercicio_03 = item["exercicio_03"].ToString(),
                    status_treino =Convert.ToDecimal( item["status_treino"] )
                });
            }

            return treinos;
        }
    }
}
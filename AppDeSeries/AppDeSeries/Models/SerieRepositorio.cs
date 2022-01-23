using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDeSeries
{
    public class SerieRepositorio : IRepositorio<Series>

    {
        private List<Series> seriesList = new List<Series>();
        public void Atualiza(int id, Series entidade)
        {
            seriesList[id] = entidade;
        }

        public void Exclui(int id)
        {
            seriesList[id].Excluir();
        }

        public void Insere(Series entidade)
        {
            seriesList.Add(entidade);
        }

        public List<Series> Lista()
        {
            return seriesList;
        }

        public int ProximoId()
        {
            return seriesList.Count;
        }

        public Series RetornaPorId(int id)
        {
            return seriesList[id];
        }
    }
}

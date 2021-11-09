using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Series.Class;
using Series.Class.Enum;
using Series.Entities;
using Series.Interfaces;

namespace Series
{
    class SerieRepositorio : IRepositorio<Serie>
    {

        private List<Serie> listaDeSerie = new List<Serie>();
        public void Atualiza(int id, Serie objeto)
        {
            listaDeSerie[id] = objeto;
        }

        public void Exclui(int id)
        {
            listaDeSerie[id].Excluir();
            
        }

        public void Insere(Serie objeto)
        {
            listaDeSerie.Add(objeto);
        }

        public List<Serie> Lista()
        {
            return listaDeSerie;
        }

        public int ProximoId()
        {
            return listaDeSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return listaDeSerie[id];
        }
    }
}

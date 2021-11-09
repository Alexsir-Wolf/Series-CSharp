using System;
using System.Collections.Generic;
using System.Linq;
using Series.Class.Enum;
using Series.Entities;
using Series.Interfaces;

namespace Series.Interfaces
{
    interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornaPorId(int id);
        void Insere(T entidade);
        void Exclui(int id);
        void Atualiza(int id, T entidade);
        int ProximoId();
    }
}

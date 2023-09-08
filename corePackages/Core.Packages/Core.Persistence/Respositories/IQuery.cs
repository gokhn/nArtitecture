using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Persistence.Respositories
{
    public interface IQuery<T>
    {
        //Sql sorgularının TSql yazildgi kisim
        IQueryable<T> Query();
    }
}

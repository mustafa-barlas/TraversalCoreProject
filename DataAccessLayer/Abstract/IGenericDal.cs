using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal <T> 
    {
        void Insert(T t);
        void Delete(T t);
        void update(T t);
        T GetById(T t);
        List<T> GetList();
    }
}

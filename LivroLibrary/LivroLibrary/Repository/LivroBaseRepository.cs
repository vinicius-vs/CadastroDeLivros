using LivroLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivroLibrary.Repository
{
    class LivroBaseRepository<T> where T: LivroBaseModel
    {

        public void Create(T model)
        {

        }

        public List<T> Read()
        {
            List<T> lista = new List<T>();


            return lista;

        }

        public T Read(int id)
        {
            T model = Activator.CreateInstance<T>();

            return model;
        }

        public void Update(T model)
        {

        }


        public void Delete(int id)
        {

        }


    }
}

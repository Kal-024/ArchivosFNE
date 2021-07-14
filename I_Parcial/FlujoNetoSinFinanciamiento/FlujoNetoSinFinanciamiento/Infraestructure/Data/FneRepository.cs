using FlujoNetoSinFinanciamiento.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FlujoNetoSinFinanciamiento.Infraestructure.Data
{
    public class FneRepository
    {
        private RAFContext context;
        private readonly int SIZE = 204;
        List<Fne> fnes;

        public FneRepository()
        {
            context = new RAFContext("FNE", SIZE);
        }

        #region Metodos
        public void Create( Fne t)
        {
            context.Create<Fne>(t);
        }

        public int Update(Fne t)
        {
            return context.Update<Fne>(t);
        }

        public bool Delete(Fne t)
        {
            FindId(getIds(), t.Id);

            if (context.Get<Fne>(t.Id) == null) // Esto creo que no es necesario 
            {
                throw new ArgumentException($"Product with Id {t.Id} does not exists.");
            }
            return context.Delete(t);
        }

        public IEnumerable<Fne> GetAll()
        {
            return context.GetAll<Fne>();
        }

        public IEnumerable<Fne> Find(Expression<Func<Fne, bool>> where)
        {
            throw new NotImplementedException();
        }

        private int[] getIds()
        {
            fnes = context.GetAll<Fne>();
            int index = fnes.Count();
            int[] fnesId = new int[index];

            for (int i = 0; i < index; i++)
            {
                fnesId[i] = fnes.ElementAt(i).Id;
            }
            return fnesId;
        }
        private void FindId(Array myArr, object myObject)
        {
            if (myArr == null)
            {
                return;
            }
            int myIndex = Array.BinarySearch(myArr, myObject);
            if (myIndex < 0)
            {
                Console.WriteLine($"The id ({myObject}) is not found.");
            }
            else
            {
                Console.WriteLine($"The Id is ({myObject}) Found at index {myIndex}.");
            }
        }



        #endregion
    }
}

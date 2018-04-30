using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentosEasy.Dados.Contexto;
using TalentosEasy.Dominio.Interfaces.Repositorios;

namespace TalentosEasy.Dados.Repositorios
{
    public class RepositorioBase<TEntity> : IRepositorioBase<TEntity> where TEntity : class
    {
        protected TalentosEasyContext Db = new TalentosEasyContext();

        public void Add(TEntity obj)
        {
            Db.Set<TEntity>().Add(obj);
        }      

        public IEnumerable<TEntity> GetAll()
        {
            return Db.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return Db.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity obj)
        {
            Db.Set<TEntity>().Remove(obj);
        }

        public void Update(TEntity obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
        }

        public void Commit()
        {
            Db.SaveChanges();
        }

        public void Dispose()
        {
            if (Db != null)
            {
                Db.Dispose();
            }
            GC.SuppressFinalize(this);
        }
    }
}

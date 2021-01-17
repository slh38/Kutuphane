using Kutuphane.DataAccess.Arayuzler;
using Kutuphane.DataAccess.Baglanti;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;

namespace Kutuphane.DataAccess.VeriErisim
{
    public class EntityAnaSablon<TEntity> : EntityRepository<TEntity> where TEntity:class, IEntity,new()
    {
        KutuphaneContext _context = new KutuphaneContext();
        public TEntity AddorUpdate(TEntity entity)
        {
            _context.Set<TEntity>().AddOrUpdate(entity);
            return entity;
        }

        public TEntity Ekle(TEntity entity)
        {
            _context.Entry<TEntity>(entity).State = EntityState.Added;
            return entity;
            
        }

        public TEntity Getir(Expression<Func<TEntity, bool>> filtre)
        {
            return _context.Set<TEntity>().SingleOrDefault(filtre);
        }

        public TEntity Guncelle(TEntity entity)
        {
            _context.Entry<TEntity>(entity).State = EntityState.Modified;
            return entity;
        }

        public List<TEntity> Listele(Expression<Func<TEntity, bool>> filtre = null)
        {
            return filtre == null 
                ? _context.Set<TEntity>().ToList() : 
                _context.Set<TEntity>().Where(filtre).ToList();
        }

        public void sil(Expression<Func<TEntity, bool>> filtre)
        {
            _context.Set<TEntity>().RemoveRange(_context.Set<TEntity>().Where(filtre));
        }
    }
}

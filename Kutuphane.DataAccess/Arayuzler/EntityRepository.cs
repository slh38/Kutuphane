using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.DataAccess.Arayuzler
{
   public  interface EntityRepository<TEntity> where TEntity:class, IEntity,new()
    {
        //IEntityRepositoy yazmam gerekirken EntityRepository yazmışım
        List<TEntity>  Listele(Expression<Func<TEntity, bool>> filtre=null);
        TEntity Getir(Expression<Func<TEntity, bool>> filtre);
        TEntity Ekle(TEntity entity);
        TEntity Guncelle(TEntity entity);
        TEntity AddorUpdate(TEntity entity);
        void sil(Expression<Func<TEntity, bool>> filtre);
    }
}

﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Kutuphane_Otomasyonu.Entities.Interfaces
{ 
   public interface IGenericRepository<TContext, TEntity>
        where TContext:DbContext, new()
        where TEntity :class, new() 
     {
        List<TEntity> GetAll(TContext context,Expression<Func<TEntity,bool>>filter=null,string tbl=null);//filtre null ise tüm listeyi getir.Değilse filtrele
        TEntity GetByFilter(TContext context, Expression<Func<TEntity, bool>> filter, string tbl=null );//Tek kayıt getirir

        TEntity GetById(TContext context,int? Id);//null değeri de alabilsin diye soru işareti koyduk

        void InsertorUpdate(TContext context, TEntity entity);

        void Delete(TContext context,Expression<Func<TEntity,bool>>filter);

        void Save(TContext context);
    
    }
}

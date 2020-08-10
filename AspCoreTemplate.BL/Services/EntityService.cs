using AspCoreTemplate.BL.Models;
using AspCoreTemplate.DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AspCoreTemplate.BL.Services
{
    public abstract class EntityService<TEntity, TDTO> where TEntity : class
    {
        protected AppDbContext Context { get; }
        protected abstract DbSet<TEntity> DbSet { get; }

        public EntityService(AppDbContext context) {
            Context = context;
        }

        public Dataset<TDTO> UpdateDataset(Dataset<TDTO> dataset)
        {
            return new Dataset<TDTO>()
            {
                Items = DbSet.Skip(dataset.Query.StartOffset).Take(dataset.Query.PageSize).Select(i => MapEntityToDTO(i)),
                Query = dataset.Query,
                Edits = dataset.Edits
            };
        }

        protected abstract TDTO MapEntityToDTO(TEntity entity);
    }
}

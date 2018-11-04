using Principle.Data;
using Principle.Models.ReadModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Principle.Repository
{
    public class DataEntityRepository
    {
        public List<WildSearchModel> GetEntities()
        {
            using (var context = new PrincipleDataContext())
            {
                var entities = (from item in context.Entities
                                select new WildSearchModel
                                {
                                    Id = item.Id,
                                    Name = item.Name
                                }).ToList();
                return entities;
            }
        }

        public List<WildSearchModel> GetInputEntities()
        {
            using (var context = new PrincipleDataContext())
            {
                var entities = (from item in context.Inputs
                                select new WildSearchModel
                                {
                                    Id = item.Id,
                                    Name = item.Name
                                }).ToList();
                return entities;
            }
        }
    }
}

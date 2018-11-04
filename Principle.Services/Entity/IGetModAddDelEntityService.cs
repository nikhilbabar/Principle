using Principle.Models.CommandModels;
using Principle.Models.ReadModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principle.Services.Entity
{
    interface IGetModAddDelEntityService
    {
        EntityCommandModel GetEntity(int id);
        EntityCommandModel ModifyEntity(EntityCommandModel entity);
        EntityCommandModel AddEntity(EntityCommandModel entity);
        void DeleteEntity(int id);
    }
}

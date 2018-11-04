using Principle.Models.ReadModels;
using Principle.Repository;
using System.Collections.Generic;
using System.Linq;
using Principle.Models.CommandModels;
using System;

namespace Principle.Services.Entity
{
    public class DataEntityService : IRetrieveEntityService, IGetModAddDelEntityService
    {
        /// This is the implementation of LSP.

        #region Declaration(s)
        private readonly IUnitOfWork _unitWork;
        #endregion

        #region Properties

        /// <summary>
        /// Poor man's dependency injection
        /// </summary>
        public DataEntityService() : this(new UnitOfWork()) { }

        public DataEntityService(UnitOfWork unitWork)
        {
            _unitWork = unitWork;
        }
        #endregion

        #region Constructor(s)
        #endregion

        #region Method(s)
        List<WildSearchModel> IRetrieveEntityService.GetMasterEntities()
        {
            var entities = (from item in _unitWork.GetRepository<Data.Entity>().Get()
                            select new WildSearchModel
                            {
                                Id = item.Id,
                                Name = item.Name
                            }).ToList();
            return entities;
        }

        List<WildSearchModel> IRetrieveEntityService.GetNewEntities()
        {
            var entities = (from item in _unitWork.GetRepository<Data.Input>().Get()
                            select new WildSearchModel
                            {
                                Id = item.Id,
                                Name = item.Name
                            }).ToList();
            return entities;
        }

        EntityCommandModel IGetModAddDelEntityService.GetEntity(int id)
        {
            return GetEntityById(id);
        }

        EntityCommandModel IGetModAddDelEntityService.AddEntity(EntityCommandModel entity)
        {
            var newEntity = new Data.Entity() { Name = entity.Name, EntityTypeId = entity.EntityTypeId, IsValid = true };

            var dbEntity = _unitWork.GetRepository<Data.Entity>().Get(x => x.Name == entity.Name);
            if (dbEntity != null)
            {
                // Duplicate entity found/ Entity exist
            }
            else
            {
                try
                {
                    _unitWork.GetRepository<Data.Entity>().Insert(newEntity);
                    _unitWork.Save();
                }
                catch
                {
                    // Database operation exception
                }
            }
            return GetEntityById(newEntity.Id);
        }

        EntityCommandModel IGetModAddDelEntityService.ModifyEntity(EntityCommandModel entity)
        {
            Data.Entity currentEntity = null;
            try
            {
                currentEntity = _unitWork.GetRepository<Data.Entity>().Get(x => x.Id == entity.Id).SingleOrDefault();
            }
            catch (Exception ex)
            {
                if (ex is InvalidOperationException)
                    throw new InvalidOperationException(); // Duplicate entity found
                throw;
            }
            if (currentEntity == null)
            {
                // Entity not found
            }
            else
            {
                currentEntity.Name = entity.Name;
                currentEntity.EntityTypeId = entity.EntityTypeId;

                try
                {
                    _unitWork.GetRepository<Data.Entity>().Update(currentEntity);
                    _unitWork.Save();
                }
                catch
                {
                    // Database operation exception
                }
            }
            return GetEntityById(currentEntity.Id);
        }

        void IGetModAddDelEntityService.DeleteEntity(int id)
        {
            Data.Entity currentEntity = null;
            try
            {
                currentEntity = _unitWork.GetRepository<Data.Entity>().Get(x => x.Id == id).SingleOrDefault();
            }
            catch (Exception ex)
            {
                if (ex is InvalidOperationException)
                    throw new InvalidOperationException(); // Duplicate entity found
                throw;
            }
            if (currentEntity == null)
            {
                // Entity not found
            }
            else
            {
                try
                {
                    _unitWork.GetRepository<Data.Entity>().Delete(currentEntity);
                    _unitWork.Save();
                }
                catch
                {
                    // Database operation exception
                }
            }
        }
        #endregion

        #region Function(s)
        private EntityCommandModel GetEntityById(int id)
        {
            var entity = from item in _unitWork.GetRepository<Data.Entity>().Get(x => x.Id == id)
                         select new EntityCommandModel
                         {
                             Id = item.Id,
                             Name = item.Name,
                             EntityTypeId = item.EntityTypeId,
                             EntityTypeName = item.EntityType.Name
                         };
            return entity.First();
        }
        #endregion

    }
}

// ==========================================================================================
//
// Copyright © 2023 AnriMart
//
// History
// ------------------------------------------------------------------------------------------
// Date         Author      
// ------------------------------------------------------------------------------------------
// 2023.10.23   Loan   
// ==========================================================================================
//
namespace AnriMartServer.Models
{
    /// <summary>
    ///  Shared Model
    /// </summary>
    public class BaseModel
    {   
        public uint Id { get; set; }

        /// <summary>
        ///  Mapping model to Entity
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T MapTo<T>() where T : class, new()
        {
            var entity = new T();

            var entityProps = entity.GetType().GetProperties();
            var modelProps = GetType().GetProperties();
            foreach (var model in modelProps)
            {
                var detectEntity = entityProps.FirstOrDefault(e => e.Name == model.Name);
                if (detectEntity == null)
                {
                    continue;
                }
                detectEntity.SetValue(entity,model.GetValue(this));
            }
            return entity;
        }
    }
}
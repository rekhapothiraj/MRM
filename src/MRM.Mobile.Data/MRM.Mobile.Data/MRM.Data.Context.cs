//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.EntityClient;

namespace MRM.Mobile.Data
{
    public partial class MRMEntities : ObjectContext
    {
        public const string ConnectionString = "name=MRMEntities";
        public const string ContainerName = "MRMEntities";
    
        #region Constructors
    
        public MRMEntities()
            : base(ConnectionString, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
        }
    
        public MRMEntities(string connectionString)
            : base(connectionString, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
        }
    
        public MRMEntities(EntityConnection connection)
            : base(connection, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
        }
    
        #endregion
    
        #region ObjectSet Properties
    
        public ObjectSet<Site> Sites
        {
            get { return _sites  ?? (_sites = CreateObjectSet<Site>("Sites")); }
        }
        private ObjectSet<Site> _sites;

        #endregion
    }
}

﻿using System.ComponentModel;

namespace PowerStore.Core.ModelBinding
{
    /// <summary>
    /// Represents model attribute that specifies the display name by passed key of the locale resource
    /// </summary>
    public class PowerStoreResourceDisplayNameAttribute : DisplayNameAttribute, IModelAttribute
    {
        #region Fields

        private string _resourceValue = string.Empty;

        #endregion

        #region Ctor

        /// <summary>
        /// Create instance of the attribute
        /// </summary>
        /// <param name="resourceKey">Key of the locale resource</param>
        public PowerStoreResourceDisplayNameAttribute(string resourceKey) : base(resourceKey)
        {
            ResourceKey = resourceKey;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets key of the locale resource 
        /// </summary>
        public string ResourceKey { get; set; }

        /// <summary>
        /// Gets name of the attribute
        /// </summary>
        public string Name {
            get { return nameof(PowerStoreResourceDisplayNameAttribute); }
        }

        #endregion
    }
}

﻿using System;

namespace DapperBD.CurrentModels
{
    /// <summary>
    /// Holds basic information to be shared by all the entities in this solution.
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>
        /// The internal GUID generated by this system.
        /// </summary>
        [Orm(Ignore = false)]
        public Guid Id { get; protected set; }

        /// <summary>
        /// The DateTime this instance was created in this system.
        /// </summary>
        [Orm(Name = "created_at")]
        public DateTime CreationDateTime { get; protected set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        public BaseEntity()
        {
            Id = Guid.NewGuid();
            CreationDateTime = DateTime.Now;
        }
    }
}

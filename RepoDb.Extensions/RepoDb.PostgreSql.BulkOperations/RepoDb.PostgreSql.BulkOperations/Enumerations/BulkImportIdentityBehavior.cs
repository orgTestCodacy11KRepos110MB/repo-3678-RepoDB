﻿namespace RepoDb.PostgreSql.BulkOperations.Enumerations
{
    /// <summary>
    /// An enumeration that is being used to define the behavior of the identity property/column
    /// when an entity is being bulk-imported towards the underlying target table.
    /// </summary>
    public enum BulkImportIdentityBehavior : short
    {
        /// <summary>
        /// No action required.
        /// </summary>
        Unspecified,
        /// <summary>
        /// A value that indicates whether the identity property/column will be kept and used.
        /// </summary>
        KeepIdentity,
        /// <summary>
        /// A value that indicates whether the newly generated identity value from the target table
        /// will be set back to the entity.
        /// </summary>
        ReturnIdentity
    }
}

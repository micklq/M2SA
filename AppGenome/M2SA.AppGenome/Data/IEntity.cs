using System;

namespace M2SA.AppGenome.Data
{
    /// <summary>
    /// 
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// 
        /// </summary>
        PersistentState PersistentState { get; set; }
        /// <summary>
        /// 
        /// </summary>
        DateTime CreatedTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        DateTime LastModifiedTime { get; set; }
    }

    /// <summary>
	/// Description of IEntity.
	/// </summary>
    public interface IEntity<TId> : IEntity
	{
        /// <summary>
        /// 
        /// </summary>
		TId Id { get; set; }
	}
}

using System;
namespace Core.Entities
{
	public class BaseEntity<TId>
	{
        public TId Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; } //soft delete: silinmese de siliniyormuş gibi gösteriliyor
    }
}


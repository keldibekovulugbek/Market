using Market.Domain.Enums;

namespace Market.Domain.Common
{
    public class Auditable
    {
        public Guid? Id { get; set; }
        public ItemState ItemState { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }


        public virtual void OnCreated()
        {
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
            ItemState = ItemState.Created;

        }
        public virtual void OnUpdated()
        {
            UpdatedAt = DateTime.Now;
            ItemState = ItemState.Updated;
        }
        public virtual void OnDeleted()
        {
            UpdatedAt = DateTime.Now;
            ItemState = ItemState.Deleted;
        }

    }
}

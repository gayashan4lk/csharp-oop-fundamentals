namespace Stark.BL.Models
{
    public abstract class EntityBase
    {
        public bool IsNew { get; private set; }
        public bool HasChanges { get; set; }
        public bool IsValid
        {
            get { return Validate(); }
        }

        public abstract bool Validate();

        /*public bool Validate()
        {
            return true;
        }*/

        public EntityStateOption EntityState { get; set; }
    }
}

using System;

namespace AC.Base
{
    public enum EntityStateOption
    {
        Active,
        Deleted
    }

    public abstract class EntityBase
    {

        public EntityStateOption EntityState { get; set; }
        public bool hasChanges {get;set;}
        public bool isNew {get; private set;}

        public bool isValid
        {
            get
            {
                return Validate();
            }
        }

        public abstract bool Validate();


    }
}
using System;

namespace Mixins
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    class DocumentPersistentTargetTypeAttribute : Attribute
    {
        public Type BoundClass { get; private set; }

        public DocumentPersistentTargetTypeAttribute(Type boundClass)
        {
            if(boundClass != typeof(Document) && !boundClass.IsSubclassOf(typeof(Document)))
                throw new ApplicationException("Bound class must be subclass of Document");
            BoundClass = boundClass;
        }

    }
}

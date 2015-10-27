using System;

namespace Mixins
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    class DocumentPersistentTargetTypeAttribute : Attribute        // атрибут, который поможет нам связать обработчик функции-примеси с объектом из оригинальной иерархии классов
    {
        public Type BoundClass { get; private set; }

        public DocumentPersistentTargetTypeAttribute(Type boundClass)
        {
            if(boundClass != typeof(Document.Document) && !boundClass.IsSubclassOf(typeof(Document.Document)))
                throw new ApplicationException("Bound class must be subclass of Document");
            BoundClass = boundClass;
        }

    }
}

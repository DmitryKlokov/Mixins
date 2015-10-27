using System;

namespace Mixins.PersistentStorage
{
    [DocumentPersistentTargetType(typeof(Document.Document))]
    class DocumentPersistentStorage : IDocumentPersistentStorage  //объекты-обработчики для каждого члена оригинальной иерархии.
    {
        public void Store(Document.Document doc)
        {
            Console.WriteLine("DocumentPersistentStorage store {0}", doc.ID);
        }
    }
}

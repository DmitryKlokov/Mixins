using System;

namespace Mixins
{
    [DocumentPersistentTargetType(typeof(Document))]
    class DocumentPersistentStorage : IDocumentPersistentStorage
    {
        public void Store(Document doc)
        {
            Console.WriteLine("DocumentPersistentStorage store {0}", doc.ID);
        }
    }
}

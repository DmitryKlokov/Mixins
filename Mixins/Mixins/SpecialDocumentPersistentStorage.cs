using System;

namespace Mixins
{
     [DocumentPersistentTargetType(typeof(SpecialDocument))]
    class SpecialDocumentPersistentStorage :IDocumentPersistentStorage
    {
        public void Store(Document doc)
        {
            Console.WriteLine("SpecialDocumentPersistentStorage store {0}", doc.ID);
        }
    }
}

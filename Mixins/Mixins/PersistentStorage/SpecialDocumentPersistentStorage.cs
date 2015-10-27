using System;
using Mixins.Document;

namespace Mixins.PersistentStorage
{
     [DocumentPersistentTargetType(typeof(SpecialDocument))]
    class SpecialDocumentPersistentStorage : IDocumentPersistentStorage //объекты-обработчики для каждого члена оригинальной иерархии.
    {
        public void Store(Document.Document doc)
        {
            Console.WriteLine("SpecialDocumentPersistentStorage store {0}", doc.ID);
        }
    }
}

namespace Mixins.PersistentStorage
{
    interface IDocumentPersistentStorage           //интерфейс, который должны будут реализовывать классы-расширения.
    {
        void Store(Document.Document doc);
    }
}

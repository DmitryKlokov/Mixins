using System;
using Mixins.Document;

namespace Mixins
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Document.Document doc = new Document.Document();
                Document.Document spDoc = new SpecialDocument();

                doc.Store();
                spDoc.Store();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}

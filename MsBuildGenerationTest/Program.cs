using System;

namespace MsBuildGenerationTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate some generated classes ensures that they are really present.
            // Note that this code is not supposed to test runtime behavior, we have plenty of other test cases for that purpose.

            void use(object y)
            {
            }

            var vatId = new Zap.Rpc.Twoparty.VatId();
            use(vatId);
            var msg = new Zap.Rpc.Message();
            use(msg);
            var node = new Zap.Schema.Node();
            use(node);
            var x = Zap_test.Zap.Test.TestEnum.garply;
            use(x);
            var imp = new ZapGen.TestImport();
            use(imp);
            var imp2 = new ZapGen.TestImport2();
            use(imp2);
            var book = new ZapGen.AddressBook();
            use(book);
        }
    }
}

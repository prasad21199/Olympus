using IceHRM.GenericUtils;

namespace Olympus.TestScripts
{
    public class Check 
    {
        [Test]
        public void Test()
        {
            string path = @"./TestResources/TestData.xlsx";
            string fullPath=Path.GetFullPath(path);
            Console.WriteLine(fullPath);
        }
    }
}

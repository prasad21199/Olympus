using IceHRM.GenericUtils;

namespace Olympus.TestScripts
{
    public class Check : BaseClass
    {
        [Test]
        public void Test()
        {
            ////string path = @"TestResources/TestData.xlsx";
            ////string fullPath=Path.GetFullPath(path);
            string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string filePath = Path.Combine(projectDirectory, "TestResources", "TestData.xlsx");
            Console.WriteLine(filePath);
        }
    }
}

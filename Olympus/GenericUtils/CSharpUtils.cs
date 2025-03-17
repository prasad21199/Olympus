namespace IceHRM.GenericUtils
{
    public class CSharpUtils
    {
        public int GetRandomNumber(int range)
        {
            Random random = new Random();
            return random.Next(range);
        }
        public string GetCurrentDate()
        {
            return DateTime.Now.ToString("dd MM yyyy HH mm ss");
        }
        public string GetFullPath(string fileName)
        {
            string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string filePath = Path.Combine(projectDirectory, "TestResources", fileName);
            return filePath;
        }
        public  string GetFullPathReport(string fileName)
        {
            string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string filePath = Path.Combine(projectDirectory, "Report", fileName);
            return filePath;
        }
    }
}

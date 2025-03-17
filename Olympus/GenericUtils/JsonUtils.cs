using Newtonsoft.Json.Linq;

namespace IceHRM.GenericUtils
{
    public class JsonUtils
    {
        /// <summary>
        /// This method is used to read the data from json file
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string GetJsonData(string key)
        {
            CSharpUtils csharp = new CSharpUtils();
            string path = csharp.GetFullPath(IPathConstant.JSON_PATh);
            string file = File.ReadAllText(path);
            JToken jtoken = JToken.Parse(file);
            return jtoken[key].ToString();
        }

    }
}

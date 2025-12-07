using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.PozdeevaEA.Sprint6.Task6.V22.Lib
{
    public class DataService : ISprint6Task6V22
    {
        public string CollectTextFromFile(string path)
        {
            string result = "";

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        string firstWord = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[0];
                        result += firstWord + " ";
                    }
                }
            }

            return result.Trim();
        }
    }
}

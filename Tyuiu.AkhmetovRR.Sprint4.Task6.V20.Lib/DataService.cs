using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.AkhmetovRR.Sprint4.Task6.V20.Lib
{
    public class DataService : ISprint4Task6V20
    {
        public string[] Calculate(string[] arrayStrings)
        {
            string[] mas = Array.FindAll(arrayStrings, predmet => predmet.Length < 10);
            return mas;
        }
    }
}
using System.Text;

namespace fournine24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder picture = new StringBuilder();
            var rand = new Random();
            for (int i = 5; i < 10; i++)
            {
                for (int j = 5; j < 10; j++)
                {
                    int flag = rand.Next(2);
                    if (flag == 0)
                    {
                        picture.Append("0");
                    }
                    else picture.Append("_");
                }
                picture.Append('\n');
            }
            Console.WriteLine(picture);
            
            
        }
    }
}
using System;

namespace Blog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = Blog.Create("Заголовк", "Безумный текст");

            x = x.UpdateText("Какой-то изменненый текст");
            System.Threading.Thread.Sleep(3000);

            x = x.UpdateTitle("Безумный новый заголовок");
    

            Console.WriteLine(x.Show());
        }
    }
}

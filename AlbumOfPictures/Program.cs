using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumOfPictures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int images = 52;
            int maxImagesInRow = 3;

            int rowsFilled = images / maxImagesInRow;
            float imagesRemains = images & maxImagesInRow;

            Console.WriteLine($"Количество заполненных рядов: {rowsFilled}\n" +
                              $"Сверх мера картинок: {imagesRemains}");
        }
    }
}
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
            int albumImages = 52;
            int maxImagesInRow = 3;

            float rowsFilled = Convert.ToSingle(albumImages) / maxImagesInRow;
            float imagesRemains = rowsFilled - Convert.ToInt32(rowsFilled);

            Console.WriteLine($"Количество заполненных рядов: {Convert.ToInt32(rowsFilled)}\n" +
                              $"Сверх мера картинок: {imagesRemains}");
        }
    }
}

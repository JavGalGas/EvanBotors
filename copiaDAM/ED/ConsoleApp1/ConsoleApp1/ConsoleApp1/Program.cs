using UDK;

namespace ConsoleApp1
{
    internal class Program
    {

        public static void Filter(string fromPath, string toPath)
        {
            EditableImageHighPrecission source = new EditableImageHighPrecission(fromPath);
            EditableImageHighPrecission destination = new EditableImageHighPrecission(source.Width, source.Height);

            for (int y = 0; y < destination.Height; y++)
            {
                for (int x = 0; x < destination.Width; x++)
                {
                    destination[x, y] = source[x, y];
                }
            }

            destination.SaveToFile(toPath);
        }

        static void Main(string[] args)
        {
            Filter("C:\\Users\\asaber\\Downloads\\image.png", "C:\\Users\\asaber\\Downloads\\image2.png");
        }
    }
}
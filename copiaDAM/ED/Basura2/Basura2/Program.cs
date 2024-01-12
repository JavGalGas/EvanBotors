namespace Basura2
{
    using UDK;
    using static UDK.RoomRT;

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
                        rgba_f64 color = GetMedia(source,x, y);
                        //double aux = (color.r + color.g + color.b) / 3;
                        //color.r = aux; 
                        //color.g = aux;
                        //color.b = aux;
                        hsla_f64 hsl= color.ToHSL();
                        hsl.h += 0.0;
                        if(hsl.h > 1)
                            hsl.h -= 1;
                        destination[x, y] = hsl.ToRGBA();
                    }
                }

                destination.SaveToFile(toPath);
            }
            public static rgba_f64 GetMedia(EditableImageHighPrecission img, int x, int y)
            {
                double red = 0;
                double green = 0;
                double blue = 0;
                double alpha = 0;
                rgba_f64 color = img[x, y];
                for (int j = y-1; j < y+1; j++)
                {
                    for (int k = x-1; k < x+1 ; k++)
                    {
                        red += color.r;
                        green += color.g;
                        blue += color.b;
                        alpha += color.a;
                    }
                }
                color.r = red / 9;
                color.g = green / 9;
                color.b = blue / 9;
                color.a = alpha / 9;
                return color;
            }

            static void Main(string[] args)
            {
                Filter("C:\\Users\\javgalgas\\Downloads\\xenoverse2.png", "C:\\Users\\javgalgas\\Downloads\\xenoverse21.png");
                Filter("C:\\Users\\javgalgas\\Downloads\\ferrari.png", "C:\\Users\\javgalgas\\Downloads\\ferrari2.png");
            }
        }
    }
}
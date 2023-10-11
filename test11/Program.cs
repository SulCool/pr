using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using System.Reflection;

namespace test11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int width = 800;
            const int height = 800;

            string[] lines = File.ReadAllLines(@"B:\last pc\test2.txt");
            var vertices = new List<Vertex>();  // список вершин
            var polygons = new List<int[]>();  // список номеров полигонов
            foreach (string line in lines)
            {
                // строки с вершинами
                if (line.ToLower().StartsWith("v"))
                {
                    var vx = line.Split(' ')
                        .Skip(1)
                        .Select(v => Double.Parse(v.Replace('.', ',')))
                        .ToArray();
                    vertices.Add(new Vertex(vx[0], vx[1], vx[2]));
                }
                // строки с номерами
                else if (line.ToLower().StartsWith("f"))
                {
                    var vx = line.Split(' ', '/')
                   .Skip(1)
                   .Select(v => Int32.Parse(v))
                   .ToArray();
                   //polygons.Add(new Tuple<int, int, int>(vx[0], vx[3], vx[6]));
                    polygons.Add(new int[]{vx[0], vx[3], vx[6]});
                }
            }
            Bitmap image = new Bitmap(801, 801);
            for (int x = 0; x < image.Width; x++)
                for (int y = 0; y < image.Height; y++)
                    image.SetPixel(x, y, Color.Black);
            

            for (int i = 0; i <polygons.Count; i++)
            {
                for (int j = 0; j <3; j++)
                {
                    Vertex v0 = vertices[polygons[i][j]-1];
                    Vertex v1 = vertices[polygons[i][(j+1)%3]-1];
                    int x0 = (int)((v0.X + 1) * width / 2);
                    int x1 = (int)((v1.X + 1) * width / 2);
                    int y0 = (int)((v0.Y + 1) * height / 2);
                    int y1 = (int)((v1.Y + 1) * height / 2);
                    line(x0, y0, x1, y1, image, Color.White);
                }
            }
            image.RotateFlip(RotateFlipType.Rotate180FlipX);
            image.Save("img.bmp");



        }
        public static void line(int x0, int y0, int x1, int y1, Bitmap image, Color color)
        {
            bool steep = false;
            if (Math.Abs(x0 - x1) < Math.Abs(y0 - y1))
            {
                Swap(ref x0,ref y0);
                Swap(ref x1, ref y1);
                steep = true;
            }
            if (x0 > x1)
            {
                Swap(ref x0, ref x1);
                Swap(ref y0, ref y1);
            }
            int dx = x1 - x0;
            int dy = y1 - y0;
            int derror2 = Math.Abs(dy) * 2;
            int error2 = 0;
            int y = y0;
            for (int x = x0; x <= x1; x++)
            {
                if (steep)
                {
                    image.SetPixel(y, x, color);
                }
                else
                {
                    image.SetPixel(x, y, color);
                }
                error2 += derror2;

                if (error2 > dx)
                {
                    y += (y1 > y0 ? 1 : -1);
                    error2 -= dx * 2;
                }
            }
        }
        #region swaps
        public static void Swap(ref int x0, ref int y0)
        {
            int c = x0;
            x0 = y0;
            y0 = c;
        }
       
        #endregion
        struct Vertex
        {
            public double X { set; get; }
            public double Y { set; get; }
            public double Z { set; get; }

            public Vertex(double x, double y, double z) : this()
            {
                this.X = x;
                this.Y = y;
                this.Z = z;
            }
        }


    }
}

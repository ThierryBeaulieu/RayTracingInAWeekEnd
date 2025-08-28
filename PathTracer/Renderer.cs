using System;

namespace PathTracer;

public class Renderer
{

    public readonly int image_width = 256;
    public readonly int image_height = 256;

    public void Render()
    {
        Console.WriteLine("P3");
        Console.WriteLine(image_width + " " + image_height);
        Console.WriteLine("255");

        for (int row = 0; row < image_height; row++)
        {
            for (int col = 0; col < image_width; col++)
            {
                double r = (double)row / (image_width - 1);
                double g = (double)col / (image_height - 1);
                double b = 0.0;

                int ir = (int)(255.999 * r);
                int ig = (int)(255.999 * g);
                int ib = (int)(255.999 * b);

                Console.WriteLine(ir + " " + ig + " " + ib);
            }
        }
    }
}

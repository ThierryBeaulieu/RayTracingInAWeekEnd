using System;
using System.IO;
using Microsoft.Extensions.Logging;

namespace PathTracer;

public class Renderer(ILogger<Renderer> logger)
{
    private readonly ILogger<Renderer> _logger = logger;
    private readonly string filePath = "result.ppm";


    public readonly int image_width = 256;
    public readonly int image_height = 256;

    public void Render()
    {

        using StreamWriter writer = new(filePath);

        writer.WriteLine("P3");
        writer.WriteLine(image_width + " " + image_height);
        writer.WriteLine("255");

        for (int row = 0; row < image_height; row++)
        {
            _logger.Log(LogLevel.Debug, "ScanLines remaining " + (image_height - row));
            for (int col = 0; col < image_width; col++)
            {
                double r = (double)row / (image_width - 1);
                double g = (double)col / (image_height - 1);
                double b = 0.0;

                int ir = (int)(255.999 * r);
                int ig = (int)(255.999 * g);
                int ib = (int)(255.999 * b);

                writer.WriteLine(ir + " " + ig + " " + ib);
            }
        }
        _logger.Log(LogLevel.Debug, "Done");

    }
}

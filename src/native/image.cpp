int coord(int x, int s)
{
    return (int)(x / (float)s * 255.0);
}

extern "C" void __declspec(dllexport) GenerateImage(unsigned char* data, int width, int height)
{
    for(int y = 0; y < height; y++)
    {
        for(int x = 0; x < width; x++)
        {
            int offset = (y * width + x) * 4;
            data[offset + 0] = coord(x, width);
            data[offset + 1] = coord(y, height);
            data[offset + 2] = 0;
            data[offset + 3] = 255;
        }
    }
}
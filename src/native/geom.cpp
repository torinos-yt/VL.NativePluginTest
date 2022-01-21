#define _USE_MATH_DEFINES
#include <math.h>

extern "C" void __declspec(dllexport) GenerateVertexData(float* data, int* indices, int div)
{
    for(int i = 0; i < div; i++)
    {
        // position
        float theta = i / (float)div * M_PI * 2;
        data[i * 5 + 0] = sin(theta); // x
        data[i * 5 + 1] = cos(theta); // y
        data[i * 5 + 2] = 0;          // z

        // texture coodinate
        data[i * 5 + 3] = data[i*5+0] * .5 + .5; // u
        data[i * 5 + 4] = data[i*5+1] * .5 + .5; // v
    }

    // center point
    data[div * 5 + 0] = 0;
    data[div * 5 + 1] = 0;
    data[div * 5 + 2] = 0;
    data[div * 5 + 3] = 0.5;
    data[div * 5 + 4] = 0.5;

    //indices
    for(int i = 0; i < div; i++)
    {
        indices[i * 3 + 2] = div;
        indices[i * 3 + 1] = (i + 1) % div;
        indices[i * 3 + 0] = i;
    }
}
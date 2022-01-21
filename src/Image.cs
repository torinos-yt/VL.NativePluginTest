using System.Runtime.InteropServices;

namespace NativePlauginTest
{
    public static class Image
    {
        #pragma warning disable CA5393
        [DefaultDllImportSearchPaths(DllImportSearchPath.AssemblyDirectory)]

        [DllImport("../native/TestPluginNative.dll")]
        static extern void GenerateImage(byte[] data, int width, int height);

        public static byte[] GenarateImageData(int width = 128, int height = 128)
        {
            byte[] data = new byte[width * height * 4];
            GenerateImage(data, width, height);

            return data;
        }
    }
}

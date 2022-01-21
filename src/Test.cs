using System.Runtime.InteropServices;

namespace NativePlauginTest
{
    public static class Test
    {
        #pragma warning disable CA5393
        [DefaultDllImportSearchPaths(DllImportSearchPath.AssemblyDirectory)]

        [DllImport("../native/TestPluginNative.dll")]
        static extern float MultTest(float x, float y);

        public static int AddTest(int a, int b)
        {
            return a + b * 2;
        }

        public static float MultNative(float x, float y)
        {
            return MultTest(x, y);
        }
    }
}

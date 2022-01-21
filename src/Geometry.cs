using System.Runtime.InteropServices;

using Stride.Graphics;
using Stride.Rendering;

namespace NativePlauginTest
{
    public static class Geometry
    {
        #pragma warning disable CA5393
        [DefaultDllImportSearchPaths(DllImportSearchPath.AssemblyDirectory)]

        [DllImport("../native/TestPluginNative.dll")]
        static extern float GenerateVertexData(System.IntPtr data, int[] indices, int div);

        public static Mesh GenarateGeometry(GraphicsDevice device, int div = 3)
        {
            var mesh = new Mesh();

            if(device != null && div >= 3)
            {
                var vertices = new VertexPositionTexture[div + 1];
                var indices = new int[div * 3];
                // pinned memory position
                GCHandle handle = GCHandle.Alloc(vertices, GCHandleType.Pinned);
                
                GenerateVertexData(handle.AddrOfPinnedObject(), indices, div);

                var vertexBuffer = Buffer.Vertex.New(device, vertices, GraphicsResourceUsage.Dynamic);
                var indexBuffer = Buffer.Index.New(device, indices);

                mesh.Draw = new MeshDraw
                {
                    PrimitiveType = PrimitiveType.TriangleList,
                    DrawCount = indices.Length,
                    IndexBuffer = new IndexBufferBinding(indexBuffer, true, indices.Length),
                    VertexBuffers = new[] { new VertexBufferBinding(vertexBuffer,
                                            VertexPositionTexture.Layout, vertexBuffer.ElementCount) },
                };

                handle.Free();
            }

            return mesh;
        }
    }
}

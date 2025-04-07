using Urho;

namespace MOROPO.InfoTur.Camaguey.Rutas.Extensions
{
    public static class EasyARExtensions
    {
        public static Matrix4 ToUrhoMatrix(this EasyAR.Matrix44F matrix)
        {
            return new Matrix4(
                matrix.data_0, matrix.data_1, matrix.data_2, matrix.data_3,
                matrix.data_4, matrix.data_5, matrix.data_6, matrix.data_7,
                matrix.data_8, matrix.data_9, matrix.data_10, matrix.data_11,
                matrix.data_12, matrix.data_13, matrix.data_14, matrix.data_15);
        }

        public static Vector2 ToUrhoVector(this EasyAR.Vec2F vector)
        {
            return new Vector2(vector.data_0, vector.data_1);
        }

        public static Vector3 ToUrhoVector(this EasyAR.Vec3F vector)
        {
            return new Vector3(vector.data_0, vector.data_1, vector.data_2);
        }

        public static EasyAR.Vec2F ToEasyARVector(this Vector2 vector)
        {
            return new EasyAR.Vec2F(vector.X, vector.Y);
        }

        public static EasyAR.Vec3F ToEasyARVector(this Vector3 vector)
        {
            return new EasyAR.Vec3F(vector.X, vector.Y, vector.Z);
        }
    }
}

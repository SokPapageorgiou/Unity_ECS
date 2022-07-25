using Unity.Burst;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

namespace FirstTest
{
    [BurstCompile]
    public partial struct RotateJob : IJobEntity
    {
        public float DeltaTime;

        void Execute(ref Rotation rotation, in RotationSpeed_ForEach rotSpeed)
        {
            quaternion yRot = quaternion.RotateY(rotSpeed.RadiansPerSecond * DeltaTime);

            rotation.Value = math.mul(rotation.Value, yRot);
        }
    }
}

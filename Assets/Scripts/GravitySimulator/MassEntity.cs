using Unity.Entities;
using Unity.Mathematics;

namespace GravitySimulator
{
    [GenerateAuthoringComponent]
    public struct MassEntity : IComponentData
    {
        public float Speed;
        public float3 Direction { get; set; }

        public float3 Velocity
        {
            get => Direction * Speed;
        }
    }
}

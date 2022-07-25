using Unity.Entities;

namespace FirstTest
{
    [GenerateAuthoringComponent]
    public struct RotationSpeed_ForEach : IComponentData
    {
        public float RadiansPerSecond;
    }
}

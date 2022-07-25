using Unity.Entities;

namespace FirstTest
{
    public partial class RotateSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            new RotateJob { DeltaTime = Time.DeltaTime }.ScheduleParallel();
        }
    }
}

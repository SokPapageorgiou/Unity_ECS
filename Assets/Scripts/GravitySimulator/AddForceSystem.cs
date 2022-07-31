using Unity.Collections;
using Unity.Entities;
using Unity.Physics;
using Unity.Physics.Extensions;
using Unity.Transforms;

namespace GravitySimulator
{
    [UpdateInGroup(typeof(FixedStepSimulationSystemGroup))]
    public partial class AddForceSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            var translations =
                GetEntityQuery(typeof(MassEntity), 
                    typeof(Translation)).ToComponentDataArray<Translation>(Allocator.TempJob);

            Entities.ForEach(
                (ref PhysicsVelocity physicsVelocity,
                        ref PhysicsMass physicsMass,
                        ref MassEntity massEntity) 
                    =>
                {
                    foreach (var translation in translations) massEntity.Direction += translation.Value;
                    
                    physicsVelocity.ApplyLinearImpulse(physicsMass, massEntity.Velocity * Time.DeltaTime);
                    
                }).WithoutBurst().Run();
            
        }
    }
}

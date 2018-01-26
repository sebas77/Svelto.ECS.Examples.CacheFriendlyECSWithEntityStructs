namespace Svelto.ECS.Example.Parallelism
{
#if FOURTH_TIER_EXAMPLE
    class BoidEntityDescriptor : MixedEntityDescriptor<EntityViewStructBuilder<BoidEntityView>>
#else
    class BoidEntityDescriptor : MixedEntityDescriptor<EntityViewBuilder<BoidEntityView>>
#endif
    {}
}
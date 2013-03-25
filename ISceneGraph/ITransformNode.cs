
namespace Liu.ISceneGraph
{
    public interface ITransformNode : ISceneNode
    {
        void Apply();
        void UnApply();
    }
}

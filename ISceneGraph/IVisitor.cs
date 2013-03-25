
namespace Liu.ISceneGraph
{
    public interface IVisitor
    {
        void PreVisit(IDrawableNode drawable);
        void PreVisit(ITransformNode transform);
        void PreVisit(IStateNode state);
        void PreVisit(IGroupNode group);
        void PostVisit(IDrawableNode drawable);
        void PostVisit(ITransformNode transform);
        void PostVisit(IStateNode state);
        void PostVisit(IGroupNode group);
    }
}

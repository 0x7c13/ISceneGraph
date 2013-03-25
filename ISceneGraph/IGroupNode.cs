using System;
using System.Collections.Generic;

namespace Liu.ISceneGraph
{
    public interface IGroupNode : ISceneNode, IEnumerable<ISceneNode>
    {
        void AddChild(ISceneNode child);
    }
}

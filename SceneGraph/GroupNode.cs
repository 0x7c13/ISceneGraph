using Liu.ISceneGraph;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Liu.SceneGraphCore
{
    [Serializable()]
    internal class GroupNode : IGroupNode
    {
        #region Member variables
        private IList<ISceneNode> children = new List<ISceneNode>(8);
        #endregion

        public string Name
        {
            get;
            private set;
        }

        public void AddChild(ISceneNode child)
        {
            children.Add(child);
        }

        public void Accept(IVisitor visitor)
        {
            visitor.PreVisit(this);
            foreach (ISceneNode child in children)
                child.Accept(visitor);
            visitor.PostVisit(this);
        }

        public GroupNode(string name)
        {
            this.Name = name;
        }

    }
}

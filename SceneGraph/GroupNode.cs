using Liu.ISceneGraph;
using System;
using System.Collections;
//
//  SceneGraph
//  CSE 4253
//
//  Created by Jiaqi Liu on Mar-25 2013.
//  Copyright (c) 2013 Jiaqi Liu. All rights reserved.
//

using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Liu.SceneGraphCore
{
    [Serializable()]
    public class GroupNode : IGroupNode, IEnumerable<ISceneNode>
    {
        #region Member variables
        private IList<ISceneNode> children = new List<ISceneNode>(8);
        #endregion

        public IEnumerator<ISceneNode> GetEnumerator()
        {
            return children.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

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

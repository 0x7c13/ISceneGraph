//
//  SceneGraph
//  CSE 4253
//
//  Created by Jiaqi Liu on Mar-25 2013.
//  Copyright (c) 2013 Jiaqi Liu. All rights reserved.
//

using Liu.ISceneGraph;
using System;
using System.Runtime.Serialization;

namespace Liu.SceneGraphCore
{
    [Serializable()]
    internal class DrawMode : IStateNode
    {
        public void Accept(IVisitor visitor)
        {
            visitor.PreVisit(this);
            visitor.PostVisit(this);
        }

        public string Name
        {
            get;
            protected set;
        }

        public DrawMode (string name)
        {
            this.Name = name;
        }

        public void Apply()
        {
            System.Console.WriteLine("Applying DrawMode:", this.Name);
        }
        public void UnApply()
        {
            System.Console.WriteLine("Unapplying DrawMode:", this.Name);
        }
    }
}

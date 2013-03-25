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
    internal class Camera : ITransformNode
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

        public Camera(string name)
        {
            this.Name = name;
        }

        public void Apply()
        {
            System.Console.WriteLine("Applying Camera...");
        }
        public void UnApply()
        {
            System.Console.WriteLine("Unapplying Camera...");
        }
    }

    [Serializable()]
    internal class Perspective : ITransformNode
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

        public Perspective(string name)
        {
            this.Name = name;
        }

        public void Apply()
        {
            System.Console.WriteLine("Applying Perspective...");
        }
        public void UnApply()
        {
            System.Console.WriteLine("Unapplying Perspective...");
        }
    }

    [Serializable()]
    internal class Rotate : ITransformNode
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

        public Rotate(string name)
        {
            this.Name = name;
        }

        public void Apply()
        {
            System.Console.WriteLine("Applying Rotate...");
        }
        public void UnApply()
        {
            System.Console.WriteLine("Unapplying Rotate...");
        }
    }

    [Serializable()]
    internal class Translate : ITransformNode
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

        public Translate(string name)
        {
            this.Name = name;
        }

        public void Apply()
        {
            System.Console.WriteLine("Applying Translate...");
        }
        public void UnApply()
        {
            System.Console.WriteLine("Unapplying Translate...");
        }
    }
}

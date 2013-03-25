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
    abstract public class DrawableNodeBase : IDrawableNode
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

        public DrawableNodeBase (string name)
        {
            this.Name = name;
        }

        public abstract void Draw();
    }

    [Serializable()]
    public class Cube : DrawableNodeBase
    {
        public override void Draw()
        {
            System.Console.WriteLine("Drawing a Cube..."); ;
        }

        public Cube(string name)
            : base(name)
        {
        }
    }

    [Serializable()]
    public class Sphere : DrawableNodeBase
    {
        public override void Draw()
        {
            System.Console.WriteLine("Drawing a Sphere..."); ;
        }

        public Sphere(string name)
            : base(name)
        {
        }
    }

    [Serializable()]
    public class Building : DrawableNodeBase
    {
        public override void Draw()
        {
            System.Console.WriteLine("Drawing a Building..."); ;
        }

        public Building(string name)
            : base(name)
        {
        }
    }
   
    [Serializable()]
    public class Terrain : DrawableNodeBase
    {
        public override void Draw()
        {
            System.Console.WriteLine("Drawing a Terrain..."); ;
        }

        public Terrain(string name)
            : base(name)
        {
        }
    }

}

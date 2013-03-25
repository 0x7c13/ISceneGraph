using Liu.ISceneGraph;
using System;
using System.Runtime.Serialization;


namespace Liu.SceneGraphCore
{
    [Serializable()]
    abstract internal class DrawableNodeBase : IDrawableNode
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
    internal class Cube : DrawableNodeBase
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
    internal class Sphere : DrawableNodeBase
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
    internal class Building : DrawableNodeBase
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
    internal class Terrain : DrawableNodeBase
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

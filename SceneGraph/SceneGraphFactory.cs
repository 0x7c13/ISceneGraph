using Liu.ISceneGraph;
using Liu.SceneGraphCore;
using System;


namespace Liu.SceneGraphCore
{
    public class SceneGraphFactory : ISceneGraphFactory
    {
        public IDrawableNode CreateDrawableNode(string name, string DrawableType, object drawableData)
        {

            IDrawableNode newDrawableNode;
            switch (DrawableType)
            {
                case "Cube":
                    {
                        newDrawableNode = new Cube(name);
                        break;
                    }

                case "Sphere":
                    {
                        newDrawableNode = new Sphere(name);
                        break;
                    }

                case "Building":
                    {
                        newDrawableNode = new Building(name);
                        break;
                    }

                case "Terrain":
                    {
                        newDrawableNode = new Terrain(name);
                        break;
                    }

                default:
                    throw new ArgumentOutOfRangeException("The type " + DrawableType + " is not a recognized IDrawableNode.");
            }

            return newDrawableNode;
        }


        public IGroupNode CreateGroupNode(string name, string groupType, object groupData)
        {
            IGroupNode newGroupNode = new GroupNode(name);

            return newGroupNode;
        }
        public IStateNode CreateStateNode(string name, string stateType, object stateData)
        {
            IStateNode newStateNode = new DrawMode(name);

            return newStateNode;
        }

        public ITransformNode CreateTransformNode(string name, string transformType, object transformData)
        {
            ITransformNode newTransformNode;
            switch (transformType)
            {
                case "Camera":
                    {
                        newTransformNode = new Camera(name);
                        break;
                    }

                case "Perspective":
                    {
                        newTransformNode = new Perspective(name);
                        break;
                    }

                case "Rotate":
                    {
                        newTransformNode = new Rotate(name);
                        break;
                    }

                case "Translate":
                    {
                        newTransformNode = new Translate(name);
                        break;
                    }

                default:
                    throw new ArgumentOutOfRangeException("The type " + transformType + " is not a recognized ITransformNode.");
            }

            return newTransformNode;
        }
    }
}

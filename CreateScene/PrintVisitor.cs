//
//  CreateScene
//  CSE 4253
//
//  Created by Jiaqi Liu on Mar-25 2013.
//  Copyright (c) 2013 Jiaqi Liu. All rights reserved.
//


using Liu.ISceneGraph;

namespace Liu.SceneGraphCore
{
    class PrintVisitor : IVisitor
    {
        #region Member Variables
        string currentIndentation = "";
        string indentIncrement = " ";
        #endregion

        public virtual void PreVisit(IDrawableNode drawable)
        {
            System.Console.WriteLine(currentIndentation
            + "A Drawable of type "
            + drawable.GetType().ToString()
            + " with name: " + drawable.Name);
            currentIndentation += indentIncrement;
        }

        public virtual void PostVisit(IDrawableNode drawable)
        {
            currentIndentation = currentIndentation.Substring(0,
                currentIndentation.Length - indentIncrement.Length);
        }

        public virtual void PreVisit(ITransformNode transform)
        {
            System.Console.WriteLine(currentIndentation
            + "A Drawable of type "
            + transform.GetType().ToString()
            + " with name: " + transform.Name);
            currentIndentation += indentIncrement;
        }

        public virtual void PostVisit(ITransformNode transform)
        {
            currentIndentation = currentIndentation.Substring(0,
                currentIndentation.Length - indentIncrement.Length);
        }

        public virtual void PreVisit(IStateNode state)
        {
            System.Console.WriteLine(currentIndentation
            + "A Drawable of type "
            + state.GetType().ToString()
            + " with name: " + state.Name);
            currentIndentation += indentIncrement;
        }

        public virtual void PostVisit(IStateNode state)
        {
            currentIndentation = currentIndentation.Substring(0,
                currentIndentation.Length - indentIncrement.Length);
        }

        public virtual void PreVisit(IGroupNode group)
        {
            System.Console.WriteLine(currentIndentation
            + "A Drawable of type "
            + group.GetType().ToString()
            + " with name: " + group.Name);
            currentIndentation += indentIncrement;
        }

        public virtual void PostVisit(IGroupNode group)
        {
            currentIndentation = currentIndentation.Substring(0,
                currentIndentation.Length - indentIncrement.Length);
        }

    }
}

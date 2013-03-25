//
//  CreateScene
//  CSE 4253
//
//  Created by Jiaqi Liu on Mar-25 2013.
//  Copyright (c) 2013 Jiaqi Liu. All rights reserved.
//

using Liu.ISceneGraph;

namespace CreateScene
{
    public class SearchVisitor : IVisitor
    {
        // private fields
        private ISceneNode Result { get; set; }
        private readonly string targetName;
        bool notFound;

        public static ISceneNode Find(string targetName, ISceneNode root)
        {
            // use a private constructor to achieve the Find method
            SearchVisitor currentVisitor = new SearchVisitor(targetName, root);

            return currentVisitor.Result;
        }

        private SearchVisitor(string name, ISceneNode root)
        {
            // fields init
            this.targetName = name;
            this.Result = null;
            notFound = true;

            // search every node
            dfs(name, root);
        }

        private void dfs(string name, ISceneNode root)
        {
            // return if it's nil
            if (root == null) return;
            if (root is IGroupNode)
            {
                // check for the root
                this.CompareToTarget(root);

                // check for it's children
                foreach (ISceneNode tmpNode in (root as IGroupNode))
                {
                    if (notFound && tmpNode != null)
                    {
                        dfs(name, tmpNode);
                    }
                }
            }
        }

        private void CompareToTarget(ISceneNode node)
        {
            if (notFound && targetName == node.Name) 
            { 
                notFound = false;
                this.Result = node;
            }
        }


        #region Member Variables
        string currentIndentation = "";
        string indentIncrement = " ";
        #endregion

        public virtual void PreVisit(IDrawableNode drawable)
        {
            System.Console.WriteLine(currentIndentation
            + "Drawable Name: " + drawable.Name);
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
            + "Drawable Name: " + transform.Name);
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
            + "Drawable Name: " + state.Name);
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
            + "Drawable Name: " + group.Name);
            currentIndentation += indentIncrement;
        }

        public virtual void PostVisit(IGroupNode group)
        {
            currentIndentation = currentIndentation.Substring(0,
                currentIndentation.Length - indentIncrement.Length);
        }
    }
}

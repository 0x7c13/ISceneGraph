using Liu.ISceneGraph;

namespace Liu.SceneGraphCore
{
    class NameVisitor : IVisitor
    {
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

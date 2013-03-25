//
//  ISceneGraph
//  CSE 4253
//
//  Created by Jiaqi Liu on Mar-25 2013.
//  Copyright (c) 2013 Jiaqi Liu. All rights reserved.
//


namespace Liu.ISceneGraph
{
    public interface ISceneGraphFactory
    {
        IDrawableNode CreateDrawableNode(string name, string DrawableType, object drawableData);
        IGroupNode CreateGroupNode(string name, string groupType, object groupData);
        IStateNode CreateStateNode(string name, string stateType, object stateData);
        ITransformNode CreateTransformNode(string name, string transformType, object transformData); 
    }
}

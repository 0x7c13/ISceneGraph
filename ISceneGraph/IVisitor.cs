//
//  ISceneGraph
//  CSE 4253
//
//  Created by Jiaqi Liu on Mar-25 2013.
//  Copyright (c) 2013 Jiaqi Liu. All rights reserved.
//


namespace Liu.ISceneGraph
{
    public interface IVisitor
    {
        void PreVisit(IDrawableNode drawable);
        void PreVisit(ITransformNode transform);
        void PreVisit(IStateNode state);
        void PreVisit(IGroupNode group);
        void PostVisit(IDrawableNode drawable);
        void PostVisit(ITransformNode transform);
        void PostVisit(IStateNode state);
        void PostVisit(IGroupNode group);
    }
}

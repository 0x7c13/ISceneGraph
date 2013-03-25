//
//  ISceneGraph
//  CSE 4253
//
//  Created by Jiaqi Liu on Mar-25 2013.
//  Copyright (c) 2013 Jiaqi Liu. All rights reserved.
//


namespace Liu.ISceneGraph
{
    public interface ISceneNode
    {
        void Accept(IVisitor visitor);
        string Name { get; }
    }
}

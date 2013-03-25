//
//  ISceneGraph
//  CSE 4253
//
//  Created by Jiaqi Liu on Mar-25 2013.
//  Copyright (c) 2013 Jiaqi Liu. All rights reserved.
//


namespace Liu.ISceneGraph
{
    public interface IStateNode : ISceneNode
    {
        void Apply();
        void UnApply();
    }
}

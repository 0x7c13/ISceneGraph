//
//  ISceneGraph
//  CSE 4253
//
//  Created by Jiaqi Liu on Mar-25 2013.
//  Copyright (c) 2013 Jiaqi Liu. All rights reserved.
//

using System;
using System.Collections.Generic;

namespace Liu.ISceneGraph
{
    public interface IGroupNode : ISceneNode, IEnumerable<ISceneNode>
    {
        void AddChild(ISceneNode child);
    }
}

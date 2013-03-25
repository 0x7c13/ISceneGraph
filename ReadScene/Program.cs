//
//  ReadScene
//  CSE 4253
//
//  Description:
//  A short program to read Scene Graph from a serialized log file.
//  Deserialize and print it on the screen.
//
//  Created by Jiaqi Liu on Mar-25 2013.
//  Copyright (c) 2013 Jiaqi Liu. All rights reserved.
//


using Liu.ISceneGraph;
using Liu.SceneGraphCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace ReadScene
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {

            System.Windows.Forms.OpenFileDialog dialog = new System.Windows.Forms.OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Stream stream = File.Open(dialog.FileName, FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();
                using (stream)
                {
                    ISceneNode root = (ISceneNode)formatter.Deserialize(stream);
                    IVisitor printGraph = new NameTypeVisitor();
                    root.Accept(printGraph);
                }
            }

            // Pause
            System.Console.Read();
        }
    }
}

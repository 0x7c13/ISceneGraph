//
//  CreateScene
//  CSE 4253
//
//  Description:
//  A short program to read data from sonsole and create
//  user defined Scene Graph. Serialize it and save it 
//  on the disk, display the Scene Graph on the screen 
//  at the same time.
//
//  Created by Jiaqi Liu on Mar-25 2013.
//  Copyright (c) 2013 Jiaqi Liu. All rights reserved.
//

using Liu.ISceneGraph;
using Liu.SceneGraphCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CreateScene
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {

            List<string> SceneNodeTypes = new List<string>();
            SceneNodeTypes.Add("Cube");
            SceneNodeTypes.Add("Sphere");
            SceneNodeTypes.Add("Building");
            SceneNodeTypes.Add("Terrain");
            SceneNodeTypes.Add("Camera");
            SceneNodeTypes.Add("Perspective");
            SceneNodeTypes.Add("Rotate");
            SceneNodeTypes.Add("Translate");
            SceneNodeTypes.Add("IGroupNode");
            SceneNodeTypes.Add("IStateNode");

            List<string> DrawableTypes = new List<string>();
            DrawableTypes.Add("Cube");
            DrawableTypes.Add("Sphere");
            DrawableTypes.Add("Building");
            DrawableTypes.Add("Terrain");

            List<string> TransformTypes = new List<string>();
            TransformTypes.Add("Terrain");
            TransformTypes.Add("Camera");
            TransformTypes.Add("Perspective");
            TransformTypes.Add("Rotate");


            // init
            ISceneNode root;
            root = new GroupNode("Root");
            IVisitor printGraph = new PrintVisitor();
            root.Accept(printGraph);

            // read user input from Console
            string optionString = System.Console.ReadLine();
            while (optionString != "Exit")
            {
                if (optionString == "Add")
                {
                    bool _isLegalInput = true;
                    string tmp = System.Console.ReadLine();
                    string[] token = tmp.Split(new char[] {' '});

                    string typeOfTheCurrentNode, nameOfTheCurrentNode, nameOfTheGroupNode;
                    typeOfTheCurrentNode = token[0];
                    nameOfTheCurrentNode = token[1];
                    nameOfTheGroupNode = token[2];


                    if (!SceneNodeTypes.Contains(typeOfTheCurrentNode))
                    {
                        _isLegalInput = false;
                        throw new ArgumentOutOfRangeException("The type " + typeOfTheCurrentNode + " is not a recognized type of SceneNode.");
                    }

                    ISceneNode currentRoot = SearchVisitor.Find(nameOfTheGroupNode, root);
                    if (currentRoot == null)
                    {
                        _isLegalInput = false;
                        throw new ArgumentOutOfRangeException("The name of the Group " + nameOfTheGroupNode + " is not a recognized name of GroupNode.");
                    }

                    if (_isLegalInput)
                    {
                        ISceneGraphFactory nodeGenerator = new SceneGraphFactory();

                        if (DrawableTypes.Contains(typeOfTheCurrentNode))
                        {
                            ISceneNode newNode = nodeGenerator.CreateDrawableNode(nameOfTheCurrentNode, typeOfTheCurrentNode, null);
                            (currentRoot as GroupNode).AddChild(newNode);
                        }
                        else if (TransformTypes.Contains(typeOfTheCurrentNode))
                        {
                            ISceneNode newNode = nodeGenerator.CreateTransformNode(nameOfTheCurrentNode, typeOfTheCurrentNode, null);
                            (currentRoot as GroupNode).AddChild(newNode);
                        }
                        else if (typeOfTheCurrentNode == "IGroupNode")
                        {
                            ISceneNode newNode = nodeGenerator.CreateGroupNode(nameOfTheCurrentNode, typeOfTheCurrentNode, null);
                            (currentRoot as GroupNode).AddChild(newNode);
                        }
                        else if (typeOfTheCurrentNode == "IStateNode")
                        {
                            ISceneNode newNode = nodeGenerator.CreateStateNode(nameOfTheCurrentNode, typeOfTheCurrentNode, null);
                            (currentRoot as GroupNode).AddChild(newNode);         
                        }
                    }

                }
                optionString = System.Console.ReadLine();
            }


            // output log file
            System.Windows.Forms.SaveFileDialog dialog = new System.Windows.Forms.SaveFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Stream stream = File.Open(dialog.FileName, FileMode.Create); 
                BinaryFormatter formatter = new BinaryFormatter();
                using (stream)
                { 
                    formatter.Serialize(stream, root); 
                } 
            }

            // output sceneGraph to Console
            root.Accept(printGraph);

            // pause
            System.Console.ReadLine();
        }
    }
}

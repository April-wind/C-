using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(SceneTest))]
public class SceneEditor : Editor
{
    private void OnSceneGUI()
    {
        //得到test脚本的对象
        SceneTest test = (SceneTest) target;
        
        //绘制文本框
        Handles.Label(test.transform.position + Vector3.up * 2,
            test.transform.name + " : " + test.transform.position.ToString());
        
        //开始绘制GUI
        Handles.BeginGUI();
        
        //规定GUI显示区域
        GUILayout.BeginArea(new Rect(100,100,100,100));

        //绘制一个按钮
        if (GUILayout.Button("这是一个按钮"))
        {
            Debug.Log("SceneTest");
        }
        
        //绘制文本框
        GUILayout.Label("我在编辑Scene");
        
        GUILayout.EndArea();
        
        Handles.EndGUI();
    }
}

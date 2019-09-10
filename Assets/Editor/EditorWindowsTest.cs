using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class EditorWindowsTest : EditorWindow
{
    [MenuItem("MyMenu/OpenWindow")]
    static void OpenWindow()
    {
        //创建窗口
        Rect wr=new Rect(0,0,500,500);
        EditorWindowsTest window =
            (EditorWindowsTest)EditorWindow.GetWindowWithRect(typeof(EditorWindowsTest), wr, true, "测试窗口");
        window.Show();
    }

    //输入文字的内容
    private string text;
    //选择贴图的对象
    private Texture texture;

    public void Awake()
    {
        //在资源中读取一张贴图
        texture = Resources.Load<Texture>("1");
    }

    /// <summary>
    /// 绘制窗口时调用
    /// </summary>
    private void OnGUI()
    {
        //输入框控件
        text = EditorGUILayout.TextField("输入文字：", text);

        if (GUILayout.Button("打开通知", GUILayout.Width(200)))
        {
            //打开一个通知栏
            this.ShowNotification(new GUIContent("This is a Notification"));
        }

        if (GUILayout.Button("关闭通知", GUILayout.Width(200)))
        {
            //关闭通知栏
            this.RemoveNotification();
        }
        
        //文本框显示鼠标在窗口的位置
        EditorGUILayout.LabelField("鼠标在窗口的位置",Event.current.mousePosition.ToString());
        
        //选择贴图
        texture=EditorGUILayout.ObjectField("添加贴图",texture,typeof(Texture),true)as Texture;

        if (GUILayout.Button("关闭窗口", GUILayout.Width(200)))
        {
            //关闭窗口
            this.Close();
        }
    }

    private void OnFocus()
    {
        Debug.Log("窗口获得焦点");
    }

    private void OnLostFocus()
    {
        Debug.Log("窗口失去焦点");
    }

    private void OnHierarchyChange()
    {
        Debug.Log("Hierarchy视图中有对象发生改变");
    }

    private void OnProjectChange()
    {
        Debug.Log("Project视图中资源发生改变");
    }

    private void OnInspectorUpdate()
    {
        //窗口的刷新
        this.Repaint();
    }

    private void OnSelectionChange()
    {
        foreach (Transform t in Selection.transforms)
        {
            Debug.Log("OnSelectionChange" + t.name);
        }
    }

    private void OnDestroy()
    {
        Debug.Log("窗口关闭");
    }
}

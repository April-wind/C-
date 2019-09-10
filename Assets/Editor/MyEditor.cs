using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(EditorTest))]//对EditorTest进行操作
[ExecuteInEditMode]
public class MyEditor : Editor
{
    //重载OnInspectorGUI方法，来绘制控件
    public override void OnInspectorGUI()
    {
        //获取EditorTest类的实例
        EditorTest editorTest = (EditorTest) target;
        //绘制一个窗口
        editorTest.mRectValue = EditorGUILayout.RectField("窗口坐标", editorTest.mRectValue);
        editorTest.texture =
            EditorGUILayout.ObjectField("增加一个贴图", editorTest.texture, typeof(Texture), true) as Texture;
    }
}

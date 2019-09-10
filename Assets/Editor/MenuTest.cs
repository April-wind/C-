using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MenuTest : MonoBehaviour
{//这些方法都得是静态方法
    
    [MenuItem("MyMenu/Do Something")]
    static void DoSomething()
    {
        Debug.Log("Doing Something...");
    }

    [MenuItem("MyMenu/Log Selected Transform Name")]
    static void LogSelectedTransformName()
    {
        Debug.Log("Selected Transform is on "+ Selection.activeTransform.gameObject.name + ".");
    }
    
    [MenuItem("MyMenu/Log Selected Transform Name",true)]//使菜单项的激活情况与下面的static方法返回值关联在一起
    static bool ValidateLogSelectedTransformName()
    {
        return Selection.activeTransform != null;
    }
    
    [MenuItem("MyMenu/Do Something with a Shortcut Key %g")]//给菜单项赋予快捷键
    static void DoSomethingWithAShortcutKey()
    {
        Debug.Log("Doing Something with a Shortcut Key...");
    }

    [MenuItem("CONTEXT/Rigidbody/Double Mass")]//给组件的上下文栏加菜单项
    static void DoubleMass(MenuCommand command)
    {
        Rigidbody rigidbody = (Rigidbody) command.context;
        rigidbody.mass *= 2;
        Debug.Log("Doubled Rigidbody's Mass to " + rigidbody.mass + " from Context Menu.");
    }

    /// <summary>
    /// 增加一个菜单项来创建自定义的GameObjects
    /// </summary>
    /// <param name="command"></param>
    [MenuItem("GameObject/MyCategory/Custom Game Object",false,10)]//10表示出现的位置(行数)
    static void CreateCustomGameObject(MenuCommand command)
    {
        GameObject go = new GameObject("Custom Game Object");
        GameObjectUtility.SetParentAndAlign(go,command.context as GameObject);
        Undo.RegisterCreatedObjectUndo(go, "Create " + go.name);//?
        Selection.activeObject = go;
    }
}

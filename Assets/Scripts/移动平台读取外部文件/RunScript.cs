using System;
using UnityEngine;
using System.Collections;
using Object = UnityEngine.Object;

public class RunScript : MonoBehaviour
{
    public static string PathURL;
    private void Start()
    {   
        //不同平台下StreamingAssets的路径是不同的，这里需要注意一下。
        PathURL =
#if UNITY_ANDROID
		"jar:file://" + Application.dataPath + "!/assets/";
#elif UNITY_IPHONE
		Application.dataPath + "/Raw/";
#elif UNITY_STANDALONE_WIN || UNITY_EDITOR
            "file://" + Application.dataPath + "/StreamingAssets/";
#else
        string.Empty;
#endif    
    }
    
    void OnGUI()
    {
        if(GUILayout.Button("1 Assetbundle"))
        {
            StartCoroutine(LoadMainGameObject(PathURL + "One.assetbundle"));
        }
        if(GUILayout.Button("2 Assetbundle"))
        {
            StartCoroutine(LoadMainGameObject(PathURL +  "One 1.assetbundle"));
        }
 
        if(GUILayout.Button("ALL Assetbundle"))
        {
            StartCoroutine(LoadALLGameObject(PathURL + "ALL.assetbundle"));
        }
 
    }
 
    //读取一个资源
 
    private IEnumerator LoadMainGameObject(string path)
    {
        WWW bundle = new WWW(path);
 
        yield return bundle;
 
        //加载到游戏中
        yield return Instantiate(bundle.assetBundle.mainAsset);
 
        bundle.assetBundle.Unload(false);
    }
 
    //读取全部资源
 
    private IEnumerator LoadALLGameObject(string path)
    {
        WWW bundle = new WWW(path);
 
        yield return bundle;
 
        //通过Prefab的名称把他们都读取出来
        Object obj0 = bundle.assetBundle.LoadAsset("One");
        Object obj1 = bundle.assetBundle.LoadAsset("One 1");
 
        //加载到游戏中	
        yield return Instantiate(obj0);
        yield return Instantiate(obj1);
        bundle.assetBundle.Unload(false);
    }
 
}
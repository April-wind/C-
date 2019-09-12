using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestStreaming : MonoBehaviour
{
    private string result;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadXML());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// StreamingAssests只能用www类来读取
    /// </summary>
    /// <returns></returns>
    IEnumerator LoadXML()
    {
        string sPath = Application.streamingAssetsPath + "/Test.xml";
        WWW www = new WWW(sPath);
        yield return www;
        result = www.text;
    }
    
    private void OnGUI()
    {
        GUIStyle titleStyle = new GUIStyle();
        titleStyle.fontSize = 20;
        titleStyle.normal.textColor = new Color(46f/256f, 163f/256f, 256f/256f, 256f/256f);
        GUI.Label(new Rect(400, 10, 500, 200), result, titleStyle);
    }

}

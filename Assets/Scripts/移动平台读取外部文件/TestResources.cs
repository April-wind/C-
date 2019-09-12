using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class TestResources : MonoBehaviour
{
    private string result;
    // Start is called before the first frame update
    void Start()
    {
        LoadXML("Test");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LoadXML(string path)
    {
        result = Resources.Load(path).ToString();
        XmlDocument doc = new XmlDocument();
        doc.LoadXml(result);
    }

    private void OnGUI()
    {
        GUIStyle titleStyle = new GUIStyle();
        titleStyle.fontSize = 20;
        titleStyle.normal.textColor = new Color(46f/256f, 163f/256f, 256f/256f, 256f/256f);
        GUI.Label(new Rect(400, 10, 500, 200), result, titleStyle);
    }
}

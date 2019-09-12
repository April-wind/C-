using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        XElement result = XElement.Load("Assets/xml-to-egg/Test.xml");
        Debug.Log(result.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

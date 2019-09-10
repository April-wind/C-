using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Transform/DebugLogYourPlatform")]
public class AttributeTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.platform.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

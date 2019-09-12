using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WWWFormScore : MonoBehaviour
{
    private string url = "http://b.hiphotos.baidu.com/image/pic/item/908fa0ec08fa513db777cf78376d55fbb3fbd9b3.jpg";

    private string playNmae = "Play 1";

    IEnumerator Start()
    {
        WWWForm form = new WWWForm();
        form.AddField("playerName", playNmae);
        
        WWW download = new WWW(url, form);

        yield return download;

        if (!string.IsNullOrEmpty(download.error))
        {
            print("Error: " + download.error);
        }
        else
        {
            Debug.Log(download.text);
        }
    }
}

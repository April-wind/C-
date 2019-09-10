using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateTest : MonoBehaviour
{
    public DelegateInformation DelegateInformation;
    // Start is called before the first frame update
    void Start()
    {
        DelegateInformation = this.GetComponent<DelegateInformation>();
        DelegateInformation.Inform += GetInform1;
        DelegateInformation.Inform += GetInform2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GetInform1()
    {
        Debug.Log("1号收到信息");
    }void GetInform2()
    {
        Debug.Log("2号收到信息");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//获取游戏物体的四种方式

public class NewBehaviourScript3 : MonoBehaviour {
    public GameObject cameraMain;//1，然后进行拖拽赋值
	// Use this for initialization
	void Start () {
        print(transform.Find("GameObject (1)"));//2,该方法只能获取子物体
        print(GameObject.Find("Main Camera"));//3,该方法从全局中遍历该物体，费时
        print(GameObject.FindWithTag("Player"));//4，通过标签寻找物体，相对省时
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

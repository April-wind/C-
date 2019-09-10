using System.Collections;
using System.Collections.Generic;
using UnityEngine;//namespace

public class NewBehaviourScript : MonoBehaviour {
    public GameObject player;
	// Use this for initialization
	void Start () {
        //Transform t = GetComponent<Transform>();
        //print(t);//获取transform组件
        //Collider[] colliders = GetComponents<Collider>();//构建数组“存放”碰撞器
        //foreach(Collider a in colliders)//遍历数组
        //{
        //    print(a);
        //}//获取所有碰撞器
        // print(player.GetComponent<Rigidbody>());//获取刚体组件
        CapsuleCollider collider = GetComponent<CapsuleCollider>();
        collider.enabled = false;//这两行用于禁用组件

    }//start方法
	
	// Update is called once per frame
	void Update () {
		
	}//update方法
}//public class后面的浅蓝色字体 是类名
//组件被禁用 方法仍可调用

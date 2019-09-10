using System.Collections;
using System.Collections.Generic;
using UnityEngine;
enum RoleType
{
    Mag,
    Soldier,
    Wizard
}

public class NewBehaviourScript1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //调用方法
        //Test();
        CreateEnemy(new Vector3(1, 1, 1));
        CreateEnemy(new Vector3(3, 3, 3));
        // RoleType rt = RoleType.Mag;
    }
    //定义方法
	void Test()
    {
        print("Test方法被调用了");
    }
    void CreateEnemy(Vector3 pos)
    {
        print("创建敌人");
        print("设置敌人位置" + pos);
        print("设置敌人的初始属性");
    }
	// Update is called once per frame
	void Update () {
		
	}
}

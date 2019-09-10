using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int hp = 100;
        //利用类声明的变量，可以叫做对象
        Enemy enemy1 = new Enemy();//构造对象
        enemy1.name = "玛丽";
        print(enemy1.name);
        print(enemy1.hp);
        enemy1.move();
    }
    class Enemy
    {//public的字段(属性)才可以被对象访问
        public string name;
        public int hp;
        public void move()
        {
            Debug.Log(name + "正在移动");
        }
        public void attack()
        {
            Debug.Log(name + "正在攻击");
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

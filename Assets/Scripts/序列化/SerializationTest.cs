using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class SerializationTest : MonoBehaviour
{
    private Hero heroInstance;
    // Start is called before the first frame update
    void Start()
    {
        heroInstance = new Hero();

        heroInstance.Id = 1;
        heroInstance.Attack = 100;
        heroInstance.Defence = 1000;
        heroInstance.Name = "jj";
    }

    private void OnGUI()
    {
        if (GUILayout.Button("Save(Serialize)", GUILayout.Width(200)))
        {
            //创建文件流
            FileStream fileStream = new FileStream("HeroData", FileMode.Create);
            
            //创建格式化器
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            try
            {
                binaryFormatter.Serialize(fileStream, this.heroInstance);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                //关闭文件流
                fileStream.Close();
                
                //为了演示反序列化的结果，存储完数据后 将实例清空
                heroInstance = null;
            }
        }

        if (GUILayout.Button("Load(Deserialize)", GUILayout.Width(200)))
        {
            //从硬盘中读取流的内容
            FileStream fileStream = new FileStream("HeroData", FileMode.Open);

            try
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                this.heroInstance = (Hero) binaryFormatter.Deserialize(fileStream);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to Deserialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fileStream.Close();
                Debug.Log(this.heroInstance.Id.ToString());
                Debug.Log(this.heroInstance.Attack.ToString());
                Debug.Log(this.heroInstance.Defence.ToString());
                Debug.Log(this.heroInstance.Name);
            }
        }
    }
}



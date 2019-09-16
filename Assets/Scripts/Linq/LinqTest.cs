using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LinqTest : MonoBehaviour
{
    public string[] names = {"j", "xjq", "wz", "wl"};

    /// <summary>
    /// where的使用
    /// </summary>
    public void QueryNameByLength()
    {
        var nameWhere = names.Where((n) => { return n.Length >= 3; });
        foreach (string name in nameWhere)
        {
            Debug.Log(name + " Where筛选");
        }
    }

    /// <summary>
    /// OrderBy的使用
    /// </summary>
    public void OrderNameByLength()
    {
        var nameOrderBy = names.OrderBy((n) => { return n.Length; });
        foreach (string name in nameOrderBy)
        {
            Debug.Log(name + " OrderBy筛选");
        }
    }

    /// <summary>
    /// Select(映射)
    /// </summary>
    public void SelectName()
    {
        var nameSelect = names.Select((n) => { return n.ToUpper(); });
        foreach (string name in nameSelect)
        {
            Debug.Log(name + " Select映射");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        QueryNameByLength();   
        OrderNameByLength();
        SelectName();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

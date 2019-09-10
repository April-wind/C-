using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Hero
{
    public Hero()
    {
        
    }

    #region private
    
    private int id;
    private int attack;
    private int defence;
    private string name;
    
    #endregion

    #region public

    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public int Attack
    {
        get { return attack; }
        set { attack = value; }
    }

    public int Defence
    {
        get { return defence; }
        set { defence = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    #endregion
}

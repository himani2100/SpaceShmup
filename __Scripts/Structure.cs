using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Structure 
{
    public static Structure instance;
    void Start()
    {
        instance = this;
    }
    public string level;
    public int chosen_enemies;
    public int highscore;
    public bool[] enemies = new bool[5];

}

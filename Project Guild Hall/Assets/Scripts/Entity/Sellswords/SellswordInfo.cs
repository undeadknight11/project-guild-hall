using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// Hold the information of sellsword characters
/// </summary>
public class SellswordInfo : ScriptableObject
{
    //Character Descriptions
    public string characterName;

    [TextArea]
    public string flavorText; //Maybe they have a funny generated catchphrase or something

    [Space]
    //Character Visuals
    public RawImage characterImage;

    [Space]
    //Combat Stats
    public bool isRanged;
    public bool isMagic;

    public Dictionary<Stats, int> statDict = new Dictionary<Stats, int>();
    //[Range(0, 5)]
    //public int health;
    //[Range(0, 5)]
    //public int strength;
    //[Range(0, 5)]
    //public int accuracy;
    //[Range(0,5)]
    //public int speed;
    //[Range(0,5)]
    //public int intelligence;
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
/// <summary>
/// Generate new instances of sellsword
/// </summary>
public static class SellswordGenerator
{

    public static String[] names = new String[] { 
                            "Rebeca Mcclendon",
                            "Paulina Buchholz",
                            "Irmgard Guerriero",
                            "Carmel Leighton",
                            "Cecelia Mancilla",
                            "Leanne Lemmer",
                            "Rena Brannigan",
                            "Sina Chock",
                            "Francesco Pledger",
                            "Joanna Huckaby",
                            "Fabian Bushell",
                            "Adelle Corns",
                            "Delinda Brobst",
                            "Shelley Gilbert",
                            "Alta Manos",
                            "Cleta Wilkie",
                            "Danyelle Oland",
                            "Callie Grier",
                            "Corrinne Ocon",
                            "Mahalia Mineo"   };


    //Generates a new sellsword and returns it
    public static SellswordInfo GenerateNew()
    {

        SellswordInfo newInfo = (SellswordInfo) ScriptableObject.CreateInstance(typeof(SellswordInfo));


        //Add the random stats to the instance
        newInfo.characterName = names[UnityEngine.Random.Range(0,names.Length - 1)];

        //newInfo.characterImage = "";
        newInfo.isMagic = UnityEngine.Random.value > 0.5f;
        newInfo.isRanged = UnityEngine.Random.value > 0.5f;
        
        List<Stats> keys = new List<Stats>(newInfo.statDict.Keys);
        foreach (Stats stat in Enum.GetValues(typeof(Stats)).Cast<Stats>())
        {
            newInfo.statDict.Add(stat, UnityEngine.Random.Range(0, 5));
        }


        return newInfo;
    }
}

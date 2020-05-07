using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
/// <summary>
/// Generate new instances of quests
/// </summary>
public class QuestGenerator : MonoBehaviour
{

    public String[] names = new String[] { 
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


    //Generates a new quest and returns it
    public QuestInfo GenerateNew()
    {

        QuestInfo newInfo =   (QuestInfo) ScriptableObject.CreateInstance(typeof(QuestInfo));


        //Add the random stats to the instance
        newInfo.description = names[UnityEngine.Random.Range(0,names.Length - 1)];

        foreach (Stats stat in Enum.GetValues(typeof(Stats)).Cast<Stats>())
        {
            newInfo.statRequirements.Add(stat, UnityEngine.Random.Range(0, 5));
        }
        
        //TODO based off statRequirements, bump up rewards
        //foreach (Stats stat in Enum.GetValues(typeof(Stats)).Cast<Stats>())
        //{
        //    newInfo.statRequirements.Add(stat, UnityEngine.Random.Range(0, 5));
        //}


        return newInfo;
    }
}

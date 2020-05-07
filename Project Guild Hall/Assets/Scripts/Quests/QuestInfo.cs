using System.Collections;
using System.Collections.Generic;
using UnityEngine;
///<summary>
/// Manages any basic data for quests
///</summary>

[CreateAssetMenu(fileName = "QuestInfo", menuName = "Project Guild Hall/QuestInfo", order = 0)]
public class QuestInfo : ScriptableObject 
{
    public string description;

    public int difficulty;
    //Percentage success based off the closeness to this value
    public Dictionary<Stats, int> statRequirements = new Dictionary<Stats, int>();

    //Not sure exactly the values for this yet
    public Dictionary<Rewards, int> rewards = new Dictionary<Rewards, int>();

     
}

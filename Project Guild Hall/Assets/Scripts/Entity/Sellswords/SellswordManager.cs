using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// Manages the sellsword data
/// </summary>
public class SellswordManager : MonoBehaviour
{

    private List<SellswordInfo> sellswordList = new List<SellswordInfo>();
    public GameObject sellswordPanelPrefab;
    public GameObject sellswordCanvas;

    public void DisplaySellsword(SellswordInfo info)
    {
        var temp = Instantiate(sellswordPanelPrefab);
        temp.GetComponentInChildren<Text>().text = info.characterName +
                                            "\n\nHealth: " + info.statDict[Stats.Health] +
                                           "\nStrength: " + info.statDict[Stats.Strength] +
                                           "\nRange: " + info.statDict[Stats.Range] +
                                           "\nAccuracy: " + info.statDict[Stats.Accuracy] +
                                           "\nIntelligence: " + info.statDict[Stats.Intelligence];

        temp.transform.parent = sellswordCanvas.transform;
    }

    public void AddNew()
    {
        SellswordInfo temp = SellswordGenerator.GenerateNew();
        DisplaySellsword(temp);
        sellswordList.Add(temp);
    }
}

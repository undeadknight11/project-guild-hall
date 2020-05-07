using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal.Profiling.Memory.Experimental;
using UnityEngine;
using UnityEngine.UI;

public class QuestPostingUI : MonoBehaviour
{
    private QuestManager qManager;
    public List<SellswordInfo> sellswordList = new List<SellswordInfo>();
    public GameObject ssPrefab;

    public void Awake()
    {
        qManager = FindObjectOfType<QuestManager>();
    }

    public void AddSellsword(SellswordInfo info)
    {
        sellswordList.Add(info);
        var temp = Instantiate(ssPrefab);
        temp.transform.parent = gameObject.GetComponentInChildren<HorizontalLayoutGroup>().gameObject.transform;
    }

    //Comes from button click and triggers StartQuest() in manager
    public void TryQuest()
    {
        if(!qManager.StartQuest(gameObject))
        {
            Debug.LogError("Couldnt start quest");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// Manages the sellsword data
/// </summary>

[RequireComponent(typeof(QuestGenerator))]
public class QuestManager : MonoBehaviour
{
    //List to be populated as clients give new quests
    private Dictionary<QuestInfo, GameObject> questList = new Dictionary<QuestInfo, GameObject>();

    //Visual representation for the quests
    public GameObject questPrefab;
    public GameObject questGeneratorCanvas;

    //Event to start questing
    //public Event Questing;
    //public Questing quest; 

    //Required
    private QuestGenerator qGenerator;

    public void Start()
    {
        qGenerator = GetComponent<QuestGenerator>();
    }
    
    //create visual representation of quest and store information
    public void DisplayQuest(QuestInfo info)
    {
        var temp = Instantiate(questPrefab);
        temp.GetComponentInChildren<Text>().text = info.description;
        questList.Add(info, temp);
        temp.transform.parent = questGeneratorCanvas.transform;
    }

    //Add new quest info
    public void AddNew()
    {
        QuestInfo temp = qGenerator.GenerateNew();
        DisplayQuest(temp);
    }

    //Get sellswords and start Coroutine
    public bool StartQuest(GameObject go)
    {
        //Do necessary things before questing

        //Check if possible

        //Remove sellsword from list of available
        
        StartCoroutine(Questing(go));
        return true;
    }

    IEnumerator Questing(GameObject go)
    {
        //TODO set fill time to time specified by QuestInfo
        for (float fill = 0; fill <= 5f; fill += Time.deltaTime)
        {
            // here you can adjust the image fill amount or the slider value
            go.GetComponentInChildren<Slider>().value = ExtensionMethods.Remap(fill, 0, 5, 0, 1);
            yield return null;
        }

        //After slider is finished
        Destroy(go);
    }
}

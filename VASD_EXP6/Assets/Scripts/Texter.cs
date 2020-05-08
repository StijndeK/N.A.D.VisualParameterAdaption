using UnityEngine;
using UnityEngine.UI;

// sets text on layer boxes
public class Texter : MonoBehaviour
{
    Text txt;
    public int boxNumber;
    public int duplicateNumb;

    GameObject spawnerSystem;

    void Start()
    {        
        txt = gameObject.GetComponent<Text>();
        spawnerSystem = GameObject.FindGameObjectWithTag("spawncomponent");
        boxNumber = spawnerSystem.GetComponent<SpawnerSystem>().currentLayer;
        txt.text = "Layer: " + boxNumber.ToString();

        // TODO: use vectors instead of lists
        while(spawnerSystem.GetComponent<SpawnerSystem>().duplicates.Count < boxNumber)
        {
            spawnerSystem.GetComponent<SpawnerSystem>().duplicates.Add(0);
        }
        spawnerSystem.GetComponent<SpawnerSystem>().duplicates[boxNumber - 1] += 1;

        duplicateNumb = spawnerSystem.GetComponent<SpawnerSystem>().duplicates[boxNumber - 1];

        SoundSystem.layerActiveChecks[boxNumber - 1] = 1;
    }
}

using System.Collections.Generic;
using UnityEngine;

public class SpawnerSystem : MonoBehaviour
{
    public int currentLayer;
    public List<int> duplicates;

    public void SpawnBoxes()
    {
        for (int i = 0; i < AutoFileLoader.layerAmount; i++)
        {
            gameObject.GetComponentInChildren<SpawnControl>().SpawnBox();
        }
    }
}

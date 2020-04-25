﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// calls boxes to be spawned in spawncontrol
public class SpawnerSystem : MonoBehaviour
{
    GameObject soundSystemObject;

    // value for setting correct layer when adding a box
    public int currentLayer;
    public List<int> duplicates;

    public void SpawnBoxes()
    {
        soundSystemObject = GameObject.FindGameObjectWithTag("controler");

        // create boxes
        for (int i = 0; i < soundSystemObject.GetComponent<SoundSystem>().layerAmount; i++)
        {
            gameObject.GetComponentInChildren<SpawnControl>().SpawnBox();
        }
    }
}

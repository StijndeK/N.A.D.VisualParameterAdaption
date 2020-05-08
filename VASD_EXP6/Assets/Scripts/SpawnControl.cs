using UnityEngine;

public class SpawnControl : MonoBehaviour
{
    public GameObject toBeSpawned;
    float spawnPositionY = -70;

    public void SpawnBox()
    {
        GameObject Box = Instantiate(toBeSpawned, new Vector3(-150, spawnPositionY - 40, 0), Quaternion.identity) as GameObject;

        Box.transform.SetParent(GameObject.FindGameObjectWithTag("spawncomponent").transform, false);

        spawnPositionY += 40;
    }
}

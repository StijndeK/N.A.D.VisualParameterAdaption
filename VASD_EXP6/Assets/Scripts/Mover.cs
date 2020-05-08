using UnityEngine;

public class Mover : MonoBehaviour
{
    bool moveState;

    GameObject sequencerSystemObject;
    readonly int xPosition = 90;
    readonly int yPosition = 20;
    readonly int boxSize = 10;

    void Start()
    {
        sequencerSystemObject = GameObject.FindGameObjectWithTag("sequencer");
    }

    void Update()
    {
        // TODO: only set position when object gets moved or grid size changes. so move setposition to sequencer class, which listens to grid or movement changes
        SetPosition();

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 cords = transform.position;
            cords[0] += xPosition;
            cords[1] -= yPosition;

            // start movestate
            if (Input.mousePosition[0] <= cords[0] + boxSize && Input.mousePosition[0] >= cords[0] - boxSize && Input.mousePosition[1] <= cords[1] + boxSize && Input.mousePosition[1] >= cords[1] - boxSize)
            {
                moveState = true;
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            moveState = false;
        }
        if (moveState == true)
        {
            Vector3 mouseCords = Input.mousePosition;
            mouseCords[0] -= xPosition;
            mouseCords[1] += yPosition;
            transform.position = mouseCords;
        }
    }
 
    void SetPosition()
    {
        sequencerSystemObject.GetComponent<SequencerSystem>().get2dLayerParameter(gameObject.GetComponentInChildren<Texter>().boxNumber, new float[] { transform.position[0], transform.position[1] }, gameObject.GetComponentInChildren<Texter>().duplicateNumb);
    }
}

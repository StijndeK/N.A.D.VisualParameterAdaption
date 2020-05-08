using UnityEngine;
using UnityEngine.UI;

public class ManagerTexter : MonoBehaviour
{
    Text txt;
    public int boxNumber;

    GameObject soundSystemObject;

    private void Start()
    {
        soundSystemObject = GameObject.FindGameObjectWithTag("controler");
        txt = gameObject.GetComponent<Text>();
        boxNumber = soundSystemObject.GetComponent<SoundSystem>().SetBoxText();
        txt.text = "Layer: " + boxNumber.ToString();
    }
}

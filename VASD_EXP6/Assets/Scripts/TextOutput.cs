using UnityEngine;
using UnityEngine.UI;

public class TextOutput : MonoBehaviour
{
    public int type;

    void Update()
    {
        // on 0: files loaded, on 2: terminal output
        // would be much quicker using pointers when converting to C++
        gameObject.GetComponent<Text>().text = (type == 0) ? AutoFileLoader.textForOutput : SoundSystem.textForOutput;
    }
}

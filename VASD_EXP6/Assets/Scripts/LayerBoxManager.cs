using UnityEngine;
using UnityEngine.UI;

public class LayerBoxManager : MonoBehaviour
{
    public Button removeButton;

    void Start()
    {
        removeButton.onClick.AddListener(RemoveButtonPressed);
    }

    private void RemoveButtonPressed()
    {
        Destroy(gameObject);
        //TODO: remove layer from duplicates list (use vectors)
    }
}

using UnityEngine;
using UnityEngine.UI;

public class GridManager : MonoBehaviour
{
    public int rows = 2;
    public int cols = 2;

    public float tileSizeRows = 100;
    public float tileSizeCols = 100;

    private readonly float componentWidth = 1078;
    private readonly float componentHeight = 431;

    public Button addXButton;
    public Button addYButton;
    public Button minXButton;
    public Button minYButton;

    public GameObject gridSize;

    void Start()
    {
        addXButton.onClick.AddListener(AddXButtonPressed);
        addYButton.onClick.AddListener(AddYButtonPressed);
        minXButton.onClick.AddListener(MinXButtonPressed);
        minYButton.onClick.AddListener(MinYButtonPressed);

        GenerateGrid();
    }

    private void MinYButtonPressed()
    {
        if (rows > 2)
        {
            rows -= 1;
            foreach (Transform child in gridSize.transform)
            {
                Destroy(child.gameObject);
            }
            SequencerSystem.parameterSettingSliderY.maxValue -= 1;
            GenerateGrid();
        }
    }

    private void MinXButtonPressed()
    {
        if (cols > 2)
        {
            cols -= 1;
            foreach (Transform child in gridSize.transform)
            {
                Destroy(child.gameObject);
            }
            SequencerSystem.parameterSettingSliderX.maxValue -= 1;
            GenerateGrid();
        }
    }

    private void AddYButtonPressed()
    {
        rows += 1;
        foreach (Transform child in gridSize.transform)
        {
            Destroy(child.gameObject);
        }
        SequencerSystem.parameterSettingSliderY.maxValue += 1;
        GenerateGrid();
    }

    private void AddXButtonPressed()
    {
        cols += 1;
        foreach (Transform child in gridSize.transform)
        {
            Destroy(child.gameObject);
        }
        SequencerSystem.parameterSettingSliderX.maxValue += 1;
        GenerateGrid();
    }

    private void GenerateGrid()
    {
        tileSizeRows = componentWidth / cols;
        tileSizeCols = componentHeight / rows;

        // Scale tile to tilesize
        GameObject referenceTile = (GameObject)Instantiate(Resources.Load("LayerRoom"));
        referenceTile.transform.localScale = new Vector2(tileSizeRows / 100, tileSizeCols / 100);

        // for every cell create and set position
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                // create dynamic position
                float posX = col * tileSizeRows;
                float posY = row * -tileSizeCols;

                // account for middle pivot
                posX += tileSizeRows / 2;
                posY -= tileSizeCols / 2;

                // spawn cell
                GameObject Box = Instantiate(referenceTile, new Vector3(posX, posY, 0), Quaternion.identity) as GameObject;
                Box.transform.SetParent(GameObject.FindGameObjectWithTag("gridSize").transform, false);
            }
        }
    }
}

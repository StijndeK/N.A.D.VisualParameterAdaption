using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SequencerSystem : MonoBehaviour
{
    public static Slider parameterSettingSliderX;
    public static Slider parameterSettingSliderY;

    // TODO: create seperate class voor x and y parameters instead of all these lists
    public static List<List<List<int>>> parameters3d = new List<List<List<int>>> { new List<List<int>>(), new List<List<int>>() }; // list to hold per parameter, per layer, per duplicate: if there is a layerbox and what value it has
    readonly int[] stepAmounts = {1, 1};
    readonly List<int> intervals = new List<int> {0, 0};
    readonly List<int> initialPositions = new List<int> { 0,0};

    private void Start()
    {
        parameterSettingSliderX = GameObject.Find("SliderX").GetComponent<Slider>();
        parameterSettingSliderY = GameObject.Find("SliderY").GetComponent<Slider>();
    }

    public void get2dLayerParameter(int layer, float[] positions, int duplicateNumber) // called from mover when object is moved
    {
        intervals[0] = (int)gameObject.GetComponentInChildren<GridManager>().tileSizeRows;
        intervals[1] = (int)gameObject.GetComponentInChildren<GridManager>().tileSizeCols;

        // set initial positions (account for intial offset)
        initialPositions[0] = intervals[0] + 200;
        initialPositions[1] = intervals[1] + 27;

        stepAmounts[0] = gameObject.GetComponentInChildren<GridManager>().rows;
        stepAmounts[1] = gameObject.GetComponentInChildren<GridManager>().cols;

        for (int xy = 0; xy < 2; xy++)
        {
            // sets to what value(s) a layer belongs
            int param = 0;
            for (int step = 0; step < stepAmounts[xy]; step++)
            {
                if (positions[xy] >= initialPositions[xy] + (step * intervals[xy]))
                {
                    param += 1;
                }
            }
            parameters3d[xy][layer - 1][duplicateNumber - 1] = param;
        }
    }

    public static bool CheckIfLayerShouldPlay(int layer)
    {
        for (int i = 0; i < parameters3d[0][layer].Count; i++)
        {
            if (parameters3d[0][layer][i] == (int)parameterSettingSliderX.value && parameters3d[1][layer][i] == (int)parameterSettingSliderY.value)
            {
                return true;
            }
        }
        return false;
    }
}
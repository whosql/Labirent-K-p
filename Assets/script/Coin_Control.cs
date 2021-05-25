using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Coin_Control : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI textMesh;
    public int coinScore;
    public int coinValue;
    public void GoalReached(float uiDelay)
    {
        coinScore += coinValue;

    }
    void reset()
    {
        coinScore = 0;
    }
    // Update is called once per frame
    void Update()
    {
      textMesh.text = coinScore.ToString();
    }
}

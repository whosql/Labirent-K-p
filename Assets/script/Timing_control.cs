using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timing_control : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody startingMarble;
    public TextMeshProUGUI textMesh;
    bool m_IsTiming;
    public float timer;
    void Start()
    {
      startingMarble.isKinematic = false;
        m_IsTiming = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (m_IsTiming)
            timer += Time.deltaTime;

        textMesh.text = timer.ToString("0.00");
    }
    
    public void GoalReached(float uiDelay)
    {
        m_IsTiming = false;

    }
}

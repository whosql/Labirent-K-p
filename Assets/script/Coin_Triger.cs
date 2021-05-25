using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Triger : MonoBehaviour
{
    // Start is called before the first frame update
    public float uiDelay = 3f;
    public Collider marble;
    public Coin_Control coin_control;

    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 90) * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other == marble)
        {
            coin_control.GoalReached(uiDelay);
            Destroy(this.gameObject);
        }
    }
}

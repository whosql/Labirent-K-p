using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RESET : MonoBehaviour
{
    // Start is called before the first frame update
    bool Resetstop2;
    public void reset_button()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

}

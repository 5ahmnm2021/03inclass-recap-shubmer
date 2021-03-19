using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChange : MonoBehaviour
{
    public Image farbe;
    private int zahl;

    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            zahl = Random.Range(0, 4);
            Debug.Log(zahl);

            if(zahl == 0)
            {
                farbe.color = new Color32(255, 205, 25, 100);
            }

            if (zahl == 1)
            {
                farbe.color = new Color32(95, 34, 0, 100);
            }

            if (zahl == 2)
            {
                farbe.color = new Color32(207, 63, 21, 100);
            }

            if (zahl == 3)
            {
                farbe.color = new Color32(102, 47, 84, 100);
            }
        }

    }
}

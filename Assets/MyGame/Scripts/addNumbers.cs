using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class addNumbers : MonoBehaviour
{
    

    public InputField input1;
    public InputField input2;
    public Text summe;
    public Text ausgabe;

    private Color rot = Color.red;
    private Color weiss = Color.white;

    public float field1Float;
    public float field2Float;

    public void Iwas()
    {
        try
        {
            field1Float = float.Parse(input1.text);
            input1.image.color = weiss;
            ausgabe.text = "";
        }
        catch (System.Exception)
        {
            ausgabe.text = "Geben Sie eine gültige Zahl ein";
            input1.image.color = rot;
        }

        try
        {
            field2Float = float.Parse(input2.text);
            input2.image.color = weiss;
        }
        catch (System.Exception)
        {
            ausgabe.text = "Geben Sie eine gültige Zahl ein";
            input2.image.color = rot;
        }

        summe.text = (field1Float + field2Float).ToString();
        Debug.Log("Ergebnis: " + summe.text);
    }
    


}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddNumbers : MonoBehaviour
{
    public InputField input1;
    public InputField input2;
    public Text summe;
    public Text ausgabe;

    public void Iwas()
    {
        string Errormsg = "Geben Sie eine gültige Zahl ein";
        float field1Float = 0;
        float field2Float = 0;

        bool num1 = true;
        bool num2 = true;

        try
        {
            field1Float = float.Parse(input1.text);
            input1.image.color = Color.white;
        }
        catch (System.Exception)
        {
            ausgabe.text = Errormsg;
            input1.image.color = Color.red;
            num1 = false;
        }

        try
        {
            field2Float = float.Parse(input2.text);
            input2.image.color = Color.white;
        }
        catch (System.Exception)
        {
            ausgabe.text = Errormsg;
            input2.image.color = Color.red;
            num2 = false;
        }

        if (num1 && num2)
        {
            summe.text = (field1Float + field2Float).ToString();
            Debug.Log("Ergebnis: " + summe.text);
        }
        
        else{
            summe.text = "/";
        }

        
    }
}
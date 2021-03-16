using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class addNumbers : MonoBehaviour
{
    /*public InputField Input1;
    public InputField Input2;
    public Text ErgebnisText;
    public Text ZustandText;*/

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
        //Debug.Log("Die Addition ergibt: " + summe.text);
    }
    

    /* public void AddNumbersOnClick()
    {
       string TextInput1 = Input1.text;
       int result = 0;

       if(int.TryParse(TextInput1, out result))
       {

       } 
       else 
       {
           Input1.text = "Enter a valid number!"
           Input1.image.color = Color.red;
       }

        string TextInput2 = Input2.text;
       int result2 = 0;

       if(int.TryParse(TextInput2, out result2))
       {

       } 
       else 
       {
           Input2.text = "Enter a valid number!"
           Input2.image.color = Color.red;
       }

       float num1 = float.Parse(Input1.text);
        float num2 = float.Parse(Input2.text);
        float Result = num1 + num2;
        ErgebnisText.text = Result.ToString();
    }*/

}
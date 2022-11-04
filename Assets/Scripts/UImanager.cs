using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UImanager : MonoBehaviour
{
    static UImanager instance = null;
    public static UImanager Instance { get => instance; }


    public TMP_InputField time_inputField;
    public TMP_InputField speed_inputField;
    public TMP_InputField distance_inputField;

    public float time_Convert;
    public float speed_Convert;
    public float distance_Convert;


    System.Globalization.NumberStyles style;
    System.Globalization.CultureInfo culture;
   



    void Awake()
    {
        StartingData();
        ConvertToFloat();
        OpenUImanager();
    }

    void Update()
    {
        ConvertToFloat();
        
    }

    public void OpenUImanager()
    {
        if (instance == null)  
        { 
            instance = this; 
        }
        else if (instance == this)
        { 
            Destroy(gameObject); 
        }
        DontDestroyOnLoad(gameObject); 
    }


    public void DataReset()
    {
        StartingData();
    }



    public void ConvertToFloat()
    {
        style = System.Globalization.NumberStyles.Number;
        culture = System.Globalization.CultureInfo.CreateSpecificCulture("en-GB");

        float.TryParse(time_inputField.text, style, culture, out time_Convert);
        float.TryParse(speed_inputField.text, style, culture, out speed_Convert);
        float.TryParse(distance_inputField.text, style, culture, out distance_Convert);

    }

    public void StartingData()
    {
        time_inputField.text = "3";
        speed_inputField.text = "4";
        distance_inputField.text = "10";
    }
    


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnTrigger2 : MonoBehaviour
{
    public Text textpoin2;
    void OnTriggerEnter(Collider col)
    {
        switch (col.gameObject.name)
        {
            case "21":
                textpoin2.text = "1";
                break;
            case "22":
                textpoin2.text = "2";
                break;
            case "23":
                textpoin2.text = "3";
                break;
            case "24":
                textpoin2.text = "4";
                break;
            case "25":
                textpoin2.text = "5";
                break;
            case "26":
                textpoin2.text = "6";
                break;

        }
    
    }

}

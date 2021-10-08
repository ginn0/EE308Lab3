using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnTrigger6 : MonoBehaviour
{
    public Text textpoin6;
    void OnTriggerEnter(Collider col)
    {
        switch (col.gameObject.name)
        {
            case "61":
                textpoin6.text = "1";
                break;
            case "62":
                textpoin6.text = "2";
                break;
            case "63":
                textpoin6.text = "3";
                break;
            case "64":
                textpoin6.text = "4";
                break;
            case "65":
                textpoin6.text = "5";
                break;
            case "66":
                textpoin6.text = "6";
                break;

        }

    }

}

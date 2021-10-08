using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnTrigger4 : MonoBehaviour
{
    public Text textpoin4;
    void OnTriggerEnter(Collider col)
    {
        switch (col.gameObject.name)
        {
            case "41":
                textpoin4.text = "4";
                break;
            case "42":
                textpoin4.text = "2";
                break;
            case "43":
                textpoin4.text = "3";
                break;
            case "44":
                textpoin4.text = "4";
                break;
            case "45":
                textpoin4.text = "5";
                break;
            case "46":
                textpoin4.text = "6";
                break;

        }

    }

}

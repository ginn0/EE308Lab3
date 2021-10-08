using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnTrigger3 : MonoBehaviour
{
    public Text textpoin3;
    void OnTriggerEnter(Collider col)
    {
        switch (col.gameObject.name)
        {
            case "31":
                textpoin3.text = "1";
                break;
            case "32":
                textpoin3.text = "2";
                break;
            case "33":
                textpoin3.text = "3";
                break;
            case "34":
                textpoin3.text = "4";
                break;
            case "35":
                textpoin3.text = "5";
                break;
            case "36":
                textpoin3.text = "6";
                break;

        }

    }

}

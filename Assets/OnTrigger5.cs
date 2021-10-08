using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnTrigger5 : MonoBehaviour
{
    public Text textpoin5;
    void OnTriggerEnter(Collider col)
    {
        switch (col.gameObject.name)
        {
            case "51":
                textpoin5.text = "1";
                break;
            case "52":
                textpoin5.text = "2";
                break;
            case "53":
                textpoin5.text = "3";
                break;
            case "54":
                textpoin5.text = "4";
                break;
            case "55":
                textpoin5.text = "5";
                break;
            case "56":
                textpoin5.text = "6";
                break;

        }

    }

}

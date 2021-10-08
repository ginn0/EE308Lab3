using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnTrigger : MonoBehaviour {
    public Text textpoin1;
    void OnTriggerEnter(Collider col)
    {
       
            switch (col.gameObject.name)
            {
                case "11":
                    textpoin1.text = "1";
                    break;
                case "12":
                    textpoin1.text = "2";
                    break;
                case "13":
                    textpoin1.text = "3";
                    break;
                case "14":
                    textpoin1.text = "4";
                    break;
                case "15":
                    textpoin1.text = "5";
                    break;
                case "16":
                    textpoin1.text = "6";
                    break;

            }

    }

   }

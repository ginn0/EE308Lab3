using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NewBehaviourScript : MonoBehaviour {
    public Rigidbody Rig;//获得刚体
    public Button Button_AddTorque_vector;//给骰子添加扭曲力的按钮

    public float a;
	// Use this for initialization
	void Start () {
        Button_AddTorque_vector.onClick.AddListener(OnRigVector);

	}
	
    public void OnRigVector()
    {
        float x = Random.Range(0, 100);
        float y = Random.Range(0, 100);
        float z = Random.Range(0, 100);
        Rig.transform.position = new Vector3(0, 4 ,-1 );//下落位置
        Rig.AddTorque(x, y, z);//扭曲的力
        transform.localEulerAngles = new Vector3(0, 90, 0);
    }

}

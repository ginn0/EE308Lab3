using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Start : MonoBehaviour {

	public void On_Start()
    {
        SceneManager.LoadScene(1);//切换到S1

    }
    public void On_Quit()
    {
        Application.Quit();
    }
    public void OnExit()
    {
        SceneManager.LoadScene(0);

    }
}

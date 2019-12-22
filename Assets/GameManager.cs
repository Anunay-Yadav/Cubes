using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public bool flag = false;
	// Use this for initialization
    public void restart()
    {
        Application.LoadLevel(0);

    }
    public void Touch()
    {
        if (!flag)
        {
            if (Input.touchCount > 0)
            {
                Time.timeScale = 1;
                flag = true;
            }
        }
    }
    public void gamestart()
    {
        Time.timeScale = 0;
        Touch();
    }
    void Start()
    {
        gamestart();    
    }
    // Update is called once per frame
    void Update () {
		
	}
}

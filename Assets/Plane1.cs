using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Plane1 : MonoBehaviour {
    public bool flag = false;
	// Use this for initialization
	void Start () {
		
	}
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Cube")
        {
            flag = false;
            Time.timeScale = 0;
        }
    }
    public void Touch()
    {
        if (Time.timeScale == 0)
        {
            if (Input.touchCount > 0)
            {
                Debug.Log("plane1");
                Application.LoadLevel("SampleScene");
                Time.timeScale = 1;
                Score.temp = 0;

            }
        }
    }
    // Update is called once per frame
    void Update () {
        Touch();

    }
}

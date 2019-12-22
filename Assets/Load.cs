using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Load : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Scene s = SceneManager.GetActiveScene();
        if(s.name != "SampleScene")
        {
            
        }
	}
}

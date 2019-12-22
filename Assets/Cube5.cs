using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube5 : MonoBehaviour {

    // Use this for initialization
    void generate()
    {
        System.Random l = new System.Random();
        float x = l.Next(-23, 4);
        float z = l.Next(15, 23);
        transform.position = new Vector3(x, transform.position.y, z);

    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Cube")
        {
            Score.scorevalue += 1;
            generate();
        }
    }
    void Start () {
        generate();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

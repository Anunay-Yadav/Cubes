using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cube1 : MonoBehaviour {
    public Cube2 cube2;

    public float movespeed;
    public float realz;
    public bool flag;
    public int k;
    public bool flag1;
    public float initialx;
    public float initialy;
    public float initialz;
    public float prev = 0;

    public float zupdatex;

    // Use this for initialization
    void Start()
    {
        realz = transform.position.z;
        initialz = realz;
        initialx = transform.position.x;
        initialy = transform.position.y;
        Random.seed = 22;
        System.Random rn = new System.Random();
        k = rn.Next(2, 20);
        movespeed = 6;
        cube2 = GameObject.Find("Cube2").GetComponent<Cube2>();
        flag = false;
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
                Debug.Log("cube1");
                Application.LoadLevel("SampleScene");
                Time.timeScale = 1;
                Score.temp = 0;
                prev = 0;

            }
        }
    }


    // Update is called once per frame
    void Update()
    {
        Touch();
 
        System.Random rn = new System.Random();
        if (Mathf.Abs(transform.position.z - cube2.transform.position.z) > 53)
        {

            transform.Translate(0f, 0f, -1f * Time.deltaTime * k);
            return;
        }
        if (prev != 0)
        {
            movespeed += (Score.temp - prev) / 30f;
            prev = Score.temp;
        }
        else
            prev = Score.temp;
        if (transform.position.x > -15)
        {
            transform.Translate(-1f * Time.deltaTime * movespeed, 0f, 0f);
        }
        else
        {
            k = rn.Next(2, 20);
            transform.position = new Vector3(26.3f, initialy, initialz);
        }
    }
}

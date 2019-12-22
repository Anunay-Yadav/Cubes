using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cube4 : MonoBehaviour {

    public Cube3 cube3;
    public float initialx;
    public float initialy;
    public float initialz;
    public float movespeed;
    public float realz;
    public bool flag;
    public float prev = 0;
    public GameObject m;

    public int k;
    public bool flag1 = false;
    // Use this for initialization
    void Start () {
        realz = transform.position.z;
        initialz = realz;
        initialx = transform.position.x;
        initialy = transform.position.y;
        realz = transform.position.z;
        Random.seed = 32;
        System.Random rn = new System.Random();
        movespeed = 6;
        k = rn.Next(2, 20);
        cube3 = GameObject.Find("Cube3").GetComponent<Cube3>();
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
                Debug.Log("cube4");
                Application.LoadLevel("SampleScene");
                Time.timeScale = 1;
                Score.temp = 0;
                prev = 0;

            }
        }
    }
    // Update is called once per frame
    void Update () {
        Touch();

        System.Random rn = new System.Random();
        if (Mathf.Abs(transform.position.z - cube3.transform.position.z) > 45)
        {

            transform.Translate(0f, 0f, 1f * Time.deltaTime * k);
            return;
        }
        if (prev != 0)
        {
            movespeed += (Score.temp - prev) / 30f;
            prev = Score.temp;
        }
        else
            prev = Score.temp;
        if (transform.position.x < 0.66)
        {
            if (GameObject.Find("Cube") != null && !flag1)
            {
                Score.temp += 10;
                flag1 = true;
            }
        }
        if (transform.position.x > -15)
        {
            transform.Translate(-1f * Time.deltaTime * movespeed, 0f, 0f);
        }
        else
        {
            k = rn.Next(2, 20);
            flag1 = false;
            transform.position = new Vector3(26.3f, initialy, initialz);
        }
    }
}

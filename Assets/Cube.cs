using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public Rigidbody rb;
    public int movespeed = 20;
    public bool flag = false;
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Cube")
        {
            flag = false;
            Time.timeScale = 0;
            Touch();
        }
    }
    public void Touch()
    {
        if (Time.timeScale == 0)
        {
            if (Input.touchCount > 0)
            {
                Debug.Log("123123");
                Time.timeScale = 1;

            }
        }
    }
    // Use this for initialization
    void Start()
    {
        movespeed = 20;
        Time.timeScale = 0;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.timeScale);
        Debug.Log("123123");
        if (!flag)
        {
            Touch();
            if (Time.timeScale == 1)
                flag = true;
        }
        rb.transform.Translate(0, 0, -Input.acceleration.x * movespeed * Time.deltaTime);
        

    }
}


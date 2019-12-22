using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour {
    public static int scorevalue = 0;
    public static int temp = 0;
    public int score1;
    string score;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        score1 = Mathf.Max(temp,temp,scorevalue);
        scorevalue = score1;
        GetComponent<TextMesh>().text = "BEST:" + score1.ToString();
	}
}

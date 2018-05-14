using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdate : MonoBehaviour {

    Text text;
    public int StartScore;

    // Use this for initialization
    void Start () {
        text = GameObject.Find("Canvas/ScoreText").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        text.text = "Score:" + StartScore;
    }
}

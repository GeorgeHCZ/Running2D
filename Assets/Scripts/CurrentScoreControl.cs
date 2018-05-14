using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentScoreControl : MonoBehaviour {

    Text text;
    public int StartScore;

    // Use this for initialization
    void Start()
    {
        text = GameObject.Find("Canvas/CurrentScoreText").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Your Score:" + StartScore;
    }
}

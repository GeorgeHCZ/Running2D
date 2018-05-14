using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarControl : MonoBehaviour {

    private ScoreUpdate scoreUpdate;
    private CurrentScoreControl scoreUpdate1;

    // Use this for initialization
    void Start()
    {
        scoreUpdate = GameObject.Find("Canvas/ScoreText").GetComponent<ScoreUpdate>();
        scoreUpdate1 = GameObject.Find("Canvas/CurrentScoreText").GetComponent<CurrentScoreControl>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    //如果有人进入触发区域
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            scoreUpdate.StartScore += 10;
            scoreUpdate1.StartScore = scoreUpdate.StartScore;
            AudioManager.Instance.PlaySound("金币");
            Destroy(gameObject);
        }
    }
}

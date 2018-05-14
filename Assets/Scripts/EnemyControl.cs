using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour {

    //玩家
    private PlayerControl playerControl;

    private Animator ani;

    // Use this for initialization
    void Start () {
        playerControl = GameObject.FindWithTag("Player").GetComponent<PlayerControl>();
        ani = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        if (playerControl.Hp <= 0)
        {
            ani.speed = 0f;
        }
    }
}

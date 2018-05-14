using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundControl : MonoBehaviour {

    public float Speed = 2f;
    //地面预设体
    public GameObject[] Grounds;
    //玩家
    private PlayerControl playerControl;

    // Use this for initialization
    void Start () {
        playerControl = GameObject.FindWithTag("Player").GetComponent<PlayerControl>();
	}
	
	// Update is called once per frame
	void Update () {
        if(playerControl.Hp <= 0)
        {
            return;
        }
        Vector2 v = transform.localPosition;
        v.x -= Speed * Time.deltaTime;
        if(v.x < -7.2f)
        {
            v.x += 7.2f * 2;
            //切换地形
            //删除旧地形
            foreach (Transform trans in transform)
            {
                Destroy(trans.gameObject);
            }
            //创建新地形
            Instantiate(Grounds[Random.Range(0, Grounds.Length)], transform);
        }
        transform.localPosition = v;
	}
}

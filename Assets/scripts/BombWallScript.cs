﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombWallScript : MonoBehaviour {

    public BoxCollider2D BombWall;
    bool HitByBomb;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D (Collision2D coll)
    {
        if (coll.gameObject.tag.Equals("Bomb"))
        {
            print("A bomb is hitting the wall!");
            HitByBomb = true;
            Destroy(coll.gameObject);
            Destroy(gameObject);
        }
    }
}

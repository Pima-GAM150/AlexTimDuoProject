using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombWallScript : MonoBehaviour {

    public BoxCollider2D BombWall;
    public bool HitByBomb;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D (Collision2D coll)
    {
        if (coll.gameObject.tag == "bomb")
        {
            print("A bomb is hitting the wall!");
            HitByBomb = true;
        }
    }
}

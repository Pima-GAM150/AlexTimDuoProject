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

        if (HitByBomb == true)
        {
            Destroy(BombWall);
            print("Destroying the wall!");
        }
        else if (HitByBomb == false)
        {
            print("I can't destroy the wall!");
        }
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag.Equals("Bomb"))
        {
            print("A bomb is hitting the wall!");
            HitByBomb = true;
        }
        else
        {
            HitByBomb = false;
        }
    }
}

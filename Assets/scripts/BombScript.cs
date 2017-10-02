using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScript : MonoBehaviour {

    public Rigidbody2D Bomb;
    public BoxCollider2D BombBoxCollider;

	// Use this for initialization
	void Start () {

        BombBoxCollider.transform.localScale += new Vector3(2, 2, 2);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

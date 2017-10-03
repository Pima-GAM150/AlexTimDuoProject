using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScript : MonoBehaviour {

    public BoxCollider2D BombBoxCollider;

	// Use this for initialization
	void Start () {

        BombBoxCollider.transform.localScale += new Vector3(1.5f, 1.5f, 1.5f);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

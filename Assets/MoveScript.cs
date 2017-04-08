using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		transform.position += 
			new Vector3 (Input.GetAxis("Horizontal"),0,0);
		
	}
}

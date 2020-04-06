using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EsferaScript : MonoBehaviour {

	Rigidbody m_rigibody;

	void Start () {
		m_rigibody = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space))
		{
		
			m_rigibody.AddForce (new Vector3(0, 100, 0));
		
		}
	
	}
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaCubo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTrigerExit(Collider other)
	{
		Destroy (other.gameObject);
	}
}

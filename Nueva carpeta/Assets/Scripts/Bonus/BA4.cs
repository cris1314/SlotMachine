﻿using UnityEngine;
using System.Collections;

public class BA4 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter ().PostNotification (this, "BA4");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

﻿using UnityEngine;
using System.Collections;

public class BB3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter ().PostNotification (this, "BB3");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

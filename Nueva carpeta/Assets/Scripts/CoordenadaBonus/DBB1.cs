﻿using UnityEngine;
using System.Collections;

public class DBB1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter ().PostNotification (this, "DBB1");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

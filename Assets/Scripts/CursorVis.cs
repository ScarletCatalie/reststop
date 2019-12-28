using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorVis : MonoBehaviour {

	// Use this for initialization
	void Update () {
        Cursor.visible = false;
    }
	
	// Update is called once per frame
	void OnDisable()
    {
        Cursor.visible = true;
    }
}

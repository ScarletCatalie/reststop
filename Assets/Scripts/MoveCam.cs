using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCam : MonoBehaviour {

    public Vector3 direction = Vector3.forward;

    // Update is called once per frame

    private void Update()
    {
        transform.Translate(direction * Time.deltaTime, Space.World);
    }
}

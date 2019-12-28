using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Fungus;
public class executefungus :  MonoBehaviour
{
    public Flowchart flowchart;

    private void OnTriggerEnter(Collider Player)
    {
            flowchart.ExecuteBlock("BeatOne");
    }

}


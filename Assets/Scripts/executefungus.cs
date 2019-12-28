using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Fungus;
public class executefungus :  MonoBehaviour
{
    public Flowchart flowchart;
    public string BlockName;

    private void OnTriggerEnter(Collider Player)
    {
            flowchart.ExecuteBlock(BlockName);
    }

}


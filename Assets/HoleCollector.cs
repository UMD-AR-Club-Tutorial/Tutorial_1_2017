using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleCollector : MonoBehaviour {

    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        Destroy(player);
    }
}

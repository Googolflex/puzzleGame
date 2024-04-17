using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Portal : MonoBehaviour
{
    public GameObject secondPortal;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.gameObject.transform.position = secondPortal.transform.position;
        }
    }
}

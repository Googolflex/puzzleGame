using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPlate : MonoBehaviour
{
    [SerializeField] Vector3 force;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.attachedRigidbody.AddForce(force, ForceMode.Impulse);
        }
    }
}

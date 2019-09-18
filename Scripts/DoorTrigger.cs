using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    [SerializeField] private Animator myAnimationController;

    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            myAnimationController.SetBool("DoorOpen", true);
        }

    }

    private void OnTriggerExit(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            myAnimationController.SetBool("DoorOpen", false);
        }

    }
}

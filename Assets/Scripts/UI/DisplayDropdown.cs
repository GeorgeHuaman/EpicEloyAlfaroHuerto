using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayDropdown : MonoBehaviour
{
    public GameObject dropDown;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("AvatarLocal"))
        {
            dropDown.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("AvatarLocal"))
        {
            dropDown.SetActive(false);
        }
    }
}

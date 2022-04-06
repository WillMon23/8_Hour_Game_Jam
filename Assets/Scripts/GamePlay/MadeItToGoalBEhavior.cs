using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MadeItToGoalBEhavior : MonoBehaviour
{
    Vector3 _localPosition;
    private void Start()
    {
        if (transform.parent)
            _localPosition = transform.parent.position;
    }

    private void OnTriggerEnter(Collider other)
    {



        if (other.CompareTag("Goal"))
        {
         
            transform.position = _localPosition;
            transform.parent.position = _localPosition;
        }
    }
}

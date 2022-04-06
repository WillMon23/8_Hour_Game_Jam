using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendParented : MonoBehaviour
{
    private Vector3 _localposition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _localposition = transform.position;
        if (transform.parent)
        {
            transform.localPosition = new Vector3(1, 1, -1);
        }
        else
            transform.localPosition = _localposition;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunParentedBEhavior : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (transform.parent)
            transform.localPosition = new Vector3(1, 1, 0);
        else
            transform.position = new Vector3(0, 10, 0);
    }
}

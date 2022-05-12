using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zpos_static : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, transform.parent.position.y * 0.1f);
    }
}

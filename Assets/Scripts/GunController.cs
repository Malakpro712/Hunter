using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    private float horizontal;
    private float vertical;
    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Mouse X");

        transform.Rotate(0, horizontal, 0);

        vertical = Input.GetAxis("Mouse Y");

        transform.Rotate(0, 0, vertical);
    }
}

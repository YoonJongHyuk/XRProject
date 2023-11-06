using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
    void FixedUpdate()
    {
        Destroy(gameObject, 2f);
    }
}

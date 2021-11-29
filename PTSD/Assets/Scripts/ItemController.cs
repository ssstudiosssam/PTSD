using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    public Transform originalPosition;

    public void GrabEnd()
    {
        transform.position = originalPosition.position;
        transform.rotation = originalPosition.rotation;
    }
}

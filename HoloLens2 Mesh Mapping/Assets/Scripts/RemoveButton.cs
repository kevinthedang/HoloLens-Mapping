using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveButton : MonoBehaviour
{
    public GameObject model;
    public void removeObject()
    {
        Destroy(model);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowSphere : MonoBehaviour
{
    public GameObject model;
    // Start is called before the first frame update
    void Start()
    {
        model.SetActive(false);
    }

    // show sphere in the game scene
    public void showSphere()
    {
        model.SetActive(true);
    }
}

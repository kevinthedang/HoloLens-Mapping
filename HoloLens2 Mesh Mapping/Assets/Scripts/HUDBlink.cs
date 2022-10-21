using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDBlink : MonoBehaviour
{
    public GameObject text;
    private bool isActive = true;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hud Started");
    }

    // change active and active display per time delta
    private void FixedUpdate()
    {
        Debug.Log("Current isActive " + isActive);
        isActive = !isActive;
        Debug.Log("New isActive " + isActive);
        text.SetActive(isActive);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDBlink : MonoBehaviour
{
    public Text text;
    private float InTime = 0.5f;
    private float StayTime = 0.8f;
    private float OutTime = 0.7f;
    private float _timeChecker = 0;
    private Color textColor;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        textColor = text.color;
    }

    // Update per frame
    void Update()
    {
        _timeChecker += Time.deltaTime;
        if (_timeChecker < InTime)
        {
            text.color = new Color(textColor.r, textColor.g, textColor.b, _timeChecker / InTime);
        }
        else if (_timeChecker < InTime + StayTime)
        {
            text.color = new Color(textColor.r, textColor.g, textColor.b, 1);
        }
        else if (_timeChecker < InTime + StayTime + OutTime)
        {
            text.color = new Color(textColor.r, textColor.g, textColor.b, 1 - (_timeChecker - (InTime + StayTime)) / OutTime);
        }
        else
        {
            _timeChecker = 0;
            Debug.Log("Cycle Complete.");
        }
    }
}

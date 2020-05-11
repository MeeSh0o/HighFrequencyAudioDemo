using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValueUpdater : MonoBehaviour {

    public Text text;
    public string title;

    public void SetValue(float value)
    {
        text.text = title + value.ToString();
    }
}

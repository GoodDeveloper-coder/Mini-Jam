using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InkPlayer : MonoBehaviour
{
    [SerializeField] GameObject activeUI;

    public void ToggleActiveUI(bool active)
    {
        if(activeUI)
            activeUI.SetActive(active);
    }
}

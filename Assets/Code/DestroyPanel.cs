using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPanel : MonoBehaviour
{
    public GameObject panel;
    public void OnClick()
    {
        Destroy(panel);
    }
}

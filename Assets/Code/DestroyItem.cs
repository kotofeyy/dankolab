using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class DestroyItem : MonoBehaviour
{
    public void OnClick()
    {
        Destroy(gameObject);
    }
}

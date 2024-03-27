using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public  GameObject scrollableList;
    public  GameObject settingsPanel;
    public  GameObject parent;
    public void ClickStart() 
    {
        Instantiate(scrollableList, parent.transform);
    }
    public void ClickSettings() 
    {
        Instantiate(settingsPanel, parent.transform);
    }
}

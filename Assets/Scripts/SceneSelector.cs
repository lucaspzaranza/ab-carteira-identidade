using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelector : MonoBehaviour
{
    void Start()
    {
        if (Screen.width > Screen.height)
            SceneManager.LoadScene(1); // Desktop
        else
            SceneManager.LoadScene(2); // Mobile   
    }    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoActivator : MonoBehaviour
{
    public GameObject objectToActivate;
    public float timeToActivate;
    public bool activate = true;

    private void OnEnable()
    {
        if(activate)
            Invoke(nameof(ActivateGameObject), timeToActivate);
        else
            Invoke(nameof(DeactivateGameObject), timeToActivate);
    }

    public void ActivateGameObject()
    {
        objectToActivate.SetActive(true);
    }

    public void DeactivateGameObject()
    {
        objectToActivate.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudContext : MonoBehaviour
{
    public GameObject cloudContext;

    public void Enable()
    {
        cloudContext.SetActive(true);
    }
    public void Disable()
    {
            cloudContext.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CameraWithShake : MonoBehaviour
{
    public static CameraWithShake Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject); // Destroy duplicate instances
        }
    }

    public static void Shake(float intesity, float duration)
    { 
        CameraWithShake.Instance.DoShake(intesity,duration);
    }

    public void DoShake(float intesity, float duration) 
    {
        var strenght = new Vector3(intesity, intesity, intesity);
        var camera = GetComponent<Camera>();
        if (camera)
        {
            camera.DOShakeRotation(duration, strenght);
        }
        
    }
}

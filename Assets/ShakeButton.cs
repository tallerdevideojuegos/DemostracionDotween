using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShakeButton : MonoBehaviour
{

    public Slider Intensity;
    public Slider Duration;

    public float MaxIntensity = 90;
    public float MaxDuration = 5;

    public void StartShake()
    {
        float intensity = Intensity.value * MaxIntensity;
        float duration = Duration.value * MaxDuration;
        CameraWithShake.Shake(intensity, duration);
    }
}

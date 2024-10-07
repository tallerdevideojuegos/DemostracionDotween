using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using KinematicCharacterController;

public class ExampleDotweenPlatform : MonoBehaviour
{
    public float baseDuration = 8;

    Tween pathTween;

    public Transform target;
    public PathType pathType = PathType.CatmullRom;
    public Vector3[] waypoints = new[] {
        new Vector3(0, 0, 0),
        new Vector3(0, 0, 5),
    };

    public bool localWaypoints = true;


    void Start()
    {
        if (target == null)
        {
            target = transform;
        }
        Vector3[] convertedWaypoints;
        if (localWaypoints)
        {
            convertedWaypoints = new Vector3[waypoints.Length];
            for (int i = 0; i < waypoints.Length; i++)
            {
                convertedWaypoints[i] = transform.position + waypoints[i];
            }
        }
        else 
        {
            convertedWaypoints = waypoints;
        }
        // Use SetOptions to close the path
        // and SetLookAt to make the target orient to the path itself
        pathTween = target.DOPath(convertedWaypoints, baseDuration, pathType)
            .SetOptions(true);
        // Then set the ease to Linear and use infinite loops
        pathTween.SetEase(Ease.Linear).SetLoops(-1);




        FinalDemoBrain.Instance.OnFrecuenciaChanged += ChangeFrequency;
    }



    private void OnDestroy()
    {
        FinalDemoBrain.Instance.OnFrecuenciaChanged -= ChangeFrequency;
    }

    void ChangeFrequency(float nuevaFrequencia)
    {
        pathTween.timeScale = nuevaFrequencia;
    }
}

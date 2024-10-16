using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleTween : MonoBehaviour
{
    public Vector3 TargetScale;
    public float Duration = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        transform.DOScale(TargetScale, Duration).SetLoops(-1, LoopType.Yoyo);
    }
}

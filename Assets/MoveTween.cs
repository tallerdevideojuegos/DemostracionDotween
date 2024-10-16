using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveTween : MonoBehaviour
{


    public Transform DestinationPoint;
    public Vector3 MovementVector = new Vector3(10, 0 ,0);
    public float Duration = 10f;
    public LoopType loopType;
    public Ease ease;

    // Start is called before the first frame update
    void Start()
    {
        if (DestinationPoint)
        {
            MovementVector = transform.position - DestinationPoint.position;
        }
        transform.DOBlendableMoveBy(MovementVector, Duration).SetLoops(-1, loopType).SetEase(ease);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

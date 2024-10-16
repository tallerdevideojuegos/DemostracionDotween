using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using static UnityEngine.GraphicsBuffer;

public class NPCTweens2 : MonoBehaviour
{
    public Transform LookAtTarget;
    Vector3 targetLastPos;
    Tweener tween;

    // Start is called before the first frame update
    void Start()
    {
        transform.DOScaleY(0.9f, 0.5f).SetLoops(-1, LoopType.Yoyo);
        tween = transform.DOLookAt(LookAtTarget.position, 1.0f, AxisConstraint.Y).SetAutoKill(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (targetLastPos == LookAtTarget.position) return;
        // Add a Restart in the end, so that if the tween was completed it will play again
        tween.ChangeEndValue(LookAtTarget.position, true).Restart();
        targetLastPos = LookAtTarget.position;
    }
}

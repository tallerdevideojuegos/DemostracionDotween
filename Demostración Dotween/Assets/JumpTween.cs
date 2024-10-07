using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpTween : MonoBehaviour
{
    // Serialized
    [Range(0.2f, 2f)]
    [SerializeField] float _jumpDuration = 1.5f;
    [Range(0.1f, 1f)]
    [SerializeField] float _jumpPower = 0.5f;

    Transform _parent;
    Sequence _distortTween;

    Tween AtterizarTween;


    void Awake()
    {
        _parent = this.transform.parent;
    }

    void Start()
    {
        _parent.DOPunchScale(new Vector3(0, 0.2f), 0.45f, 3);

        // Create distortion tween to give impression of "bending and pushing upwards, then landing"
        // (this is not the actual jump movement, just the "body distortion")
        float defScaleY = _parent.localScale.y;
        _distortTween = DOTween.Sequence().SetAutoKill(false).Pause()
            .Append(_parent.DOScaleY(defScaleY * 0.25f, 0.05f))
            .Append(_parent.DOScaleY(defScaleY * 1.25f, 0.15f))
            .Insert(_jumpDuration * 0.5f, _parent.DOScaleY(defScaleY * 0.5f, _jumpDuration * 0.5f - 0.1f).SetEase(Ease.InQuad))
            .Append(_parent.DOScaleY(defScaleY, 0.1f));
    }


    void OnDestroy()
    {
        _distortTween.Kill();
    }

}

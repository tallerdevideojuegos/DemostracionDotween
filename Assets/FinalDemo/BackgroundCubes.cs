using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BackgroundCubes : MonoBehaviour
{
    public Transform target; // Target to follow
    Vector3 targetLastPos;
    Tweener tween;
    public float scaleChange = 0.9f;
    public float timeScaleMultiplier = 1.0f; 
    float scaleToGet;
    float initialScale;

    void Start()
    {
        initialScale = target.transform.localScale.y;
        //esta escala es por si se escala el objeto antes del tween.
        scaleToGet = initialScale * scaleChange;

        FinalDemoBrain.Instance.OnFrecuenciaChanged += ChangeFrequency;
        tween = target.DOScaleY(scaleToGet, FinalDemoBrain.Instance.Frecuencia)
            .SetLoops(-1, LoopType.Yoyo)
            .SetEase(Ease.InOutSine);

        tween.timeScale = 1 * timeScaleMultiplier;
    }
    private void OnDestroy()
    {
        FinalDemoBrain.Instance.OnFrecuenciaChanged -= ChangeFrequency;
    }

    void ChangeFrequency(float nuevaFrequencia)
    {
        tween.timeScale = nuevaFrequencia * timeScaleMultiplier;
    }
}

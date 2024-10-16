using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpSequence : MonoBehaviour
{
    public float duration = 3f;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(0.5f);
        Sequence sequence = DOTween.Sequence();

        Sequence s1 = DOTween.Sequence();

        s1.Append(transform.DOScaleY(0.3f, duration / 3).SetEase(Ease.InOutExpo));
        s1.Append(transform.DOScaleY(1.3f, duration / 4).SetEase(Ease.OutExpo));
        s1.Append(transform.DOScaleY(1f, duration / 5).SetEase(Ease.InSine));


        Sequence s2 = DOTween.Sequence();

        s2.Append(transform.DOMoveZ(10, 5));
        s2.Append(transform.DOMoveZ(15, 1));

        sequence.Append(s1);
        sequence.Append(s2);



        //tengo que poner otra sequencia

        //var v = new Vector3(0, -2 * 0.3f, 0);
        //sequence.Insert(0, transform.DOBlendableMoveBy(v, duration / 3).SetEase(Ease.InOutExpo));

        //sequence.Insert(duration / 3, transform.DOJump(transform.position, 3, 0, duration / 3));

    }




    // Update is called once per frame
    void Update()
    {
        
    }
}

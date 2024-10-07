using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var rb = GetComponent<Rigidbody>();
        var jumpDestination = transform.position + new Vector3(0, 5, 0);
        rb.DOJump(transform.position, 5f, 1, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

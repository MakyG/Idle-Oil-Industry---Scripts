using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimSpeed : MonoBehaviour
{

    Animator m_Animator;
    float animSpeed = 1f;

    public void Start()
    {
        //GlobalCash.CashCount = 642832;
        m_Animator = gameObject.GetComponent<Animator>();
    }

    void Update()
    {

        animSpeed = ((1 / SpeedUpgrade.SpeedIndex) + 0.3f);
        m_Animator.speed = animSpeed;
    }
}

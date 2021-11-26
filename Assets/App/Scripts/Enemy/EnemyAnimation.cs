using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimation : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Run()
    {
        animator.SetBool("run", true);
        animator.SetBool("attack", false);
    }

    public void Attack()
    {
        animator.SetBool("attack", true);
        animator.SetBool("run", false);
    }
}

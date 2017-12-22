using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Animator))]//attyibute
public class EnemyBehavior : MonoBehaviour {
    private Animator animator;
    private void Awake()
    {
        animator = GetComponent<Animator>();
        animator.SetTrigger("die");
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

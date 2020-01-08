﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Intreactable : MonoBehaviour
{
    protected Transform player;
    [Range(0f, 5f)] public float interactionRadius = 1f;
    // Start is called before the first frame update

    void Start()
    {
        Init();
    }

    public abstract void Interact();

    // Update is called once per frame
    void FixedUpdate()
    {
        float distance = Vector2.Distance(transform.position, player.position);

        if (distance < interactionRadius)
        {
            Interact();
        }
    }

    protected virtual void Init()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    protected void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, interactionRadius);
    }
}

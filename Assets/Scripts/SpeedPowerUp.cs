﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerUp : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            StartCoroutine(Pickup(other));
        }

        IEnumerator Pickup(Collider2D player)
        {
            Debug.Log("E");
            PlayerController stats = player.GetComponent<PlayerController>();
            stats.speed += 0.2f;

            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<CircleCollider2D>().enabled = false;

            yield return new WaitForSeconds(3f);

            stats.speed -= 0.2f;
            Destroy(gameObject);
        }
    }
}
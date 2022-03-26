using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    [SerializeField] Transform spawnPosition;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("qr");
        if (collision.CompareTag("Map"))
        {
            
            //collision.transform.position = spawnPosition.position;
        }
    }
}

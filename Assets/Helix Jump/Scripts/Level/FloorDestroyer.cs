using System.Collections.Generic;
using UnityEngine;


public class FloorDestroyer : MonoBehaviour
{
    private List<Rigidbody> rigidbodies = new List<Rigidbody>(12);
    private List<MeshCollider> meshColliders = new List<MeshCollider>(12);
    private float timer = 0;

    private void Awake()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            rigidbodies.Add(transform.GetChild(i).GetComponent<Rigidbody>());
            meshColliders.Add(transform.GetChild(i).GetComponent<MeshCollider>());
        }
    }

    private void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            rigidbodies[i].isKinematic = false;
            meshColliders[i].isTrigger = false;
        }

        gameObject.transform.parent = null;
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer > 2)
        {
            gameObject.SetActive(false);
        }
    }
}
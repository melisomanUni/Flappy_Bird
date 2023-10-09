using System;
using UnityEngine;

public class BirdTracker : MonoBehaviour
{
    [SerializeField] private Bird _bird;
    [SerializeField] private float _xOffset;

    private void Update()
    {
        transform.position = new Vector3(_bird.transform.position.x - _xOffset, transform.position.y,transform.position.z);
    }
}

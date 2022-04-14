using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckRotateScript : MonoBehaviour
{
    float rotationSpeed = 360f;
    GameObject duck;

    private void Start()
    {
        duck = this.gameObject;
    }

    void Update()
    {
        duck.transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }
}

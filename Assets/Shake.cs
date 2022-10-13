using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour
{
    Vector3 originalPosition;
    [Range(0, 10)] [SerializeField] float amplitude = 0.1f; // height
    [Range(0, 10)] [SerializeField] float frequency = 5.0f; // d

    // Start is called before the first frame update
    void Start()
    {
        originalPosition = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 deltaPosition;
        deltaPosition.x = 0.0f;
        //position.y = 0.0f;
        //deltaPosition.y = Mathf.Sin(Time.time * frequency) * amplitude; // -1.0...1.0;
        //deltaPosition.y = Mathf.PerlinNoise(Time.time * frequency, 0.0f) * amplitude; // 0.0...1.0;
        //deltaPosition.y = ((Mathf.PerlinNoise(Time.time * frequency, 0.0f) * 2.0f) - 1.0f) * amplitude; // 0.0...1.0;
        deltaPosition.y = PerlinNoise1D(Time.time * frequency) * amplitude; // 0.0...1.0;
        deltaPosition.z = -2.0f;
        gameObject.transform.position = deltaPosition;
    }

    float PerlinNoise1D(float x)
    {
        float y = 0.0f;
        return(Mathf.PerlinNoise(x, y) * 2.0f) - 1.0f;
    }
}

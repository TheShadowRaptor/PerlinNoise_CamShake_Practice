using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour
{
    [Range(0, 10)] [SerializeField] float amplitude = 5.0f; // height
    [Range(0, 10)] [SerializeField] float frequency = 5.0f; // d

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 localPosition;
        localPosition.x = 0.0f;
        //position.y = 0.0f;
        //deltaPosition.y = Mathf.Sin(Time.time * frequency) * amplitude; // -1.0...1.0;
        //deltaPosition.y = Mathf.PerlinNoise(Time.time * frequency, 0.0f) * amplitude; // 0.0...1.0;
        //deltaPosition.y = ((Mathf.PerlinNoise(Time.time * frequency, 0.0f) * 2.0f) - 1.0f) * amplitude; // 0.0...1.0;
        //deltaPosition.x = PerlinNoise1D(Time.time * frequency) * amplitude; // 0.0...1.0;
        //deltaPosition.x = PerlinNoise1D(-Time.time * frequency) * amplitude; // 0.0...1.0;

        //localposition.y = perlinnoise2d(time.time * frequency, 0.0f) * amplitude; // 0.0...1.0;
        //localposition.x = perlinnoise2d(time.time * frequency, 1.0f) * amplitude; // 0.0...1.0;
        //localposition.z = perlinnoise2d(time.time * frequency, 2.0f) * amplitude; // 0.0...1.0;
        //localposition.z = -10.0f;
        //gameobject.transform.localposition = localposition;

        Vector3 localEulerAngles;
        localEulerAngles.y = PerlinNoise2D(Time.time * frequency, 0.0f) * amplitude; // 0.0...1.0;
        localEulerAngles.x = PerlinNoise2D(Time.time * frequency, 1.0f) * amplitude; // 0.0...1.0;
        localEulerAngles.z = PerlinNoise2D(Time.time * frequency, 2.0f) * amplitude; // 0.0...1.0;
        gameObject.transform.localEulerAngles = localEulerAngles;
    }

    float PerlinNoise1D(float x)
    {
        float y = 0.0f; // hardcoded to 0.0
        return(Mathf.PerlinNoise(x, y) * 2.0f) - 1.0f;
    }

    float PerlinNoise2D(float x, float y)
    { 
        return (Mathf.PerlinNoise(x, y) * 2.0f) - 1.0f;
    }
}

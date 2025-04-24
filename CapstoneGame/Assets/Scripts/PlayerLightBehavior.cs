using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLightBehavior : MonoBehaviour
{

    public GameObject l;
    public Light playerLight;

    public float reductionTime = 100f;
    public float maxScale = 15f;
    public float minScale = 6f;

    public float MaxRange = 7f;
    public float minRange = 3f;
    public float reductionRate = 0.0192f;

    private float startTime;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float elapsedTime = Time.time - startTime;
        float currScale = Mathf.Lerp(maxScale, minScale, elapsedTime/reductionTime);
        transform.localScale = new Vector3 (currScale, currScale, currScale);
        if (playerLight.range > minRange)
        {
            playerLight.range -= reductionRate;
        }
        
    }

    void resetLight()
    {
        transform.localScale = new Vector3(maxScale, maxScale, maxScale);
        GetComponent<Light>().range = MaxRange;
    }
};
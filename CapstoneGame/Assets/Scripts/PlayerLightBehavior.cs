using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLightBehavior : MonoBehaviour
{

    private Light l;

    public float reductionRate = 0.02f;
    public float maxRange = 3.5f;
    public float minRange = 0.75f;

    // Start is called before the first frame update
    void Start()
    {
        l = GetComponent<Light>();
        StartCoroutine(lightShrink());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator lightShrink()
    {
        while(l.range > minRange)
        {
            l.range -= reductionRate;
            yield return new WaitForSeconds(0.5f);
        }

        yield return null;
    }
}

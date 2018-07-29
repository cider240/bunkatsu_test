using UnityEngine;
using UnityEngine.UI;

public class BlinkText : MonoBehaviour
{
    [SerializeField]
    Text blinkText;

    [SerializeField]
    float blinkInterval;
    

    float lastTime;

    void Awake()
    {
  	  // test
        lastTime = Time.time;
    }

    void Update()
    {
        if((Time.time - lastTime) > blinkInterval)
        {
            lastTime = Time.time;
            blinkText.enabled = !blinkText.enabled;
        }
    }
}

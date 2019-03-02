using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightControl : MonoBehaviour
{
    public Toggle lightSwitch;
    public Light lightSource;

    private Slider lightController;
    private readonly float MIN_VALUE = 1000;
    private readonly float MAX_VALUE = 20000;

    // Start is called before the first frame update
    void Start()
    {
        lightSwitch.isOn = false;
        // GameObject.low = lightSource.range;
        // if(gameObject.GetComponent<Slider>().Equals(Slider)){
        //     Debug.Log("matches");
        // }
        // if ()
        lightController = gameObject.GetComponentInChildren(typeof(Slider)) as Slider;
        lightController.minValue = MIN_VALUE;
        lightController.maxValue = MAX_VALUE;
        lightController.value = lightSource.intensity;
    }

    void Update() {
        if (lightSwitch.isOn) {
            float val = lightController.value;
            lightSource.intensity = val;
            lightSource.range = val / 1000;
        }
    }
}

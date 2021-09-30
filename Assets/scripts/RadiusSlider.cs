using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RadiusSlider : MonoBehaviour
{
   
    [SerializeField] private Slider agentSlider;

    [SerializeField] private Text agentText;

    // Start is called before the first frame update
    void Start()
    {
        agentSlider.onValueChanged.AddListener((v)=>{
           Debug.Log(v);
           agentText.text = "Radius Multiplier:" + v.ToString("0.0");
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

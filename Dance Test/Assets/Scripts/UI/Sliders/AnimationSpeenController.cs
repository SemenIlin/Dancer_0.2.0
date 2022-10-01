using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class AnimationSpeenController : MonoBehaviour
{
    private Slider animationSpeed;
    public void Init(List<Dancer> dancers)
    {
        animationSpeed = GetComponent<Slider>();

        var animators = new List<Animator>();
        dancers.ForEach(d => animators.Add(d.GetComponent<Animator>()));

        animationSpeed.onValueChanged.AddListener((speed) =>
        {
            animators.ForEach(a => a.speed = speed);
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

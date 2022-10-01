using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class CharactersSelector : MonoBehaviour
{

    private Button selector;
    [SerializeField] private int numberOfModel;
   
    public void Init(List<Dancer> dancers)
    {
        selector = GetComponent<Button>();
       
        selector.onClick.AddListener(() =>
        {
            dancers.ForEach(d =>
            {
                if (d.Number == numberOfModel)
                {
                    Global.SelectedDancer = d;
                    d.OnDance();
                }
                else
                {
                    d.OnHide();
                }
            });
        });
         
    }   
}

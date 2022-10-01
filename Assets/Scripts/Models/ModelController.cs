using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ModelController : MonoBehaviour
{
   private List<Dancer> dansers = new List<Dancer>();

    public void Init()
    {
        dansers = FindObjectsOfType<Dancer>().ToList();

        if (dansers.Count > 1)
        {
            dansers.ForEach(d => {
                if (d.Number != 1)
                {
                    d.OnHide();
                }
            });
        }
        
    }

    public List<Dancer> Dansers => dansers;
}

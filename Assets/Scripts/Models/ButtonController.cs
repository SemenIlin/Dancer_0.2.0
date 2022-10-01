using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    private List<CharactersSelector> selectors = new List<CharactersSelector>();

    public void Init()
    {
        selectors = FindObjectsOfType<CharactersSelector>().ToList();
    }

    public List<CharactersSelector> Selectors => selectors;

}

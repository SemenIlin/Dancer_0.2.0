using UnityEngine;

public class DanceController : MonoBehaviour
{
    [SerializeField] private Dance _dance;

    private void Start()
    {
        DanceSelector.Notify += UpdateIcon;
    }

    private void UpdateIcon(Sprite icon)
    {
        _dance.DanceIcon = icon;
    }

    protected void OnDestroy()
    {
        DanceSelector.Notify -= UpdateIcon;
    }
}

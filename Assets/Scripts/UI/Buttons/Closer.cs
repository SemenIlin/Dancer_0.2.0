using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class Closer : MonoBehaviour
{
    private Button close;

    private void Start()
    {
        close = GetComponent<Button>();

        close.onClick.AddListener(() => Application.Quit());
    }

    
}

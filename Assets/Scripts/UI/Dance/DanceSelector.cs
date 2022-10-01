using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
[RequireComponent(typeof(Image))]
public class DanceSelector : MonoBehaviour
{
    [SerializeField] private int _danceNumber;

    private Button _selectedDance;
    private Image _iconDance;

    public delegate void DanceSelectedHandler(Sprite icon);
    public static event DanceSelectedHandler? Notify;

    public delegate void DanceHandler(int danceNumber);
    public static event DanceHandler? ChangeDance;


    private void Start()
    {
        _selectedDance = GetComponent<Button>();
        _iconDance = GetComponent<Image>();

        _selectedDance.onClick.AddListener(() =>
        {
            Notify?.Invoke(_iconDance.sprite);
            ChangeDance?.Invoke(_danceNumber);
        });
    }
}

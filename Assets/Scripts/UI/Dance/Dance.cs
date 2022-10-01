using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
[RequireComponent(typeof(Image))]
public class Dance : MonoBehaviour
{
    [SerializeField] private GameObject _danceContainer;

    private Button _danceButton;
    private Image _danceIcon;

    private bool _isSelect;

    private void Start()
    {
        _isSelect = false;
        _danceButton = GetComponent<Button>();
        _danceIcon = GetComponent<Image>();

        _danceButton.onClick.AddListener(() =>
        {
            _isSelect = !_isSelect;
            _danceContainer.SetActive(_isSelect);
        });
    }

    public bool IsSelect => _isSelect;

    public Sprite DanceIcon
    {
        set
        {
            _danceIcon.sprite = value;
        }
    }   
}

using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Dancer : MonoBehaviour, IDancer
{
    [SerializeField] private int _number;

    private Animator _animator;
    public int Number => _number;

    private void Start()
    {
        _animator = GetComponent<Animator>();

        DanceSelector.ChangeDance += OnNewDance;
    }

    public void OnDance()
    {
        gameObject.SetActive(true);
    }

    public void OnHide()
    {
        gameObject.SetActive(false);
    }

    private void OnNewDance(int dance)
    {
        _animator.SetInteger("Dance", dance);
    }

    private void OnDestroy()
    {
        DanceSelector.ChangeDance -= OnNewDance;
    }

}

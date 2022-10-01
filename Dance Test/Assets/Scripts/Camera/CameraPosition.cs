using UnityEngine;
using DG.Tweening;

public class CameraPosition : MonoBehaviour
{
    [SerializeField] private PositionData _leftUpPosition;
    
    [SerializeField] private PositionData _rightUpPosition;
    
    [SerializeField] private PositionData _startPosition;

    private Sequence _sequence;

    public void setCameraPosition(int point)
    {
        _sequence = DOTween.Sequence();
        switch (point)
        {
            case (int)CameraPointName.LeftUp:
                _sequence.Append(transform.DOMove(_leftUpPosition._position, 2))
                    .Join(transform.DORotate(_leftUpPosition._rotation, 2)).OnComplete(clean);

                break;

            case (int)CameraPointName.RightUp:
                _sequence.Append(transform.DOMove(_rightUpPosition._position, 2))
                    .Join(transform.DORotate(_rightUpPosition._rotation, 2)).OnComplete(clean);

                break;

            case (int)CameraPointName.Center:

                _sequence.Append(transform.DOMove(_startPosition._position, 2))
                    .Join(transform.DORotate(_startPosition._rotation, 2)).OnComplete(clean);
                break;

        }
    }

    private void clean()
    {
        _sequence = null;
    }


}

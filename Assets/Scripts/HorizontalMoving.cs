using UnityEngine;

public class HorizontalMoving : MonoBehaviour
{
    [SerializeField] private float _xPositionStart;
    [SerializeField] private float _xPositionEnd;

    private Vector3 _left;
    private Vector3 _right;
    private float _currentTime;

    private void Awake()
    {
        FindObjectsOfType<GameObject>();
    }

    private void Start()
    {
        _left.x = _xPositionStart;
        _right.x = _xPositionEnd;
    }

    private void Update()
    {
        _currentTime += Time.deltaTime;
        var progress = (Mathf.Sin(_currentTime) + 1) / 2;
        var newPosition = Vector3.Lerp(_left, _right, progress);
        transform.position = newPosition;
    }
}
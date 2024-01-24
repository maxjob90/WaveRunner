using UnityEngine;

public class VerticalMoving : MonoBehaviour
{
    [SerializeField] private float _yPositionStart;
    [SerializeField] private float _yPositionEnd;

    private Vector3 _top;
    private Vector3 _bottom;
    private float _currentTime;

    private void Awake()
    {
        FindObjectsOfType<GameObject>();
    }

    private void Start()
    {
        _top.y = _yPositionStart;
        _bottom.y = _yPositionEnd;
    }

    private void Update()
    {
        _currentTime += Time.deltaTime;
        var progress = (Mathf.Sin(_currentTime) + 1)*2;
        var newPosition = Vector3.Lerp(_top, _bottom, progress);
        transform.position = newPosition;
    }
}

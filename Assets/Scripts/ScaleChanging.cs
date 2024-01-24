using UnityEngine;

public class ScaleChanging : MonoBehaviour
{
    [SerializeField] private float _duration = 2f;
    [SerializeField] private Vector3 _endScale;
    [SerializeField] private Vector3 _startScale;

    private float _currentTime;

    private void Update()
    {
        var localScale = transform.localScale;
        _currentTime += Time.deltaTime;
        var progress = Mathf.PingPong(_currentTime, _duration) / _duration;
        localScale = Vector3.Lerp(_startScale, _endScale, progress);
        transform.localScale = localScale;
    }
}
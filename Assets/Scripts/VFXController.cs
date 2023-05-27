using UnityEngine;

public class VFXController : MonoBehaviour
{
    [SerializeField] private ParticleSystem _particleSystem1;
    [SerializeField] private ParticleSystem _particleSystem2;

    [SerializeField] float _distance = 100f;

    private Vector3 _pos1;
    private Quaternion _defaultRotation;

    private bool _isForward = true;

    // Start is called before the first frame update
    void Start()
    {
        PlayEffect();

        _pos1 = transform.localPosition;
        _defaultRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (!_particleSystem1.isPlaying || !_particleSystem2.isPlaying)
        {
            _isForward = !_isForward;
            SetNewForwardAndPosition();
            PlayEffect();
        }
    }

    private void PlayEffect()
    {
        _particleSystem1.Play();
        _particleSystem2.Play();
    }

    private void SetNewForwardAndPosition()
    {
        if (_isForward)
        {
            transform.localPosition = _pos1;
            transform.localRotation = _defaultRotation;

            return;
        }

        transform.localPosition = new Vector3(_pos1.x, _pos1.y, _pos1.z + _distance);
        transform.transform.Rotate(0f, 180f, 0.0f, Space.Self);
    }
}

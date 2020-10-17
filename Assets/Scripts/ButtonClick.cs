using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class ButtonClick : MonoBehaviour
{
    private AudioSource _audioSource;

    [SerializeField] private AudioClip _audioClip;
    
    // Start is called before the first frame update
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        _audioSource.clip = _audioClip;
    }

    public void ButtonSound()
    {
        _audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

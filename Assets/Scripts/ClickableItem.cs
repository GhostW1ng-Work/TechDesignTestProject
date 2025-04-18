using UnityEngine;

public class ClickableItem : MonoBehaviour
{
	private const string PLAY = "Play";

	[Header("Audio")]
	[SerializeField] private AudioSource _audioSource;

	[Header("Animation")]
	[SerializeField] private Animator _animator;

	[Header("VFX")]
	[SerializeField] private ParticleSystem _particles;

	private void OnMouseDown()
	{
		if(_animator != null)
		{
			_animator.SetTrigger(PLAY);
		} 

		if(_audioSource != null)
		{
			_audioSource.Play();
		}

		if(_particles != null)
		{
			_particles.Play();
		}
	}

}

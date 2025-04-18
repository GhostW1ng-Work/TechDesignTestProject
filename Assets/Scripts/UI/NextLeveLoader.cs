using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextLeveLoader : MonoBehaviour
{
	private Button _button;

	private void Awake()
	{
		_button = GetComponent<Button>();
	}

	private void OnEnable()
	{
		_button.onClick.AddListener(LoadNextLevel);
	}

	private void OnDisable()
	{
		_button.onClick.RemoveListener(LoadNextLevel);
	}

	private void LoadNextLevel()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}

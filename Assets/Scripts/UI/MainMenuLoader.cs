using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuLoader : MonoBehaviour
{
	private const int MAIN_MENU_INDEX = 0;
	private Button _button;

	private void Awake()
	{
		_button = GetComponent<Button>();
	}

	private void OnEnable()
	{
		_button.onClick.AddListener(LoadMainMenu);
	}

	private void OnDisable()
	{
		_button.onClick.RemoveListener(LoadMainMenu);
	}

	private void LoadMainMenu()
	{
		SceneManager.LoadScene(MAIN_MENU_INDEX);
	}
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
namespace StartMenu
{
public class MainMenuScript : MonoBehaviour {

		private string[] sceneList = { "Level01", "Level02", "Level03", "Level04", "Level05" };
		public int level;

		public void LoadLevel(int level)
		{

			SceneManager.LoadScene (sceneList[level]);



		}

		 





		public void ExitGame()
		{
			Application.Quit ();

		}

}
}
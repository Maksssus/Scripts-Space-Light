using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class menu : MonoBehaviour {


	public void Settings (){
		Application.LoadLevel ("Menu");
	}
	public void Loadlevel(Game g){
		Application.LoadLevel (g.level+1);
	}
	public void LoadLevelS(string level){
		Application.LoadLevel (level);
	}

}

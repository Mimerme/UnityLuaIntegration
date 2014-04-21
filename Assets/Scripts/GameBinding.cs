using UnityEngine;
using System.Collections;

using LuaInterface; //Reference the LuaInterface DLL

public class GameBinding  {
	//Lua Functions to call
	public LuaFunction startFunc;
	public LuaFunction updateFunc;
	
	
	
	//Default methods modders can acess
	//RECOMENDED: DO NOT MODIFY CODE BELLOW THIS LINE
public void Information(){
		Debug.Log ("Put all methods that you want the modder to access here. They can acces it by doing 'GameBinding:[MethodName]' Good Luck!");
	}
}
LINK MODDING LIBRARY(sometimes referenced to as API) IS DESIGNED FOR COMMERCIAL AND NON-PROFIT USE
===================================================================
HOW TO USE
----------
1.Chose a scene to load your mods in, and attach the ModLoader script component to any gameobject
2.Chose a folder to have your users put their ModScripts in (default is C:\LinkMods). It is recommended to add exceptions if the user's computer does not have
the specified path on their computer
3.Set up your GameBinding.cs. Right out of the box, if you write some methods in GameBinding.cs, you can access them in your lua script by doing gamebinding:[method_name]
Because LINK is a method based modding system, where modders are restricted to what game developers allow them to access and use, you will need to write your own methods to interact with your game (ex. AddEntity())
It's also recommended to build your game around the method based system, so you won't have to both create a game & and modding API

WRITING A LUA SCRIPT
--------------------
function Start()  --Called on start of script


end
function Update()  --Called on every frame update

end

luabinding:BindFunc(Start, Update)

THAT is what your default Lua script should look like
do gamebinding:[method_name] to access methods you create
do luabinding:[method_name] to access default methods out of the box

GITHUB
======


LEGAL STUFF
===========
The MIT License (MIT)

Copyright (c) [2014] [LINK MODDING LIBRARY]

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
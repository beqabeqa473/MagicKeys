using System;
using System.Threading;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public static partial class Serum
{

public static void PluginLoad()
{
MouseClick("Left", P[1]+150, P[2]+20, 1, 0, 0, 10);
Thread.Sleep(200);
if (ImgSearch(@"Images\Serum\SerumLogo.bmp")[0] == 1)
{
VUIObjectSwitcher(true, "false", 6, 6);
}
else if (ImgSearch(@"Images\Serum\SerumReg.bmp")[0] == 1)
{
VUIObjectSwitcher(true, "false", 1, 5);
}
else
{
Speak("Перед использованием этого плагина выполните соответствующую инструкцию для него из папки settings");
return;
}
KeyReg();
}

public static void PluginUnLoad()
{
KeyUnReg();
}

}
}
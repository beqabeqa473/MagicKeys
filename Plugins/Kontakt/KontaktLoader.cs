using System;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public static partial class Kontakt
{

public static void PluginLoad()
{
VUILoader(API.GetVUI());
if (API.GetVUIName() == "Kontakt")
{
KontaktNormalize();
LibLoaded();
}
KeyReg();
}

public static void PluginUnLoad()
{
KeyUnReg();
}

}
}
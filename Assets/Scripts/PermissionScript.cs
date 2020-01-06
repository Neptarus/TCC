using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;

#if PLATFORM_ANDROID
public class PermissionScript : MonoBehaviour {
GameObject dialog = null;
void Awake()
{

if (!Permission.HasUserAuthorizedPermission(Permission.ExternalStorageRead))
{
Permission.RequestUserPermission(Permission.ExternalStorageRead);
}
}

}
#endif
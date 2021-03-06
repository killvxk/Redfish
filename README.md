# Redfish

Redfish is a simple and flexible SMB server on Windows. It was started by [Skyjos](https://www.skyjos.com) team and open source on GitHub. Redfish gives you an alternative way to run file sharing service on Windows. It's more flexible and simpler than Windows file sharing service. You could set up share folders, user account even change the port in the application.

## Screenshots:
![](https://github.com/skyjos-com/Redfish/blob/master/screenshot_1.PNG)

## How it works:

Redfish is written in C# and requires .NET Framework 4 or above. It has 3 modules:
* Redfish (Main module): Run file sharing as a standalone application. 
* RedfishService Module: Run file sharing as a Windows service.
* Setup Module: Packaging application into setup.mis

Tested on Windows 7 and Windows 10.

### Notes:

The 445 port is taken by Windows file sharing service, so Redfish use 20445 as default service port.

## 3rd-party Libraries:

* [SMBLibrary](https://github.com/TalAloni/SMBLibrary): A SMB server library from [TalAloni](https://github.com/TalAloni).

## Contact:

If you have any suggestions or questions, feel free to contact us [support@skyjos.com](support@skyjos.com).

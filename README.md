# Put your application in Windows Startup

In this example I'll show how you can put your application in Windows Startup. One of the solutions to put yout application in Windows Startup is putting shortcut of your application in the startup folder of Windows.

To do it manually (to give it a try), you can follow the instructios shared in [Add an app to run automatically at startup in Windows 10](https://support.microsoft.com/en-us/windows/add-an-app-to-run-automatically-at-startup-in-windows-10-150da165-dcd9-7230-517b-cf3c295d89dd?WT.mc_id=DT-MVP-5003235):

1. Press Win + R keys to open Run window
2. Type `shell:startup` and press Enter
3. Right click and Add new shortcut to your application.

Now if you sign-out from windows and sign in again, you will see the application will run at start up.

In this example, I'll do above using two different ways:
1. Creating a Setup project to install the application and put in startup
2. Adding the shortcut to the startup foler using code



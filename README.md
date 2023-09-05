# adbGUI
- Based on the work of https://github.com/hexadezi/adbGUI
- sjd dlls are dll made by Shomrom Joseph David which are tools and extensions bundled for easy development without rewriting code.

- Added Drag & Drop to Side Load, Files and APK Info
- Re-factored some sections to functions

- Added AAPT and AAPT2 in a dll sjd.apk.reader.dll (What is AAPT - Android Asset Packaging Tool)
- This dll and function gives the ability to get information for the APK packages

- Fixed JIT Debugger - Exception Code that was thrown on some pcs where OEM codepage for some reason = 1
- added UTF-8 CodePage

Which includes the following
1. APK Name
2. Version Name
3. Package Name
4. SDK version
5. Target SDK version
6. Version Code

- Added scrcpy 64 bit more work is needed
  
#### Screenshots
This is the main window.
![new gui](screenshot/screenshot_2_1.png)  
